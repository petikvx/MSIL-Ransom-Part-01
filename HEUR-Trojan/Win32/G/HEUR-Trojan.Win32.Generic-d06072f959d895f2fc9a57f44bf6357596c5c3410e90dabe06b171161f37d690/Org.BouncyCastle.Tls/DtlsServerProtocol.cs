using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public class DtlsServerProtocol : DtlsProtocol
{
	protected internal class ServerHandshakeState
	{
		internal TlsServer server;

		internal TlsServerContextImpl serverContext;

		internal TlsSession tlsSession;

		internal SessionParameters sessionParameters;

		internal TlsSecret sessionMasterSecret;

		internal SessionParameters.Builder sessionParametersBuilder;

		internal int[] offeredCipherSuites;

		internal IDictionary clientExtensions;

		internal IDictionary serverExtensions;

		internal bool offeredExtendedMasterSecret;

		internal bool resumedSession;

		internal bool expectSessionTicket;

		internal TlsKeyExchange keyExchange;

		internal TlsCredentials serverCredentials;

		internal CertificateRequest certificateRequest;

		internal TlsHeartbeat heartbeat;

		internal short heartbeatPolicy = 2;
	}

	protected bool m_verifyRequests = true;

	public virtual bool VerifyRequests
	{
		get
		{
			return m_verifyRequests;
		}
		set
		{
			m_verifyRequests = value;
		}
	}

	public virtual DtlsTransport Accept(TlsServer server, DatagramTransport transport)
	{
		return Accept(server, transport, null);
	}

	public virtual DtlsTransport Accept(TlsServer server, DatagramTransport transport, DtlsRequest request)
	{
		if (server == null)
		{
			throw new ArgumentNullException("server");
		}
		if (transport == null)
		{
			throw new ArgumentNullException("transport");
		}
		ServerHandshakeState serverHandshakeState = new ServerHandshakeState();
		serverHandshakeState.server = server;
		serverHandshakeState.serverContext = new TlsServerContextImpl(server.Crypto);
		server.Init(serverHandshakeState.serverContext);
		serverHandshakeState.serverContext.HandshakeBeginning(server);
		SecurityParameters securityParameters = serverHandshakeState.serverContext.SecurityParameters;
		securityParameters.m_extendedPadding = server.ShouldUseExtendedPadding();
		DtlsRecordLayer dtlsRecordLayer = new DtlsRecordLayer(serverHandshakeState.serverContext, serverHandshakeState.server, transport);
		server.NotifyCloseHandle(dtlsRecordLayer);
		try
		{
			return ServerHandshake(serverHandshakeState, dtlsRecordLayer, request);
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			AbortServerHandshake(serverHandshakeState, dtlsRecordLayer, tlsFatalAlert.AlertDescription);
			throw tlsFatalAlert;
		}
		catch (IOException ex)
		{
			AbortServerHandshake(serverHandshakeState, dtlsRecordLayer, 80);
			throw ex;
		}
		catch (Exception alertCause)
		{
			AbortServerHandshake(serverHandshakeState, dtlsRecordLayer, 80);
			throw new TlsFatalAlert(80, alertCause);
		}
		finally
		{
			securityParameters.Clear();
		}
	}

	internal virtual void AbortServerHandshake(ServerHandshakeState state, DtlsRecordLayer recordLayer, short alertDescription)
	{
		recordLayer.Fail(alertDescription);
		InvalidateSession(state);
	}

	internal virtual DtlsTransport ServerHandshake(ServerHandshakeState state, DtlsRecordLayer recordLayer, DtlsRequest request)
	{
		SecurityParameters securityParameters = state.serverContext.SecurityParameters;
		DtlsReliableHandshake dtlsReliableHandshake = new DtlsReliableHandshake(state.serverContext, recordLayer, state.server.GetHandshakeTimeoutMillis(), request);
		DtlsReliableHandshake.Message message = null;
		if (request == null)
		{
			message = dtlsReliableHandshake.ReceiveMessage();
			if (message.Type != 1)
			{
				throw new TlsFatalAlert(10);
			}
			ProcessClientHello(state, message.Body);
		}
		else
		{
			ProcessClientHello(state, request.ClientHello);
		}
		state.tlsSession = TlsUtilities.ImportSession(TlsUtilities.EmptyBytes, null);
		state.sessionParameters = null;
		state.sessionMasterSecret = null;
		securityParameters.m_sessionID = state.tlsSession.SessionID;
		state.server.NotifySession(state.tlsSession);
		byte[] body = GenerateServerHello(state, recordLayer);
		ProtocolVersion writeVersion = (recordLayer.ReadVersion = state.serverContext.ServerVersion);
		recordLayer.SetWriteVersion(writeVersion);
		dtlsReliableHandshake.SendMessage(2, body);
		dtlsReliableHandshake.HandshakeHash.NotifyPrfDetermined();
		IList serverSupplementalData = state.server.GetServerSupplementalData();
		if (serverSupplementalData != null)
		{
			byte[] body2 = DtlsProtocol.GenerateSupplementalData(serverSupplementalData);
			dtlsReliableHandshake.SendMessage(23, body2);
		}
		state.keyExchange = TlsUtilities.InitKeyExchangeServer(state.serverContext, state.server);
		state.serverCredentials = TlsUtilities.EstablishServerCredentials(state.server);
		Certificate certificate = null;
		MemoryStream memoryStream = new MemoryStream();
		if (state.serverCredentials == null)
		{
			state.keyExchange.SkipServerCredentials();
		}
		else
		{
			state.keyExchange.ProcessServerCredentials(state.serverCredentials);
			certificate = state.serverCredentials.Certificate;
			DtlsProtocol.SendCertificateMessage(state.serverContext, dtlsReliableHandshake, certificate, memoryStream);
		}
		securityParameters.m_tlsServerEndPoint = memoryStream.ToArray();
		if (certificate == null || certificate.IsEmpty)
		{
			securityParameters.m_statusRequestVersion = 0;
		}
		if (securityParameters.StatusRequestVersion > 0)
		{
			CertificateStatus certificateStatus = state.server.GetCertificateStatus();
			if (certificateStatus != null)
			{
				byte[] body3 = GenerateCertificateStatus(state, certificateStatus);
				dtlsReliableHandshake.SendMessage(22, body3);
			}
		}
		byte[] array = state.keyExchange.GenerateServerKeyExchange();
		if (array != null)
		{
			dtlsReliableHandshake.SendMessage(12, array);
		}
		if (state.serverCredentials != null)
		{
			state.certificateRequest = state.server.GetCertificateRequest();
			if (state.certificateRequest == null)
			{
				if (!state.keyExchange.RequiresCertificateVerify)
				{
					throw new TlsFatalAlert(80);
				}
			}
			else
			{
				if (TlsUtilities.IsTlsV12(state.serverContext) != (state.certificateRequest.SupportedSignatureAlgorithms != null))
				{
					throw new TlsFatalAlert(80);
				}
				state.certificateRequest = TlsUtilities.ValidateCertificateRequest(state.certificateRequest, state.keyExchange);
				TlsUtilities.EstablishServerSigAlgs(securityParameters, state.certificateRequest);
				TlsUtilities.TrackHashAlgorithms(dtlsReliableHandshake.HandshakeHash, securityParameters.ServerSigAlgs);
				byte[] body4 = GenerateCertificateRequest(state, state.certificateRequest);
				dtlsReliableHandshake.SendMessage(13, body4);
			}
		}
		dtlsReliableHandshake.SendMessage(14, TlsUtilities.EmptyBytes);
		TlsUtilities.SealHandshakeHash(state.serverContext, dtlsReliableHandshake.HandshakeHash, forceBuffering: false);
		message = dtlsReliableHandshake.ReceiveMessage();
		if (message.Type == 23)
		{
			ProcessClientSupplementalData(state, message.Body);
			message = dtlsReliableHandshake.ReceiveMessage();
		}
		else
		{
			state.server.ProcessClientSupplementalData(null);
		}
		if (state.certificateRequest == null)
		{
			state.keyExchange.SkipClientCredentials();
		}
		else if (message.Type == 11)
		{
			ProcessClientCertificate(state, message.Body);
			message = dtlsReliableHandshake.ReceiveMessage();
		}
		else
		{
			if (TlsUtilities.IsTlsV12(state.serverContext))
			{
				throw new TlsFatalAlert(10);
			}
			NotifyClientCertificate(state, Certificate.EmptyChain);
		}
		if (message.Type == 16)
		{
			ProcessClientKeyExchange(state, message.Body);
			securityParameters.m_sessionHash = TlsUtilities.GetCurrentPrfHash(dtlsReliableHandshake.HandshakeHash);
			TlsProtocol.EstablishMasterSecret(state.serverContext, state.keyExchange);
			recordLayer.InitPendingEpoch(TlsUtilities.InitCipher(state.serverContext));
			TlsHandshakeHash handshakeHash = dtlsReliableHandshake.PrepareToFinish();
			if (ExpectCertificateVerifyMessage(state))
			{
				byte[] body5 = dtlsReliableHandshake.ReceiveMessageBody(15);
				ProcessCertificateVerify(state, body5, handshakeHash);
			}
			securityParameters.m_peerVerifyData = TlsUtilities.CalculateVerifyData(state.serverContext, dtlsReliableHandshake.HandshakeHash, isServer: false);
			ProcessFinished(dtlsReliableHandshake.ReceiveMessageBody(20), securityParameters.PeerVerifyData);
			if (state.expectSessionTicket)
			{
				NewSessionTicket newSessionTicket = state.server.GetNewSessionTicket();
				byte[] body6 = GenerateNewSessionTicket(state, newSessionTicket);
				dtlsReliableHandshake.SendMessage(4, body6);
			}
			securityParameters.m_localVerifyData = TlsUtilities.CalculateVerifyData(state.serverContext, dtlsReliableHandshake.HandshakeHash, isServer: true);
			dtlsReliableHandshake.SendMessage(20, securityParameters.LocalVerifyData);
			dtlsReliableHandshake.Finish();
			state.sessionMasterSecret = securityParameters.MasterSecret;
			state.sessionParameters = new SessionParameters.Builder().SetCipherSuite(securityParameters.CipherSuite).SetExtendedMasterSecret(securityParameters.IsExtendedMasterSecret).SetLocalCertificate(securityParameters.LocalCertificate)
				.SetMasterSecret(state.serverContext.Crypto.AdoptSecret(state.sessionMasterSecret))
				.SetNegotiatedVersion(securityParameters.NegotiatedVersion)
				.SetPeerCertificate(securityParameters.PeerCertificate)
				.SetPskIdentity(securityParameters.PskIdentity)
				.SetSrpIdentity(securityParameters.SrpIdentity)
				.SetServerExtensions(state.serverExtensions)
				.Build();
			state.tlsSession = TlsUtilities.ImportSession(state.tlsSession.SessionID, state.sessionParameters);
			securityParameters.m_tlsUnique = securityParameters.PeerVerifyData;
			state.serverContext.HandshakeComplete(state.server, state.tlsSession);
			recordLayer.InitHeartbeat(state.heartbeat, 1 == state.heartbeatPolicy);
			return new DtlsTransport(recordLayer);
		}
		throw new TlsFatalAlert(10);
	}

	protected virtual byte[] GenerateCertificateRequest(ServerHandshakeState state, CertificateRequest certificateRequest)
	{
		MemoryStream memoryStream = new MemoryStream();
		certificateRequest.Encode(state.serverContext, memoryStream);
		return memoryStream.ToArray();
	}

	protected virtual byte[] GenerateCertificateStatus(ServerHandshakeState state, CertificateStatus certificateStatus)
	{
		MemoryStream memoryStream = new MemoryStream();
		certificateStatus.Encode(memoryStream);
		return memoryStream.ToArray();
	}

	protected virtual byte[] GenerateNewSessionTicket(ServerHandshakeState state, NewSessionTicket newSessionTicket)
	{
		MemoryStream memoryStream = new MemoryStream();
		newSessionTicket.Encode(memoryStream);
		return memoryStream.ToArray();
	}

	internal virtual byte[] GenerateServerHello(ServerHandshakeState state, DtlsRecordLayer recordLayer)
	{
		TlsServerContextImpl serverContext = state.serverContext;
		SecurityParameters securityParameters = serverContext.SecurityParameters;
		ProtocolVersion serverVersion = state.server.GetServerVersion();
		if (!ProtocolVersion.Contains(serverContext.ClientSupportedVersions, serverVersion))
		{
			throw new TlsFatalAlert(80);
		}
		securityParameters.m_negotiatedVersion = serverVersion;
		TlsUtilities.NegotiatedVersionDtlsServer(serverContext);
		bool useGmtUnixTime = ProtocolVersion.DTLSv12.IsEqualOrLaterVersionOf(serverVersion) && state.server.ShouldUseGmtUnixTime();
		securityParameters.m_serverRandom = TlsProtocol.CreateRandomBlock(useGmtUnixTime, serverContext);
		if (!serverVersion.Equals(ProtocolVersion.GetLatestDtls(state.server.GetProtocolVersions())))
		{
			TlsUtilities.WriteDowngradeMarker(serverVersion, securityParameters.ServerRandom);
		}
		int cipherSuite = DtlsProtocol.ValidateSelectedCipherSuite(state.server.GetSelectedCipherSuite(), 80);
		if (TlsUtilities.IsValidCipherSuiteSelection(state.offeredCipherSuites, cipherSuite) && TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, securityParameters.NegotiatedVersion))
		{
			TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
			state.serverExtensions = TlsExtensionsUtilities.EnsureExtensionsInitialised(state.server.GetServerExtensions());
			state.server.GetServerExtensionsForConnection(state.serverExtensions);
			ProtocolVersion version = serverVersion;
			if (serverVersion.IsLaterVersionOf(ProtocolVersion.DTLSv12))
			{
				version = ProtocolVersion.DTLSv12;
				TlsExtensionsUtilities.AddSupportedVersionsExtensionServer(state.serverExtensions, serverVersion);
			}
			if (securityParameters.IsSecureRenegotiation)
			{
				byte[] extensionData = TlsUtilities.GetExtensionData(state.serverExtensions, 65281);
				if (extensionData == null)
				{
					state.serverExtensions[65281] = TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes);
				}
			}
			if (TlsUtilities.IsTlsV13(serverVersion))
			{
				securityParameters.m_extendedMasterSecret = true;
			}
			else
			{
				securityParameters.m_extendedMasterSecret = state.offeredExtendedMasterSecret && state.server.ShouldUseExtendedMasterSecret();
				if (securityParameters.IsExtendedMasterSecret)
				{
					TlsExtensionsUtilities.AddExtendedMasterSecretExtension(state.serverExtensions);
				}
				else
				{
					if (state.server.RequiresExtendedMasterSecret())
					{
						throw new TlsFatalAlert(40);
					}
					if (state.resumedSession && !state.server.AllowLegacyResumption())
					{
						throw new TlsFatalAlert(80);
					}
				}
			}
			if (state.heartbeat != null || 1 == state.heartbeatPolicy)
			{
				TlsExtensionsUtilities.AddHeartbeatExtension(state.serverExtensions, new HeartbeatExtension(state.heartbeatPolicy));
			}
			securityParameters.m_applicationProtocol = TlsExtensionsUtilities.GetAlpnExtensionServer(state.serverExtensions);
			securityParameters.m_applicationProtocolSet = true;
			if (state.serverExtensions.Count > 0)
			{
				securityParameters.m_encryptThenMac = TlsExtensionsUtilities.HasEncryptThenMacExtension(state.serverExtensions);
				securityParameters.m_maxFragmentLength = DtlsProtocol.EvaluateMaxFragmentLengthExtension(state.resumedSession, state.clientExtensions, state.serverExtensions, 80);
				securityParameters.m_truncatedHmac = TlsExtensionsUtilities.HasTruncatedHmacExtension(state.serverExtensions);
				if (!state.resumedSession)
				{
					if (TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 17, 80))
					{
						securityParameters.m_statusRequestVersion = 2;
					}
					else if (TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 5, 80))
					{
						securityParameters.m_statusRequestVersion = 1;
					}
				}
				state.expectSessionTicket = !state.resumedSession && TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 35, 80);
			}
			DtlsProtocol.ApplyMaxFragmentLengthExtension(recordLayer, securityParameters.MaxFragmentLength);
			ServerHello serverHello = new ServerHello(version, securityParameters.ServerRandom, state.tlsSession.SessionID, securityParameters.CipherSuite, state.serverExtensions);
			MemoryStream memoryStream = new MemoryStream();
			serverHello.Encode(state.serverContext, memoryStream);
			return memoryStream.ToArray();
		}
		throw new TlsFatalAlert(80);
	}

	protected virtual void InvalidateSession(ServerHandshakeState state)
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

	protected virtual void NotifyClientCertificate(ServerHandshakeState state, Certificate clientCertificate)
	{
		if (state.certificateRequest == null)
		{
			throw new TlsFatalAlert(80);
		}
		TlsUtilities.ProcessClientCertificate(state.serverContext, clientCertificate, state.keyExchange, state.server);
	}

	protected virtual void ProcessClientCertificate(ServerHandshakeState state, byte[] body)
	{
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		Certificate clientCertificate = Certificate.Parse(new Certificate.ParseOptions().SetMaxChainLength(state.server.GetMaxCertificateChainLength()), state.serverContext, memoryStream, null);
		TlsProtocol.AssertEmpty(memoryStream);
		NotifyClientCertificate(state, clientCertificate);
	}

	protected virtual void ProcessCertificateVerify(ServerHandshakeState state, byte[] body, TlsHandshakeHash handshakeHash)
	{
		if (state.certificateRequest == null)
		{
			throw new InvalidOperationException();
		}
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		TlsServerContextImpl serverContext = state.serverContext;
		DigitallySigned certificateVerify = DigitallySigned.Parse(serverContext, memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		TlsUtilities.VerifyCertificateVerifyClient(serverContext, state.certificateRequest, certificateVerify, handshakeHash);
	}

	protected virtual void ProcessClientHello(ServerHandshakeState state, byte[] body)
	{
		ClientHello clientHello = ClientHello.Parse(new MemoryStream(body, writable: false), new NullOutputStream());
		ProcessClientHello(state, clientHello);
	}

	protected virtual void ProcessClientHello(ServerHandshakeState state, ClientHello clientHello)
	{
		ProtocolVersion version = clientHello.Version;
		state.offeredCipherSuites = clientHello.CipherSuites;
		state.clientExtensions = clientHello.Extensions;
		TlsServerContextImpl serverContext = state.serverContext;
		SecurityParameters securityParameters = serverContext.SecurityParameters;
		if (!version.IsDtls)
		{
			throw new TlsFatalAlert(47);
		}
		serverContext.SetRsaPreMasterSecretVersion(version);
		serverContext.SetClientSupportedVersions(TlsExtensionsUtilities.GetSupportedVersionsExtensionClient(state.clientExtensions));
		ProtocolVersion protocolVersion = version;
		if (serverContext.ClientSupportedVersions == null)
		{
			if (protocolVersion.IsLaterVersionOf(ProtocolVersion.DTLSv12))
			{
				protocolVersion = ProtocolVersion.DTLSv12;
			}
			serverContext.SetClientSupportedVersions(protocolVersion.DownTo(ProtocolVersion.DTLSv10));
		}
		else
		{
			protocolVersion = ProtocolVersion.GetLatestDtls(serverContext.ClientSupportedVersions);
		}
		if (!ProtocolVersion.SERVER_EARLIEST_SUPPORTED_DTLS.IsEqualOrEarlierVersionOf(protocolVersion))
		{
			throw new TlsFatalAlert(70);
		}
		serverContext.SetClientVersion(protocolVersion);
		state.server.NotifyClientVersion(serverContext.ClientVersion);
		securityParameters.m_clientRandom = clientHello.Random;
		state.server.NotifyFallback(Arrays.Contains(state.offeredCipherSuites, 22016));
		state.server.NotifyOfferedCipherSuites(state.offeredCipherSuites);
		if (Arrays.Contains(state.offeredCipherSuites, 255))
		{
			securityParameters.m_secureRenegotiation = true;
		}
		byte[] extensionData = TlsUtilities.GetExtensionData(state.clientExtensions, 65281);
		if (extensionData != null)
		{
			securityParameters.m_secureRenegotiation = true;
			if (!Arrays.ConstantTimeAreEqual(extensionData, TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes)))
			{
				throw new TlsFatalAlert(40);
			}
		}
		state.server.NotifySecureRenegotiation(securityParameters.IsSecureRenegotiation);
		state.offeredExtendedMasterSecret = TlsExtensionsUtilities.HasExtendedMasterSecretExtension(state.clientExtensions);
		if (state.clientExtensions == null)
		{
			return;
		}
		TlsExtensionsUtilities.GetPaddingExtension(state.clientExtensions);
		securityParameters.m_clientServerNames = TlsExtensionsUtilities.GetServerNameExtensionClient(state.clientExtensions);
		if (TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(protocolVersion))
		{
			TlsUtilities.EstablishClientSigAlgs(securityParameters, state.clientExtensions);
		}
		securityParameters.m_clientSupportedGroups = TlsExtensionsUtilities.GetSupportedGroupsExtension(state.clientExtensions);
		HeartbeatExtension heartbeatExtension = TlsExtensionsUtilities.GetHeartbeatExtension(state.clientExtensions);
		if (heartbeatExtension != null)
		{
			if (1 == heartbeatExtension.Mode)
			{
				state.heartbeat = state.server.GetHeartbeat();
			}
			state.heartbeatPolicy = state.server.GetHeartbeatPolicy();
		}
		state.server.ProcessClientExtensions(state.clientExtensions);
	}

	protected virtual void ProcessClientKeyExchange(ServerHandshakeState state, byte[] body)
	{
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		state.keyExchange.ProcessClientKeyExchange(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
	}

	protected virtual void ProcessClientSupplementalData(ServerHandshakeState state, byte[] body)
	{
		IList clientSupplementalData = TlsProtocol.ReadSupplementalDataMessage(new MemoryStream(body, writable: false));
		state.server.ProcessClientSupplementalData(clientSupplementalData);
	}

	protected virtual bool ExpectCertificateVerifyMessage(ServerHandshakeState state)
	{
		if (state.certificateRequest == null)
		{
			return false;
		}
		Certificate peerCertificate = state.serverContext.SecurityParameters.PeerCertificate;
		if (peerCertificate != null && !peerCertificate.IsEmpty)
		{
			if (state.keyExchange != null)
			{
				return state.keyExchange.RequiresCertificateVerify;
			}
			return true;
		}
		return false;
	}
}
