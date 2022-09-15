using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class TlsServerProtocol : TlsProtocol
{
	protected TlsServer m_tlsServer;

	internal TlsServerContextImpl m_tlsServerContext;

	protected int[] m_offeredCipherSuites;

	protected TlsKeyExchange m_keyExchange;

	protected CertificateRequest m_certificateRequest;

	protected override TlsContext Context => m_tlsServerContext;

	internal override AbstractTlsContext ContextAdmin => m_tlsServerContext;

	protected override TlsPeer Peer => m_tlsServer;

	public TlsServerProtocol()
	{
	}

	public TlsServerProtocol(Stream stream)
		: base(stream)
	{
	}

	public TlsServerProtocol(Stream input, Stream output)
		: base(input, output)
	{
	}

	public void Accept(TlsServer tlsServer)
	{
		if (tlsServer == null)
		{
			throw new ArgumentNullException("tlsServer");
		}
		if (m_tlsServer != null)
		{
			throw new InvalidOperationException("'Accept' can only be called once");
		}
		m_tlsServer = tlsServer;
		m_tlsServerContext = new TlsServerContextImpl(tlsServer.Crypto);
		tlsServer.Init(m_tlsServerContext);
		tlsServer.NotifyCloseHandle(this);
		BeginHandshake();
		if (m_blocking)
		{
			BlockForHandshake();
		}
	}

	protected override void CleanupHandshake()
	{
		base.CleanupHandshake();
		m_offeredCipherSuites = null;
		m_keyExchange = null;
		m_certificateRequest = null;
	}

	protected virtual bool ExpectCertificateVerifyMessage()
	{
		if (m_certificateRequest == null)
		{
			return false;
		}
		Certificate peerCertificate = m_tlsServerContext.SecurityParameters.PeerCertificate;
		if (peerCertificate != null && !peerCertificate.IsEmpty)
		{
			if (m_keyExchange != null)
			{
				return m_keyExchange.RequiresCertificateVerify;
			}
			return true;
		}
		return false;
	}

	protected virtual ServerHello Generate13HelloRetryRequest(ClientHello clientHello)
	{
		if (m_retryGroup < 0)
		{
			throw new TlsFatalAlert(80);
		}
		SecurityParameters securityParameters = m_tlsServerContext.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		IDictionary extensions = Platform.CreateHashtable();
		TlsExtensionsUtilities.AddSupportedVersionsExtensionServer(extensions, negotiatedVersion);
		if (m_retryGroup >= 0)
		{
			TlsExtensionsUtilities.AddKeyShareHelloRetryRequest(extensions, m_retryGroup);
		}
		if (m_retryCookie != null)
		{
			TlsExtensionsUtilities.AddCookieExtension(extensions, m_retryCookie);
		}
		TlsUtilities.CheckExtensionData13(extensions, 6, 80);
		return new ServerHello(clientHello.SessionID, securityParameters.CipherSuite, extensions);
	}

	protected virtual ServerHello Generate13ServerHello(ClientHello clientHello, bool afterHelloRetryRequest)
	{
		SecurityParameters securityParameters = m_tlsServerContext.SecurityParameters;
		byte[] sessionID = clientHello.SessionID;
		IDictionary extensions = clientHello.Extensions;
		if (extensions == null)
		{
			throw new TlsFatalAlert(109);
		}
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		TlsCrypto crypto = m_tlsServerContext.Crypto;
		IList keyShareClientHello = TlsExtensionsUtilities.GetKeyShareClientHello(extensions);
		KeyShareEntry keyShareEntry = null;
		if (afterHelloRetryRequest)
		{
			if (m_retryGroup < 0)
			{
				throw new TlsFatalAlert(80);
			}
			byte[] cookieExtension = TlsExtensionsUtilities.GetCookieExtension(extensions);
			if (!Arrays.AreEqual(m_retryCookie, cookieExtension))
			{
				throw new TlsFatalAlert(47);
			}
			m_retryCookie = null;
			keyShareEntry = TlsUtilities.SelectKeyShare(keyShareClientHello, m_retryGroup);
			if (keyShareEntry == null)
			{
				throw new TlsFatalAlert(47);
			}
		}
		else
		{
			m_clientExtensions = extensions;
			securityParameters.m_secureRenegotiation = false;
			TlsExtensionsUtilities.GetPaddingExtension(extensions);
			securityParameters.m_clientServerNames = TlsExtensionsUtilities.GetServerNameExtensionClient(extensions);
			TlsUtilities.EstablishClientSigAlgs(securityParameters, extensions);
			if (securityParameters.ClientSigAlgs == null)
			{
				throw new TlsFatalAlert(109);
			}
			m_tlsServer.ProcessClientExtensions(extensions);
			m_tlsSession = TlsUtilities.ImportSession(TlsUtilities.EmptyBytes, null);
			m_sessionParameters = null;
			m_sessionMasterSecret = null;
			securityParameters.m_sessionID = m_tlsSession.SessionID;
			m_tlsServer.NotifySession(m_tlsSession);
			TlsUtilities.NegotiatedVersionTlsServer(m_tlsServerContext);
			securityParameters.m_serverRandom = TlsProtocol.CreateRandomBlock(useGmtUnixTime: false, m_tlsServerContext);
			if (!negotiatedVersion.Equals(ProtocolVersion.GetLatestTls(m_tlsServer.GetProtocolVersions())))
			{
				TlsUtilities.WriteDowngradeMarker(negotiatedVersion, securityParameters.ServerRandom);
			}
			int selectedCipherSuite = m_tlsServer.GetSelectedCipherSuite();
			if (!TlsUtilities.IsValidCipherSuiteSelection(m_offeredCipherSuites, selectedCipherSuite) || !TlsUtilities.IsValidVersionForCipherSuite(selectedCipherSuite, negotiatedVersion))
			{
				throw new TlsFatalAlert(80);
			}
			TlsUtilities.NegotiatedCipherSuite(securityParameters, selectedCipherSuite);
			int[] clientSupportedGroups = securityParameters.ClientSupportedGroups;
			int[] serverSupportedGroups = securityParameters.ServerSupportedGroups;
			keyShareEntry = TlsUtilities.SelectKeyShare(crypto, negotiatedVersion, keyShareClientHello, clientSupportedGroups, serverSupportedGroups);
			if (keyShareEntry == null)
			{
				m_retryGroup = TlsUtilities.SelectKeyShareGroup(crypto, negotiatedVersion, clientSupportedGroups, serverSupportedGroups);
				if (m_retryGroup < 0)
				{
					throw new TlsFatalAlert(40);
				}
				m_retryCookie = m_tlsServerContext.NonceGenerator.GenerateNonce(16);
				return Generate13HelloRetryRequest(clientHello);
			}
			_ = keyShareEntry.NamedGroup;
		}
		IDictionary extensions2 = Platform.CreateHashtable();
		IDictionary dictionary = TlsExtensionsUtilities.EnsureExtensionsInitialised(m_tlsServer.GetServerExtensions());
		m_tlsServer.GetServerExtensionsForConnection(dictionary);
		ProtocolVersion tLSv = ProtocolVersion.TLSv12;
		TlsExtensionsUtilities.AddSupportedVersionsExtensionServer(extensions2, negotiatedVersion);
		securityParameters.m_extendedMasterSecret = true;
		securityParameters.m_applicationProtocol = TlsExtensionsUtilities.GetAlpnExtensionServer(dictionary);
		securityParameters.m_applicationProtocolSet = true;
		if (dictionary.Count > 0)
		{
			securityParameters.m_maxFragmentLength = ProcessMaxFragmentLengthExtension(extensions, dictionary, 80);
		}
		securityParameters.m_encryptThenMac = false;
		securityParameters.m_truncatedHmac = false;
		securityParameters.m_statusRequestVersion = (extensions.Contains(5) ? 1 : 0);
		m_expectSessionTicket = false;
		TlsSecret pskEarlySecret = null;
		TlsSecret tlsSecret = null;
		int namedGroup = keyShareEntry.NamedGroup;
		TlsAgreement tlsAgreement;
		if (NamedGroup.RefersToASpecificCurve(namedGroup))
		{
			tlsAgreement = crypto.CreateECDomain(new TlsECConfig(namedGroup)).CreateECDH();
		}
		else
		{
			if (!NamedGroup.RefersToASpecificFiniteField(namedGroup))
			{
				throw new TlsFatalAlert(80);
			}
			tlsAgreement = crypto.CreateDHDomain(new TlsDHConfig(namedGroup, padded: true)).CreateDH();
		}
		byte[] keyExchange = tlsAgreement.GenerateEphemeral();
		KeyShareEntry serverShare = new KeyShareEntry(namedGroup, keyExchange);
		TlsExtensionsUtilities.AddKeyShareServerHello(extensions2, serverShare);
		tlsAgreement.ReceivePeerValue(keyShareEntry.KeyExchange);
		TlsUtilities.Establish13PhaseSecrets(sharedSecret: tlsAgreement.CalculateSecret(), context: m_tlsServerContext, pskEarlySecret: pskEarlySecret);
		m_serverExtensions = dictionary;
		ApplyMaxFragmentLengthExtension(securityParameters.MaxFragmentLength);
		TlsUtilities.CheckExtensionData13(extensions2, 2, 80);
		return new ServerHello(tLSv, securityParameters.ServerRandom, sessionID, securityParameters.CipherSuite, extensions2);
	}

	protected virtual ServerHello GenerateServerHello(ClientHello clientHello)
	{
		ProtocolVersion version = clientHello.Version;
		if (!version.IsTls)
		{
			throw new TlsFatalAlert(47);
		}
		m_offeredCipherSuites = clientHello.CipherSuites;
		SecurityParameters securityParameters = m_tlsServerContext.SecurityParameters;
		m_tlsServerContext.SetClientSupportedVersions(TlsExtensionsUtilities.GetSupportedVersionsExtensionClient(clientHello.Extensions));
		ProtocolVersion protocolVersion = version;
		if (m_tlsServerContext.ClientSupportedVersions == null)
		{
			if (protocolVersion.IsLaterVersionOf(ProtocolVersion.TLSv12))
			{
				protocolVersion = ProtocolVersion.TLSv12;
			}
			m_tlsServerContext.SetClientSupportedVersions(protocolVersion.DownTo(ProtocolVersion.SSLv3));
		}
		else
		{
			protocolVersion = ProtocolVersion.GetLatestTls(m_tlsServerContext.ClientSupportedVersions);
		}
		m_recordStream.SetWriteVersion(protocolVersion);
		if (!ProtocolVersion.SERVER_EARLIEST_SUPPORTED_TLS.IsEqualOrEarlierVersionOf(protocolVersion))
		{
			throw new TlsFatalAlert(70);
		}
		m_tlsServerContext.SetClientVersion(protocolVersion);
		m_tlsServer.NotifyClientVersion(m_tlsServerContext.ClientVersion);
		securityParameters.m_clientRandom = clientHello.Random;
		m_tlsServer.NotifyFallback(Arrays.Contains(m_offeredCipherSuites, 22016));
		m_tlsServer.NotifyOfferedCipherSuites(m_offeredCipherSuites);
		ProtocolVersion serverVersion = m_tlsServer.GetServerVersion();
		if (!ProtocolVersion.Contains(m_tlsServerContext.ClientSupportedVersions, serverVersion))
		{
			throw new TlsFatalAlert(80);
		}
		securityParameters.m_negotiatedVersion = serverVersion;
		securityParameters.m_clientSupportedGroups = TlsExtensionsUtilities.GetSupportedGroupsExtension(clientHello.Extensions);
		securityParameters.m_serverSupportedGroups = m_tlsServer.GetSupportedGroups();
		if (ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(serverVersion))
		{
			m_recordStream.SetIgnoreChangeCipherSpec(ignoreChangeCipherSpec: true);
			m_recordStream.SetWriteVersion(ProtocolVersion.TLSv12);
			return Generate13ServerHello(clientHello, afterHelloRetryRequest: false);
		}
		m_recordStream.SetWriteVersion(serverVersion);
		m_clientExtensions = clientHello.Extensions;
		byte[] extensionData = TlsUtilities.GetExtensionData(m_clientExtensions, 65281);
		if (Arrays.Contains(m_offeredCipherSuites, 255))
		{
			securityParameters.m_secureRenegotiation = true;
		}
		if (extensionData != null)
		{
			securityParameters.m_secureRenegotiation = true;
			if (!Arrays.ConstantTimeAreEqual(extensionData, TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes)))
			{
				throw new TlsFatalAlert(40);
			}
		}
		m_tlsServer.NotifySecureRenegotiation(securityParameters.IsSecureRenegotiation);
		bool flag = TlsExtensionsUtilities.HasExtendedMasterSecretExtension(m_clientExtensions);
		if (m_clientExtensions != null)
		{
			TlsExtensionsUtilities.GetPaddingExtension(m_clientExtensions);
			securityParameters.m_clientServerNames = TlsExtensionsUtilities.GetServerNameExtensionClient(m_clientExtensions);
			if (TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(protocolVersion))
			{
				TlsUtilities.EstablishClientSigAlgs(securityParameters, m_clientExtensions);
			}
			securityParameters.m_clientSupportedGroups = TlsExtensionsUtilities.GetSupportedGroupsExtension(m_clientExtensions);
			m_tlsServer.ProcessClientExtensions(m_clientExtensions);
		}
		m_resumedSession = EstablishSession(m_tlsServer.GetSessionToResume(clientHello.SessionID));
		if (!m_resumedSession)
		{
			byte[] array = m_tlsServer.GetNewSessionID();
			if (array == null)
			{
				array = TlsUtilities.EmptyBytes;
			}
			m_tlsSession = TlsUtilities.ImportSession(array, null);
			m_sessionParameters = null;
			m_sessionMasterSecret = null;
		}
		securityParameters.m_sessionID = m_tlsSession.SessionID;
		m_tlsServer.NotifySession(m_tlsSession);
		TlsUtilities.NegotiatedVersionTlsServer(m_tlsServerContext);
		bool useGmtUnixTime = m_tlsServer.ShouldUseGmtUnixTime();
		securityParameters.m_serverRandom = TlsProtocol.CreateRandomBlock(useGmtUnixTime, m_tlsServerContext);
		if (!serverVersion.Equals(ProtocolVersion.GetLatestTls(m_tlsServer.GetProtocolVersions())))
		{
			TlsUtilities.WriteDowngradeMarker(serverVersion, securityParameters.ServerRandom);
		}
		int cipherSuite = (m_resumedSession ? m_sessionParameters.CipherSuite : m_tlsServer.GetSelectedCipherSuite());
		if (TlsUtilities.IsValidCipherSuiteSelection(m_offeredCipherSuites, cipherSuite) && TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, serverVersion))
		{
			TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
			m_tlsServerContext.SetRsaPreMasterSecretVersion(version);
			IDictionary extensions = (m_resumedSession ? m_sessionParameters.ReadServerExtensions() : m_tlsServer.GetServerExtensions());
			m_serverExtensions = TlsExtensionsUtilities.EnsureExtensionsInitialised(extensions);
			m_tlsServer.GetServerExtensionsForConnection(m_serverExtensions);
			if (securityParameters.IsSecureRenegotiation)
			{
				byte[] extensionData2 = TlsUtilities.GetExtensionData(m_serverExtensions, 65281);
				if (extensionData2 == null)
				{
					m_serverExtensions[65281] = TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes);
				}
			}
			if (m_resumedSession)
			{
				if (!m_sessionParameters.IsExtendedMasterSecret)
				{
					throw new TlsFatalAlert(80);
				}
				if (!flag)
				{
					throw new TlsFatalAlert(40);
				}
				securityParameters.m_extendedMasterSecret = true;
				TlsExtensionsUtilities.AddExtendedMasterSecretExtension(m_serverExtensions);
			}
			else
			{
				securityParameters.m_extendedMasterSecret = flag && !serverVersion.IsSsl && m_tlsServer.ShouldUseExtendedMasterSecret();
				if (securityParameters.IsExtendedMasterSecret)
				{
					TlsExtensionsUtilities.AddExtendedMasterSecretExtension(m_serverExtensions);
				}
				else if (m_tlsServer.RequiresExtendedMasterSecret())
				{
					throw new TlsFatalAlert(40);
				}
			}
			securityParameters.m_applicationProtocol = TlsExtensionsUtilities.GetAlpnExtensionServer(m_serverExtensions);
			securityParameters.m_applicationProtocolSet = true;
			if (m_serverExtensions.Count > 0)
			{
				securityParameters.m_encryptThenMac = TlsExtensionsUtilities.HasEncryptThenMacExtension(m_serverExtensions);
				securityParameters.m_maxFragmentLength = ProcessMaxFragmentLengthExtension(m_clientExtensions, m_serverExtensions, 80);
				securityParameters.m_truncatedHmac = TlsExtensionsUtilities.HasTruncatedHmacExtension(m_serverExtensions);
				if (!m_resumedSession)
				{
					if (TlsUtilities.HasExpectedEmptyExtensionData(m_serverExtensions, 17, 80))
					{
						securityParameters.m_statusRequestVersion = 2;
					}
					else if (TlsUtilities.HasExpectedEmptyExtensionData(m_serverExtensions, 5, 80))
					{
						securityParameters.m_statusRequestVersion = 1;
					}
					m_expectSessionTicket = TlsUtilities.HasExpectedEmptyExtensionData(m_serverExtensions, 35, 80);
				}
			}
			ApplyMaxFragmentLengthExtension(securityParameters.MaxFragmentLength);
			return new ServerHello(serverVersion, securityParameters.ServerRandom, m_tlsSession.SessionID, securityParameters.CipherSuite, m_serverExtensions);
		}
		throw new TlsFatalAlert(80);
	}

	protected virtual void Handle13HandshakeMessage(short type, HandshakeMessageInput buf)
	{
		if (!IsTlsV13ConnectionState())
		{
			throw new TlsFatalAlert(80);
		}
		if (m_resumedSession)
		{
			throw new TlsFatalAlert(80);
		}
		switch (type)
		{
		case 1:
			switch (m_connectionState)
			{
			default:
				throw new TlsFatalAlert(10);
			case 2:
			{
				ClientHello clientHello = ReceiveClientHelloMessage(buf);
				buf.UpdateHash(m_handshakeHash);
				m_connectionState = 3;
				ServerHello serverHello = Generate13ServerHello(clientHello, afterHelloRetryRequest: true);
				SendServerHelloMessage(serverHello);
				m_connectionState = 4;
				Send13ServerHelloCoda(serverHello, afterHelloRetryRequest: true);
				break;
			}
			case 0:
				throw new TlsFatalAlert(80);
			}
			break;
		case 11:
			if (m_connectionState == 20)
			{
				Receive13ClientCertificate(buf);
				m_connectionState = 15;
				break;
			}
			throw new TlsFatalAlert(10);
		case 15:
			if (m_connectionState == 15)
			{
				Receive13ClientCertificateVerify(buf);
				buf.UpdateHash(m_handshakeHash);
				m_connectionState = 17;
				break;
			}
			throw new TlsFatalAlert(10);
		case 20:
		{
			short connectionState = m_connectionState;
			if (connectionState != 15 && connectionState != 17 && connectionState != 20)
			{
				throw new TlsFatalAlert(10);
			}
			if (m_connectionState == 20)
			{
				Skip13ClientCertificate();
			}
			if (m_connectionState != 17)
			{
				Skip13ClientCertificateVerify();
			}
			Receive13ClientFinished(buf);
			m_connectionState = 18;
			m_recordStream.SetIgnoreChangeCipherSpec(ignoreChangeCipherSpec: false);
			m_recordStream.EnablePendingCipherRead(deferred: false);
			CompleteHandshake();
			break;
		}
		default:
			throw new TlsFatalAlert(10);
		case 24:
			Receive13KeyUpdate(buf);
			break;
		}
	}

	protected override void HandleHandshakeMessage(short type, HandshakeMessageInput buf)
	{
		SecurityParameters securityParameters = m_tlsServerContext.SecurityParameters;
		if (m_connectionState > 1 && TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
		{
			Handle13HandshakeMessage(type, buf);
			return;
		}
		if (!IsLegacyConnectionState())
		{
			throw new TlsFatalAlert(80);
		}
		if (m_resumedSession)
		{
			if (type == 20 && m_connectionState == 20)
			{
				ProcessFinishedMessage(buf);
				m_connectionState = 18;
				CompleteHandshake();
				return;
			}
			throw new TlsFatalAlert(10);
		}
		switch (type)
		{
		case 1:
			if (base.IsApplicationDataReady)
			{
				RefuseRenegotiation();
				break;
			}
			switch (m_connectionState)
			{
			case 21:
				throw new TlsFatalAlert(80);
			default:
				throw new TlsFatalAlert(10);
			case 0:
			{
				ClientHello clientHello = ReceiveClientHelloMessage(buf);
				buf.UpdateHash(m_handshakeHash);
				m_connectionState = 1;
				ServerHello serverHello = GenerateServerHello(clientHello);
				m_handshakeHash.NotifyPrfDetermined();
				if (TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
				{
					m_handshakeHash.SealHashAlgorithms();
					if (serverHello.IsHelloRetryRequest())
					{
						TlsUtilities.AdjustTranscriptForRetry(m_handshakeHash);
						SendServerHelloMessage(serverHello);
						m_connectionState = 2;
						SendChangeCipherSpecMessage();
					}
					else
					{
						SendServerHelloMessage(serverHello);
						m_connectionState = 4;
						SendChangeCipherSpecMessage();
						Send13ServerHelloCoda(serverHello, afterHelloRetryRequest: false);
					}
					break;
				}
				SendServerHelloMessage(serverHello);
				m_connectionState = 4;
				if (m_resumedSession)
				{
					securityParameters.m_masterSecret = m_sessionMasterSecret;
					m_recordStream.SetPendingCipher(TlsUtilities.InitCipher(m_tlsServerContext));
					SendChangeCipherSpec();
					SendFinishedMessage();
					m_connectionState = 20;
					break;
				}
				IList serverSupplementalData = m_tlsServer.GetServerSupplementalData();
				if (serverSupplementalData != null)
				{
					SendSupplementalDataMessage(serverSupplementalData);
					m_connectionState = 6;
				}
				m_keyExchange = TlsUtilities.InitKeyExchangeServer(m_tlsServerContext, m_tlsServer);
				TlsCredentials tlsCredentials = TlsUtilities.EstablishServerCredentials(m_tlsServer);
				Certificate certificate = null;
				MemoryStream memoryStream = new MemoryStream();
				if (tlsCredentials == null)
				{
					m_keyExchange.SkipServerCredentials();
				}
				else
				{
					m_keyExchange.ProcessServerCredentials(tlsCredentials);
					certificate = tlsCredentials.Certificate;
					SendCertificateMessage(certificate, memoryStream);
					m_connectionState = 7;
				}
				securityParameters.m_tlsServerEndPoint = memoryStream.ToArray();
				if (certificate == null || certificate.IsEmpty)
				{
					securityParameters.m_statusRequestVersion = 0;
				}
				if (securityParameters.StatusRequestVersion > 0)
				{
					CertificateStatus certificateStatus = m_tlsServer.GetCertificateStatus();
					if (certificateStatus != null)
					{
						SendCertificateStatusMessage(certificateStatus);
						m_connectionState = 8;
					}
				}
				byte[] array = m_keyExchange.GenerateServerKeyExchange();
				if (array != null)
				{
					SendServerKeyExchangeMessage(array);
					m_connectionState = 10;
				}
				if (tlsCredentials != null)
				{
					m_certificateRequest = m_tlsServer.GetCertificateRequest();
					if (m_certificateRequest == null)
					{
						if (!m_keyExchange.RequiresCertificateVerify)
						{
							throw new TlsFatalAlert(80);
						}
					}
					else
					{
						if (TlsUtilities.IsTlsV12(m_tlsServerContext) != (m_certificateRequest.SupportedSignatureAlgorithms != null))
						{
							throw new TlsFatalAlert(80);
						}
						m_certificateRequest = TlsUtilities.ValidateCertificateRequest(m_certificateRequest, m_keyExchange);
						TlsUtilities.EstablishServerSigAlgs(securityParameters, m_certificateRequest);
						TlsUtilities.TrackHashAlgorithms(m_handshakeHash, securityParameters.ServerSigAlgs);
						SendCertificateRequestMessage(m_certificateRequest);
						m_connectionState = 11;
					}
				}
				SendServerHelloDoneMessage();
				m_connectionState = 12;
				TlsUtilities.SealHandshakeHash(m_tlsServerContext, m_handshakeHash, forceBuffering: false);
				break;
			}
			}
			break;
		case 11:
		{
			short connectionState = m_connectionState;
			if (connectionState != 12 && connectionState != 14)
			{
				throw new TlsFatalAlert(10);
			}
			if (m_connectionState != 14)
			{
				m_tlsServer.ProcessClientSupplementalData(null);
			}
			if (m_certificateRequest == null)
			{
				throw new TlsFatalAlert(10);
			}
			ReceiveCertificateMessage(buf);
			m_connectionState = 15;
			break;
		}
		case 15:
			if (m_connectionState == 16)
			{
				if (!ExpectCertificateVerifyMessage())
				{
					throw new TlsFatalAlert(10);
				}
				ReceiveCertificateVerifyMessage(buf);
				buf.UpdateHash(m_handshakeHash);
				m_connectionState = 17;
				break;
			}
			throw new TlsFatalAlert(10);
		case 16:
		{
			short connectionState = m_connectionState;
			if (connectionState != 12 && (uint)(connectionState - 14) > 1u)
			{
				throw new TlsFatalAlert(10);
			}
			if (m_connectionState == 12)
			{
				m_tlsServer.ProcessClientSupplementalData(null);
			}
			if (m_connectionState != 15)
			{
				if (m_certificateRequest == null)
				{
					m_keyExchange.SkipClientCredentials();
				}
				else
				{
					if (TlsUtilities.IsTlsV12(m_tlsServerContext))
					{
						throw new TlsFatalAlert(10);
					}
					if (TlsUtilities.IsSsl(m_tlsServerContext))
					{
						throw new TlsFatalAlert(10);
					}
					NotifyClientCertificate(Certificate.EmptyChain);
				}
			}
			ReceiveClientKeyExchangeMessage(buf);
			m_connectionState = 16;
			break;
		}
		case 20:
		{
			short connectionState = m_connectionState;
			if ((uint)(connectionState - 16) <= 1u)
			{
				if (m_connectionState != 17 && ExpectCertificateVerifyMessage())
				{
					throw new TlsFatalAlert(10);
				}
				ProcessFinishedMessage(buf);
				buf.UpdateHash(m_handshakeHash);
				m_connectionState = 18;
				if (m_expectSessionTicket)
				{
					SendNewSessionTicketMessage(m_tlsServer.GetNewSessionTicket());
					m_connectionState = 19;
				}
				SendChangeCipherSpec();
				SendFinishedMessage();
				m_connectionState = 20;
				CompleteHandshake();
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 23:
			if (m_connectionState != 12)
			{
				throw new TlsFatalAlert(10);
			}
			m_tlsServer.ProcessClientSupplementalData(TlsProtocol.ReadSupplementalDataMessage(buf));
			m_connectionState = 14;
			break;
		default:
			throw new TlsFatalAlert(10);
		}
	}

	protected override void HandleAlertWarningMessage(short alertDescription)
	{
		if (41 == alertDescription && m_certificateRequest != null && TlsUtilities.IsSsl(m_tlsServerContext))
		{
			short connectionState = m_connectionState;
			if (connectionState == 12 || connectionState == 14)
			{
				if (m_connectionState != 14)
				{
					m_tlsServer.ProcessClientSupplementalData(null);
				}
				NotifyClientCertificate(Certificate.EmptyChain);
				m_connectionState = 15;
				return;
			}
		}
		base.HandleAlertWarningMessage(alertDescription);
	}

	protected virtual void NotifyClientCertificate(Certificate clientCertificate)
	{
		if (m_certificateRequest == null)
		{
			throw new TlsFatalAlert(80);
		}
		TlsUtilities.ProcessClientCertificate(m_tlsServerContext, clientCertificate, m_keyExchange, m_tlsServer);
	}

	protected virtual void Receive13ClientCertificate(MemoryStream buf)
	{
		Certificate clientCertificate = Certificate.Parse(new Certificate.ParseOptions().SetMaxChainLength(m_tlsServer.GetMaxCertificateChainLength()), m_tlsServerContext, buf, null);
		TlsProtocol.AssertEmpty(buf);
		NotifyClientCertificate(clientCertificate);
	}

	protected void Receive13ClientCertificateVerify(MemoryStream buf)
	{
		Certificate peerCertificate = m_tlsServerContext.SecurityParameters.PeerCertificate;
		if (peerCertificate == null || peerCertificate.IsEmpty)
		{
			throw new TlsFatalAlert(80);
		}
		DigitallySigned certificateVerify = DigitallySigned.Parse(m_tlsServerContext, buf);
		TlsProtocol.AssertEmpty(buf);
		TlsUtilities.Verify13CertificateVerifyClient(m_tlsServerContext, m_certificateRequest, certificateVerify, m_handshakeHash);
	}

	protected virtual void Receive13ClientFinished(MemoryStream buf)
	{
		Process13FinishedMessage(buf);
	}

	protected virtual void ReceiveCertificateMessage(MemoryStream buf)
	{
		Certificate clientCertificate = Certificate.Parse(new Certificate.ParseOptions().SetMaxChainLength(m_tlsServer.GetMaxCertificateChainLength()), m_tlsServerContext, buf, null);
		TlsProtocol.AssertEmpty(buf);
		NotifyClientCertificate(clientCertificate);
	}

	protected virtual void ReceiveCertificateVerifyMessage(MemoryStream buf)
	{
		DigitallySigned certificateVerify = DigitallySigned.Parse(m_tlsServerContext, buf);
		TlsProtocol.AssertEmpty(buf);
		TlsUtilities.VerifyCertificateVerifyClient(m_tlsServerContext, m_certificateRequest, certificateVerify, m_handshakeHash);
		m_handshakeHash = m_handshakeHash.StopTracking();
	}

	protected virtual ClientHello ReceiveClientHelloMessage(MemoryStream buf)
	{
		return ClientHello.Parse(buf, null);
	}

	protected virtual void ReceiveClientKeyExchangeMessage(MemoryStream buf)
	{
		m_keyExchange.ProcessClientKeyExchange(buf);
		TlsProtocol.AssertEmpty(buf);
		bool num = TlsUtilities.IsSsl(m_tlsServerContext);
		if (num)
		{
			TlsProtocol.EstablishMasterSecret(m_tlsServerContext, m_keyExchange);
		}
		m_tlsServerContext.SecurityParameters.m_sessionHash = TlsUtilities.GetCurrentPrfHash(m_handshakeHash);
		if (!num)
		{
			TlsProtocol.EstablishMasterSecret(m_tlsServerContext, m_keyExchange);
		}
		m_recordStream.SetPendingCipher(TlsUtilities.InitCipher(m_tlsServerContext));
		if (!ExpectCertificateVerifyMessage())
		{
			m_handshakeHash = m_handshakeHash.StopTracking();
		}
	}

	protected virtual void Send13EncryptedExtensionsMessage(IDictionary serverExtensions)
	{
		byte[] buf = TlsProtocol.WriteExtensionsData(serverExtensions);
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(8);
		TlsUtilities.WriteOpaque16(buf, handshakeMessageOutput);
		handshakeMessageOutput.Send(this);
	}

	protected virtual void Send13ServerHelloCoda(ServerHello serverHello, bool afterHelloRetryRequest)
	{
		SecurityParameters securityParameters = m_tlsServerContext.SecurityParameters;
		byte[] currentPrfHash = TlsUtilities.GetCurrentPrfHash(m_handshakeHash);
		TlsUtilities.Establish13PhaseHandshake(m_tlsServerContext, currentPrfHash, m_recordStream);
		m_recordStream.EnablePendingCipherWrite();
		m_recordStream.EnablePendingCipherRead(deferred: true);
		Send13EncryptedExtensionsMessage(m_serverExtensions);
		m_connectionState = 5;
		m_certificateRequest = m_tlsServer.GetCertificateRequest();
		if (m_certificateRequest != null)
		{
			if (!m_certificateRequest.HasCertificateRequestContext(TlsUtilities.EmptyBytes))
			{
				throw new TlsFatalAlert(80);
			}
			TlsUtilities.EstablishServerSigAlgs(securityParameters, m_certificateRequest);
			SendCertificateRequestMessage(m_certificateRequest);
			m_connectionState = 11;
		}
		TlsCredentialedSigner tlsCredentialedSigner = TlsUtilities.Establish13ServerCredentials(m_tlsServer);
		if (tlsCredentialedSigner == null)
		{
			throw new TlsFatalAlert(80);
		}
		Certificate certificate = tlsCredentialedSigner.Certificate;
		Send13CertificateMessage(certificate);
		securityParameters.m_tlsServerEndPoint = null;
		m_connectionState = 7;
		DigitallySigned certificateVerify = TlsUtilities.Generate13CertificateVerify(m_tlsServerContext, tlsCredentialedSigner, m_handshakeHash);
		Send13CertificateVerifyMessage(certificateVerify);
		m_connectionState = 17;
		Send13FinishedMessage();
		m_connectionState = 20;
		byte[] currentPrfHash2 = TlsUtilities.GetCurrentPrfHash(m_handshakeHash);
		TlsUtilities.Establish13PhaseApplication(m_tlsServerContext, currentPrfHash2, m_recordStream);
		m_recordStream.EnablePendingCipherWrite();
	}

	protected virtual void SendCertificateRequestMessage(CertificateRequest certificateRequest)
	{
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(13);
		certificateRequest.Encode(m_tlsServerContext, handshakeMessageOutput);
		handshakeMessageOutput.Send(this);
	}

	protected virtual void SendCertificateStatusMessage(CertificateStatus certificateStatus)
	{
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(22);
		certificateStatus.Encode(handshakeMessageOutput);
		handshakeMessageOutput.Send(this);
	}

	protected virtual void SendHelloRequestMessage()
	{
		HandshakeMessageOutput.Send(this, 0, TlsUtilities.EmptyBytes);
	}

	protected virtual void SendNewSessionTicketMessage(NewSessionTicket newSessionTicket)
	{
		if (newSessionTicket == null)
		{
			throw new TlsFatalAlert(80);
		}
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(4);
		newSessionTicket.Encode(handshakeMessageOutput);
		handshakeMessageOutput.Send(this);
	}

	protected virtual void SendServerHelloDoneMessage()
	{
		HandshakeMessageOutput.Send(this, 14, TlsUtilities.EmptyBytes);
	}

	protected virtual void SendServerHelloMessage(ServerHello serverHello)
	{
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(2);
		serverHello.Encode(m_tlsServerContext, handshakeMessageOutput);
		handshakeMessageOutput.Send(this);
	}

	protected virtual void SendServerKeyExchangeMessage(byte[] serverKeyExchange)
	{
		HandshakeMessageOutput.Send(this, 12, serverKeyExchange);
	}

	protected virtual void Skip13ClientCertificate()
	{
		if (m_certificateRequest != null)
		{
			throw new TlsFatalAlert(10);
		}
	}

	protected virtual void Skip13ClientCertificateVerify()
	{
		if (ExpectCertificateVerifyMessage())
		{
			throw new TlsFatalAlert(10);
		}
	}
}
