using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class DtlsClientProtocol : DtlsProtocol
{
	protected internal class ClientHandshakeState
	{
		internal TlsClient client;

		internal TlsClientContextImpl clientContext;

		internal TlsSession tlsSession;

		internal SessionParameters sessionParameters;

		internal TlsSecret sessionMasterSecret;

		internal SessionParameters.Builder sessionParametersBuilder;

		internal int[] offeredCipherSuites;

		internal IDictionary clientExtensions;

		internal IDictionary serverExtensions;

		internal bool resumedSession;

		internal bool expectSessionTicket;

		internal IDictionary clientAgreements;

		internal TlsKeyExchange keyExchange;

		internal TlsAuthentication authentication;

		internal CertificateStatus certificateStatus;

		internal CertificateRequest certificateRequest;

		internal TlsCredentials clientCredentials;

		internal TlsHeartbeat heartbeat;

		internal short heartbeatPolicy = 2;
	}

	public virtual DtlsTransport Connect(TlsClient client, DatagramTransport transport)
	{
		if (client == null)
		{
			throw new ArgumentNullException("client");
		}
		if (transport == null)
		{
			throw new ArgumentNullException("transport");
		}
		ClientHandshakeState clientHandshakeState = new ClientHandshakeState();
		clientHandshakeState.client = client;
		clientHandshakeState.clientContext = new TlsClientContextImpl(client.Crypto);
		client.Init(clientHandshakeState.clientContext);
		clientHandshakeState.clientContext.HandshakeBeginning(client);
		SecurityParameters securityParameters = clientHandshakeState.clientContext.SecurityParameters;
		securityParameters.m_extendedPadding = client.ShouldUseExtendedPadding();
		TlsSession sessionToResume = clientHandshakeState.client.GetSessionToResume();
		if (sessionToResume != null && sessionToResume.IsResumable)
		{
			SessionParameters sessionParameters = sessionToResume.ExportSessionParameters();
			if (sessionParameters != null && (sessionParameters.IsExtendedMasterSecret || (!clientHandshakeState.client.RequiresExtendedMasterSecret() && clientHandshakeState.client.AllowLegacyResumption())))
			{
				TlsSecret masterSecret = sessionParameters.MasterSecret;
				lock (masterSecret)
				{
					if (masterSecret.IsAlive())
					{
						clientHandshakeState.tlsSession = sessionToResume;
						clientHandshakeState.sessionParameters = sessionParameters;
						clientHandshakeState.sessionMasterSecret = clientHandshakeState.clientContext.Crypto.AdoptSecret(masterSecret);
					}
				}
			}
		}
		DtlsRecordLayer dtlsRecordLayer = new DtlsRecordLayer(clientHandshakeState.clientContext, clientHandshakeState.client, transport);
		client.NotifyCloseHandle(dtlsRecordLayer);
		try
		{
			return ClientHandshake(clientHandshakeState, dtlsRecordLayer);
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			AbortClientHandshake(clientHandshakeState, dtlsRecordLayer, tlsFatalAlert.AlertDescription);
			throw tlsFatalAlert;
		}
		catch (IOException ex)
		{
			AbortClientHandshake(clientHandshakeState, dtlsRecordLayer, 80);
			throw ex;
		}
		catch (Exception alertCause)
		{
			AbortClientHandshake(clientHandshakeState, dtlsRecordLayer, 80);
			throw new TlsFatalAlert(80, alertCause);
		}
		finally
		{
			securityParameters.Clear();
		}
	}

	internal virtual void AbortClientHandshake(ClientHandshakeState state, DtlsRecordLayer recordLayer, short alertDescription)
	{
		recordLayer.Fail(alertDescription);
		InvalidateSession(state);
	}

	internal virtual DtlsTransport ClientHandshake(ClientHandshakeState state, DtlsRecordLayer recordLayer)
	{
		SecurityParameters securityParameters = state.clientContext.SecurityParameters;
		DtlsReliableHandshake dtlsReliableHandshake = new DtlsReliableHandshake(state.clientContext, recordLayer, state.client.GetHandshakeTimeoutMillis(), null);
		byte[] array = GenerateClientHello(state);
		recordLayer.SetWriteVersion(ProtocolVersion.DTLSv10);
		dtlsReliableHandshake.SendMessage(1, array);
		DtlsReliableHandshake.Message message = dtlsReliableHandshake.ReceiveMessage();
		while (message.Type == 3)
		{
			byte[] cookie = ProcessHelloVerifyRequest(state, message.Body);
			byte[] body = PatchClientHelloWithCookie(array, cookie);
			dtlsReliableHandshake.ResetAfterHelloVerifyRequestClient();
			dtlsReliableHandshake.SendMessage(1, body);
			message = dtlsReliableHandshake.ReceiveMessage();
		}
		if (message.Type == 2)
		{
			ProtocolVersion readVersion = recordLayer.ReadVersion;
			ReportServerVersion(state, readVersion);
			recordLayer.SetWriteVersion(readVersion);
			ProcessServerHello(state, message.Body);
			dtlsReliableHandshake.HandshakeHash.NotifyPrfDetermined();
			DtlsProtocol.ApplyMaxFragmentLengthExtension(recordLayer, securityParameters.MaxFragmentLength);
			if (state.resumedSession)
			{
				securityParameters.m_masterSecret = state.sessionMasterSecret;
				recordLayer.InitPendingEpoch(TlsUtilities.InitCipher(state.clientContext));
				securityParameters.m_peerVerifyData = TlsUtilities.CalculateVerifyData(state.clientContext, dtlsReliableHandshake.HandshakeHash, isServer: true);
				ProcessFinished(dtlsReliableHandshake.ReceiveMessageBody(20), securityParameters.PeerVerifyData);
				securityParameters.m_localVerifyData = TlsUtilities.CalculateVerifyData(state.clientContext, dtlsReliableHandshake.HandshakeHash, isServer: false);
				dtlsReliableHandshake.SendMessage(20, securityParameters.LocalVerifyData);
				dtlsReliableHandshake.Finish();
				if (securityParameters.IsExtendedMasterSecret)
				{
					securityParameters.m_tlsUnique = securityParameters.PeerVerifyData;
				}
				securityParameters.m_localCertificate = state.sessionParameters.LocalCertificate;
				securityParameters.m_peerCertificate = state.sessionParameters.PeerCertificate;
				securityParameters.m_pskIdentity = state.sessionParameters.PskIdentity;
				securityParameters.m_srpIdentity = state.sessionParameters.SrpIdentity;
				state.clientContext.HandshakeComplete(state.client, state.tlsSession);
				recordLayer.InitHeartbeat(state.heartbeat, 1 == state.heartbeatPolicy);
				return new DtlsTransport(recordLayer);
			}
			InvalidateSession(state);
			state.tlsSession = TlsUtilities.ImportSession(securityParameters.SessionID, null);
			state.sessionParameters = null;
			state.sessionMasterSecret = null;
			message = dtlsReliableHandshake.ReceiveMessage();
			if (message.Type == 23)
			{
				ProcessServerSupplementalData(state, message.Body);
				message = dtlsReliableHandshake.ReceiveMessage();
			}
			else
			{
				state.client.ProcessServerSupplementalData(null);
			}
			state.keyExchange = TlsUtilities.InitKeyExchangeClient(state.clientContext, state.client);
			if (message.Type == 11)
			{
				ProcessServerCertificate(state, message.Body);
				message = dtlsReliableHandshake.ReceiveMessage();
			}
			else
			{
				state.authentication = null;
			}
			if (message.Type == 22)
			{
				if (securityParameters.StatusRequestVersion < 1)
				{
					throw new TlsFatalAlert(10);
				}
				ProcessCertificateStatus(state, message.Body);
				message = dtlsReliableHandshake.ReceiveMessage();
			}
			TlsUtilities.ProcessServerCertificate(state.clientContext, state.certificateStatus, state.keyExchange, state.authentication, state.clientExtensions, state.serverExtensions);
			if (message.Type == 12)
			{
				ProcessServerKeyExchange(state, message.Body);
				message = dtlsReliableHandshake.ReceiveMessage();
			}
			else
			{
				state.keyExchange.SkipServerKeyExchange();
			}
			if (message.Type == 13)
			{
				ProcessCertificateRequest(state, message.Body);
				TlsUtilities.EstablishServerSigAlgs(securityParameters, state.certificateRequest);
				TlsUtilities.TrackHashAlgorithms(dtlsReliableHandshake.HandshakeHash, securityParameters.ServerSigAlgs);
				message = dtlsReliableHandshake.ReceiveMessage();
			}
			if (message.Type == 14)
			{
				if (message.Body.Length != 0)
				{
					throw new TlsFatalAlert(50);
				}
				IList clientSupplementalData = state.client.GetClientSupplementalData();
				if (clientSupplementalData != null)
				{
					byte[] body2 = DtlsProtocol.GenerateSupplementalData(clientSupplementalData);
					dtlsReliableHandshake.SendMessage(23, body2);
				}
				if (state.certificateRequest != null)
				{
					state.clientCredentials = TlsUtilities.EstablishClientCredentials(state.authentication, state.certificateRequest);
					Certificate certificate = null;
					if (state.clientCredentials != null)
					{
						certificate = state.clientCredentials.Certificate;
					}
					DtlsProtocol.SendCertificateMessage(state.clientContext, dtlsReliableHandshake, certificate, null);
				}
				TlsCredentialedSigner tlsCredentialedSigner = null;
				TlsStreamSigner tlsStreamSigner = null;
				if (state.clientCredentials != null)
				{
					state.keyExchange.ProcessClientCredentials(state.clientCredentials);
					if (state.clientCredentials is TlsCredentialedSigner)
					{
						tlsCredentialedSigner = (TlsCredentialedSigner)state.clientCredentials;
						tlsStreamSigner = tlsCredentialedSigner.GetStreamSigner();
					}
				}
				else
				{
					state.keyExchange.SkipClientCredentials();
				}
				bool forceBuffering = tlsStreamSigner != null;
				TlsUtilities.SealHandshakeHash(state.clientContext, dtlsReliableHandshake.HandshakeHash, forceBuffering);
				byte[] body3 = GenerateClientKeyExchange(state);
				dtlsReliableHandshake.SendMessage(16, body3);
				securityParameters.m_sessionHash = TlsUtilities.GetCurrentPrfHash(dtlsReliableHandshake.HandshakeHash);
				TlsProtocol.EstablishMasterSecret(state.clientContext, state.keyExchange);
				recordLayer.InitPendingEpoch(TlsUtilities.InitCipher(state.clientContext));
				if (tlsCredentialedSigner != null)
				{
					DigitallySigned certificateVerify = TlsUtilities.GenerateCertificateVerifyClient(state.clientContext, tlsCredentialedSigner, tlsStreamSigner, dtlsReliableHandshake.HandshakeHash);
					byte[] body4 = GenerateCertificateVerify(state, certificateVerify);
					dtlsReliableHandshake.SendMessage(15, body4);
				}
				dtlsReliableHandshake.PrepareToFinish();
				securityParameters.m_localVerifyData = TlsUtilities.CalculateVerifyData(state.clientContext, dtlsReliableHandshake.HandshakeHash, isServer: false);
				dtlsReliableHandshake.SendMessage(20, securityParameters.LocalVerifyData);
				if (state.expectSessionTicket)
				{
					message = dtlsReliableHandshake.ReceiveMessage();
					if (message.Type != 4)
					{
						throw new TlsFatalAlert(10);
					}
					ProcessNewSessionTicket(state, message.Body);
				}
				securityParameters.m_peerVerifyData = TlsUtilities.CalculateVerifyData(state.clientContext, dtlsReliableHandshake.HandshakeHash, isServer: true);
				ProcessFinished(dtlsReliableHandshake.ReceiveMessageBody(20), securityParameters.PeerVerifyData);
				dtlsReliableHandshake.Finish();
				state.sessionMasterSecret = securityParameters.MasterSecret;
				state.sessionParameters = new SessionParameters.Builder().SetCipherSuite(securityParameters.CipherSuite).SetExtendedMasterSecret(securityParameters.IsExtendedMasterSecret).SetLocalCertificate(securityParameters.LocalCertificate)
					.SetMasterSecret(state.clientContext.Crypto.AdoptSecret(state.sessionMasterSecret))
					.SetNegotiatedVersion(securityParameters.NegotiatedVersion)
					.SetPeerCertificate(securityParameters.PeerCertificate)
					.SetPskIdentity(securityParameters.PskIdentity)
					.SetSrpIdentity(securityParameters.SrpIdentity)
					.SetServerExtensions(state.serverExtensions)
					.Build();
				state.tlsSession = TlsUtilities.ImportSession(state.tlsSession.SessionID, state.sessionParameters);
				securityParameters.m_tlsUnique = securityParameters.LocalVerifyData;
				state.clientContext.HandshakeComplete(state.client, state.tlsSession);
				recordLayer.InitHeartbeat(state.heartbeat, 1 == state.heartbeatPolicy);
				return new DtlsTransport(recordLayer);
			}
			throw new TlsFatalAlert(10);
		}
		throw new TlsFatalAlert(10);
	}

	protected virtual byte[] GenerateCertificateVerify(ClientHandshakeState state, DigitallySigned certificateVerify)
	{
		MemoryStream memoryStream = new MemoryStream();
		certificateVerify.Encode(memoryStream);
		return memoryStream.ToArray();
	}

	protected virtual byte[] GenerateClientHello(ClientHandshakeState state)
	{
		TlsClientContextImpl clientContext = state.clientContext;
		SecurityParameters securityParameters = clientContext.SecurityParameters;
		clientContext.SetClientSupportedVersions(state.client.GetProtocolVersions());
		ProtocolVersion latestDtls = ProtocolVersion.GetLatestDtls(clientContext.ClientSupportedVersions);
		if (!ProtocolVersion.IsSupportedDtlsVersionClient(latestDtls))
		{
			throw new TlsFatalAlert(80);
		}
		clientContext.SetClientVersion(latestDtls);
		byte[] array = TlsUtilities.GetSessionID(state.tlsSession);
		bool num = state.client.IsFallback();
		state.offeredCipherSuites = state.client.GetCipherSuites();
		if (array.Length != 0 && state.sessionParameters != null && !Arrays.Contains(state.offeredCipherSuites, state.sessionParameters.CipherSuite))
		{
			array = TlsUtilities.EmptyBytes;
		}
		state.clientExtensions = TlsExtensionsUtilities.EnsureExtensionsInitialised(state.client.GetClientExtensions());
		ProtocolVersion protocolVersion = latestDtls;
		if (latestDtls.IsLaterVersionOf(ProtocolVersion.DTLSv12))
		{
			protocolVersion = ProtocolVersion.DTLSv12;
			TlsExtensionsUtilities.AddSupportedVersionsExtensionClient(state.clientExtensions, clientContext.ClientSupportedVersions);
		}
		clientContext.SetRsaPreMasterSecretVersion(protocolVersion);
		securityParameters.m_clientServerNames = TlsExtensionsUtilities.GetServerNameExtensionClient(state.clientExtensions);
		if (TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(latestDtls))
		{
			TlsUtilities.EstablishClientSigAlgs(securityParameters, state.clientExtensions);
		}
		securityParameters.m_clientSupportedGroups = TlsExtensionsUtilities.GetSupportedGroupsExtension(state.clientExtensions);
		state.clientAgreements = TlsUtilities.AddKeyShareToClientHello(state.clientContext, state.client, state.clientExtensions);
		if (TlsUtilities.IsExtendedMasterSecretOptionalDtls(clientContext.ClientSupportedVersions) && state.client.ShouldUseExtendedMasterSecret())
		{
			TlsExtensionsUtilities.AddExtendedMasterSecretExtension(state.clientExtensions);
		}
		else if (!TlsUtilities.IsTlsV13(latestDtls) && state.client.RequiresExtendedMasterSecret())
		{
			throw new TlsFatalAlert(80);
		}
		bool useGmtUnixTime = ProtocolVersion.DTLSv12.IsEqualOrLaterVersionOf(latestDtls) && state.client.ShouldUseGmtUnixTime();
		securityParameters.m_clientRandom = TlsProtocol.CreateRandomBlock(useGmtUnixTime, state.clientContext);
		if ((TlsUtilities.GetExtensionData(state.clientExtensions, 65281) == null) & !Arrays.Contains(state.offeredCipherSuites, 255))
		{
			state.offeredCipherSuites = Arrays.Append(state.offeredCipherSuites, 255);
		}
		if (num && !Arrays.Contains(state.offeredCipherSuites, 22016))
		{
			state.offeredCipherSuites = Arrays.Append(state.offeredCipherSuites, 22016);
		}
		state.heartbeat = state.client.GetHeartbeat();
		state.heartbeatPolicy = state.client.GetHeartbeatPolicy();
		if (state.heartbeat != null || 1 == state.heartbeatPolicy)
		{
			TlsExtensionsUtilities.AddHeartbeatExtension(state.clientExtensions, new HeartbeatExtension(state.heartbeatPolicy));
		}
		ClientHello clientHello = new ClientHello(protocolVersion, securityParameters.ClientRandom, array, TlsUtilities.EmptyBytes, state.offeredCipherSuites, state.clientExtensions, 0);
		MemoryStream memoryStream = new MemoryStream();
		clientHello.Encode(state.clientContext, memoryStream);
		return memoryStream.ToArray();
	}

	protected virtual byte[] GenerateClientKeyExchange(ClientHandshakeState state)
	{
		MemoryStream memoryStream = new MemoryStream();
		state.keyExchange.GenerateClientKeyExchange(memoryStream);
		return memoryStream.ToArray();
	}

	protected virtual void InvalidateSession(ClientHandshakeState state)
	{
		if (state.sessionMasterSecret != null)
		{
			state.sessionMasterSecret.Destroy();
			state.sessionMasterSecret = null;
		}
		if (state.sessionParameters != null)
		{
			state.sessionParameters.Clear();
			state.sessionParameters = null;
		}
		if (state.tlsSession != null)
		{
			state.tlsSession.Invalidate();
			state.tlsSession = null;
		}
	}

	protected virtual void ProcessCertificateRequest(ClientHandshakeState state, byte[] body)
	{
		if (state.authentication == null)
		{
			throw new TlsFatalAlert(40);
		}
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		CertificateRequest certificateRequest = CertificateRequest.Parse(state.clientContext, memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		state.certificateRequest = TlsUtilities.ValidateCertificateRequest(certificateRequest, state.keyExchange);
	}

	protected virtual void ProcessCertificateStatus(ClientHandshakeState state, byte[] body)
	{
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		state.certificateStatus = CertificateStatus.Parse(state.clientContext, memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
	}

	protected virtual byte[] ProcessHelloVerifyRequest(ClientHandshakeState state, byte[] body)
	{
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		ProtocolVersion protocolVersion = TlsUtilities.ReadVersion(memoryStream);
		int maxLength = (ProtocolVersion.DTLSv12.IsEqualOrEarlierVersionOf(protocolVersion) ? 255 : 32);
		byte[] result = TlsUtilities.ReadOpaque8(memoryStream, 0, maxLength);
		TlsProtocol.AssertEmpty(memoryStream);
		if (!protocolVersion.IsEqualOrEarlierVersionOf(state.clientContext.ClientVersion))
		{
			throw new TlsFatalAlert(47);
		}
		return result;
	}

	protected virtual void ProcessNewSessionTicket(ClientHandshakeState state, byte[] body)
	{
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		NewSessionTicket newSessionTicket = NewSessionTicket.Parse(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		state.client.NotifyNewSessionTicket(newSessionTicket);
	}

	protected virtual void ProcessServerCertificate(ClientHandshakeState state, byte[] body)
	{
		state.authentication = TlsUtilities.ReceiveServerCertificate(state.clientContext, state.client, new MemoryStream(body, writable: false));
	}

	protected virtual void ProcessServerHello(ClientHandshakeState state, byte[] body)
	{
		ServerHello serverHello = ServerHello.Parse(new MemoryStream(body, writable: false));
		ProtocolVersion version = serverHello.Version;
		state.serverExtensions = serverHello.Extensions;
		SecurityParameters securityParameters = state.clientContext.SecurityParameters;
		ReportServerVersion(state, version);
		securityParameters.m_serverRandom = serverHello.Random;
		if (!state.clientContext.ClientVersion.Equals(version))
		{
			TlsUtilities.CheckDowngradeMarker(version, securityParameters.ServerRandom);
		}
		byte[] array = (securityParameters.m_sessionID = serverHello.SessionID);
		state.client.NotifySessionID(array);
		state.resumedSession = array.Length != 0 && state.tlsSession != null && Arrays.AreEqual(array, state.tlsSession.SessionID);
		int num = DtlsProtocol.ValidateSelectedCipherSuite(serverHello.CipherSuite, 47);
		if (TlsUtilities.IsValidCipherSuiteSelection(state.offeredCipherSuites, num) && TlsUtilities.IsValidVersionForCipherSuite(num, securityParameters.NegotiatedVersion))
		{
			TlsUtilities.NegotiatedCipherSuite(securityParameters, num);
			state.client.NotifySelectedCipherSuite(num);
			if (TlsUtilities.IsTlsV13(version))
			{
				securityParameters.m_extendedMasterSecret = true;
			}
			else
			{
				bool extendedMasterSecret;
				if (extendedMasterSecret = TlsExtensionsUtilities.HasExtendedMasterSecretExtension(state.serverExtensions))
				{
					if (!state.resumedSession && !state.client.ShouldUseExtendedMasterSecret())
					{
						throw new TlsFatalAlert(40);
					}
				}
				else if (state.client.RequiresExtendedMasterSecret() || (state.resumedSession && !state.client.AllowLegacyResumption()))
				{
					throw new TlsFatalAlert(40);
				}
				securityParameters.m_extendedMasterSecret = extendedMasterSecret;
			}
			if (state.serverExtensions != null)
			{
				foreach (int key in state.serverExtensions.Keys)
				{
					if (key != 65281 && TlsUtilities.GetExtensionData(state.clientExtensions, key) == null)
					{
						throw new TlsFatalAlert(110);
					}
				}
			}
			byte[] extensionData = TlsUtilities.GetExtensionData(state.serverExtensions, 65281);
			if (extensionData != null)
			{
				securityParameters.m_secureRenegotiation = true;
				if (!Arrays.ConstantTimeAreEqual(extensionData, TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes)))
				{
					throw new TlsFatalAlert(40);
				}
			}
			state.client.NotifySecureRenegotiation(securityParameters.IsSecureRenegotiation);
			securityParameters.m_applicationProtocol = TlsExtensionsUtilities.GetAlpnExtensionServer(state.serverExtensions);
			securityParameters.m_applicationProtocolSet = true;
			HeartbeatExtension heartbeatExtension = TlsExtensionsUtilities.GetHeartbeatExtension(state.serverExtensions);
			if (heartbeatExtension == null)
			{
				state.heartbeat = null;
				state.heartbeatPolicy = 2;
			}
			else if (1 != heartbeatExtension.Mode)
			{
				state.heartbeat = null;
			}
			IDictionary dictionary = state.clientExtensions;
			IDictionary dictionary2 = state.serverExtensions;
			if (state.resumedSession)
			{
				if (securityParameters.CipherSuite != state.sessionParameters.CipherSuite || !version.Equals(state.sessionParameters.NegotiatedVersion))
				{
					throw new TlsFatalAlert(47);
				}
				dictionary = null;
				dictionary2 = state.sessionParameters.ReadServerExtensions();
			}
			if (dictionary2 != null && dictionary2.Count > 0)
			{
				bool encryptThenMac;
				if ((encryptThenMac = TlsExtensionsUtilities.HasEncryptThenMacExtension(dictionary2)) && !TlsUtilities.IsBlockCipherSuite(securityParameters.CipherSuite))
				{
					throw new TlsFatalAlert(47);
				}
				securityParameters.m_encryptThenMac = encryptThenMac;
				securityParameters.m_maxFragmentLength = DtlsProtocol.EvaluateMaxFragmentLengthExtension(state.resumedSession, dictionary, dictionary2, 47);
				securityParameters.m_truncatedHmac = TlsExtensionsUtilities.HasTruncatedHmacExtension(dictionary2);
				if (!state.resumedSession)
				{
					if (TlsUtilities.HasExpectedEmptyExtensionData(dictionary2, 17, 47))
					{
						securityParameters.m_statusRequestVersion = 2;
					}
					else if (TlsUtilities.HasExpectedEmptyExtensionData(dictionary2, 5, 47))
					{
						securityParameters.m_statusRequestVersion = 1;
					}
				}
				state.expectSessionTicket = !state.resumedSession && TlsUtilities.HasExpectedEmptyExtensionData(dictionary2, 35, 47);
			}
			if (dictionary != null)
			{
				state.client.ProcessServerExtensions(dictionary2);
			}
			return;
		}
		throw new TlsFatalAlert(47);
	}

	protected virtual void ProcessServerKeyExchange(ClientHandshakeState state, byte[] body)
	{
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		state.keyExchange.ProcessServerKeyExchange(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
	}

	protected virtual void ProcessServerSupplementalData(ClientHandshakeState state, byte[] body)
	{
		IList serverSupplementalData = TlsProtocol.ReadSupplementalDataMessage(new MemoryStream(body, writable: false));
		state.client.ProcessServerSupplementalData(serverSupplementalData);
	}

	protected virtual void ReportServerVersion(ClientHandshakeState state, ProtocolVersion server_version)
	{
		TlsClientContextImpl clientContext = state.clientContext;
		SecurityParameters securityParameters = clientContext.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		if (negotiatedVersion != null)
		{
			if (!negotiatedVersion.Equals(server_version))
			{
				throw new TlsFatalAlert(47);
			}
			return;
		}
		if (!ProtocolVersion.Contains(clientContext.ClientSupportedVersions, server_version))
		{
			throw new TlsFatalAlert(70);
		}
		securityParameters.m_negotiatedVersion = server_version;
		TlsUtilities.NegotiatedVersionDtlsClient(state.clientContext, state.client);
	}

	protected static byte[] PatchClientHelloWithCookie(byte[] clientHelloBody, byte[] cookie)
	{
		int num = TlsUtilities.ReadUint8(clientHelloBody, 34);
		int num2 = 35 + num;
		int num3 = num2 + 1;
		byte[] array = new byte[clientHelloBody.Length + cookie.Length];
		Array.Copy(clientHelloBody, 0, array, 0, num2);
		TlsUtilities.CheckUint8(cookie.Length);
		TlsUtilities.WriteUint8(cookie.Length, array, num2);
		Array.Copy(cookie, 0, array, num3, cookie.Length);
		Array.Copy(clientHelloBody, num3, array, num3 + cookie.Length, clientHelloBody.Length - num3);
		return array;
	}
}
