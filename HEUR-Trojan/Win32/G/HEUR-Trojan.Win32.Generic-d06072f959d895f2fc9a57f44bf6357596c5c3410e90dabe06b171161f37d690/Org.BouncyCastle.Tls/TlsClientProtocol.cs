using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class TlsClientProtocol : TlsProtocol
{
	protected TlsClient m_tlsClient;

	internal TlsClientContextImpl m_tlsClientContext;

	protected IDictionary m_clientAgreements;

	internal OfferedPsks.BindersConfig m_clientBinders;

	protected ClientHello m_clientHello;

	protected TlsKeyExchange m_keyExchange;

	protected TlsAuthentication m_authentication;

	protected CertificateStatus m_certificateStatus;

	protected CertificateRequest m_certificateRequest;

	protected override TlsContext Context => m_tlsClientContext;

	internal override AbstractTlsContext ContextAdmin => m_tlsClientContext;

	protected override TlsPeer Peer => m_tlsClient;

	public TlsClientProtocol()
	{
	}

	public TlsClientProtocol(Stream stream)
		: base(stream)
	{
	}

	public TlsClientProtocol(Stream input, Stream output)
		: base(input, output)
	{
	}

	public virtual void Connect(TlsClient tlsClient)
	{
		if (tlsClient == null)
		{
			throw new ArgumentNullException("tlsClient");
		}
		if (m_tlsClient != null)
		{
			throw new InvalidOperationException("'Connect' can only be called once");
		}
		m_tlsClient = tlsClient;
		m_tlsClientContext = new TlsClientContextImpl(tlsClient.Crypto);
		tlsClient.Init(m_tlsClientContext);
		tlsClient.NotifyCloseHandle(this);
		BeginHandshake();
		if (m_blocking)
		{
			BlockForHandshake();
		}
	}

	protected override void BeginHandshake()
	{
		base.BeginHandshake();
		SendClientHello();
		m_connectionState = 1;
	}

	protected override void CleanupHandshake()
	{
		base.CleanupHandshake();
		m_clientAgreements = null;
		m_clientBinders = null;
		m_clientHello = null;
		m_keyExchange = null;
		m_authentication = null;
		m_certificateStatus = null;
		m_certificateRequest = null;
	}

	protected virtual void Handle13HandshakeMessage(short type, HandshakeMessageInput buf)
	{
		if (IsTlsV13ConnectionState() && !m_resumedSession)
		{
			switch (type)
			{
			case 2:
				switch (m_connectionState)
				{
				default:
					throw new TlsFatalAlert(10);
				case 3:
				{
					ServerHello serverHello = ReceiveServerHelloMessage(buf);
					if (serverHello.IsHelloRetryRequest())
					{
						throw new TlsFatalAlert(10);
					}
					Process13ServerHello(serverHello, afterHelloRetryRequest: true);
					buf.UpdateHash(m_handshakeHash);
					m_connectionState = 4;
					Process13ServerHelloCoda(serverHello, afterHelloRetryRequest: true);
					break;
				}
				case 1:
					throw new TlsFatalAlert(80);
				}
				break;
			case 4:
				Receive13NewSessionTicket(buf);
				break;
			case 8:
				if (m_connectionState == 4)
				{
					Receive13EncryptedExtensions(buf);
					m_connectionState = 5;
					break;
				}
				throw new TlsFatalAlert(10);
			case 11:
			{
				short connectionState = m_connectionState;
				if (connectionState != 5 && connectionState != 11)
				{
					throw new TlsFatalAlert(10);
				}
				if (m_connectionState != 11)
				{
					Skip13CertificateRequest();
				}
				Receive13ServerCertificate(buf);
				m_connectionState = 7;
				break;
			}
			case 13:
			{
				short connectionState = m_connectionState;
				if (connectionState != 5)
				{
					throw new TlsFatalAlert(10);
				}
				Receive13CertificateRequest(buf, postHandshakeAuth: false);
				m_connectionState = 11;
				break;
			}
			case 15:
				if (m_connectionState == 7)
				{
					Receive13ServerCertificateVerify(buf);
					buf.UpdateHash(m_handshakeHash);
					m_connectionState = 9;
					break;
				}
				throw new TlsFatalAlert(10);
			case 20:
			{
				short connectionState = m_connectionState;
				if (connectionState != 5 && connectionState != 9 && connectionState != 11)
				{
					throw new TlsFatalAlert(10);
				}
				if (m_connectionState == 5)
				{
					Skip13CertificateRequest();
				}
				if (m_connectionState != 9)
				{
					Skip13ServerCertificate();
				}
				Receive13ServerFinished(buf);
				buf.UpdateHash(m_handshakeHash);
				m_connectionState = 20;
				byte[] currentPrfHash = TlsUtilities.GetCurrentPrfHash(m_handshakeHash);
				m_recordStream.SetIgnoreChangeCipherSpec(ignoreChangeCipherSpec: false);
				if (m_certificateRequest != null)
				{
					TlsCredentialedSigner tlsCredentialedSigner = TlsUtilities.Establish13ClientCredentials(m_authentication, m_certificateRequest);
					Certificate certificate = null;
					if (tlsCredentialedSigner != null)
					{
						certificate = tlsCredentialedSigner.Certificate;
					}
					if (certificate == null)
					{
						certificate = Certificate.EmptyChainTls13;
					}
					Send13CertificateMessage(certificate);
					m_connectionState = 15;
					if (tlsCredentialedSigner != null)
					{
						DigitallySigned certificateVerify = TlsUtilities.Generate13CertificateVerify(m_tlsClientContext, tlsCredentialedSigner, m_handshakeHash);
						Send13CertificateVerifyMessage(certificateVerify);
						m_connectionState = 17;
					}
				}
				Send13FinishedMessage();
				m_connectionState = 18;
				TlsUtilities.Establish13PhaseApplication(m_tlsClientContext, currentPrfHash, m_recordStream);
				m_recordStream.EnablePendingCipherWrite();
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
			return;
		}
		throw new TlsFatalAlert(80);
	}

	protected override void HandleHandshakeMessage(short type, HandshakeMessageInput buf)
	{
		SecurityParameters securityParameters = m_tlsClientContext.SecurityParameters;
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
			if (type == 20 && m_connectionState == 4)
			{
				ProcessFinishedMessage(buf);
				buf.UpdateHash(m_handshakeHash);
				m_connectionState = 20;
				SendChangeCipherSpec();
				SendFinishedMessage();
				m_connectionState = 18;
				CompleteHandshake();
				return;
			}
			throw new TlsFatalAlert(10);
		}
		switch (type)
		{
		case 0:
			TlsProtocol.AssertEmpty(buf);
			if (base.IsApplicationDataReady)
			{
				RefuseRenegotiation();
			}
			break;
		case 2:
			if (m_connectionState == 1)
			{
				ServerHello serverHello = ReceiveServerHelloMessage(buf);
				if (serverHello.IsHelloRetryRequest())
				{
					Process13HelloRetryRequest(serverHello);
					m_handshakeHash.NotifyPrfDetermined();
					TlsUtilities.AdjustTranscriptForRetry(m_handshakeHash);
					buf.UpdateHash(m_handshakeHash);
					m_connectionState = 2;
					Send13ClientHelloRetry();
					m_handshakeHash.SealHashAlgorithms();
					m_connectionState = 3;
				}
				else
				{
					ProcessServerHello(serverHello);
					m_handshakeHash.NotifyPrfDetermined();
					buf.UpdateHash(m_handshakeHash);
					m_connectionState = 4;
					if (TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
					{
						m_handshakeHash.SealHashAlgorithms();
						Process13ServerHelloCoda(serverHello, afterHelloRetryRequest: false);
					}
				}
				break;
			}
			throw new TlsFatalAlert(10);
		case 4:
			if (m_connectionState == 18)
			{
				if (!m_expectSessionTicket)
				{
					throw new TlsFatalAlert(10);
				}
				InvalidateSession();
				ReceiveNewSessionTicket(buf);
				m_connectionState = 19;
				break;
			}
			throw new TlsFatalAlert(10);
		case 11:
		{
			short connectionState = m_connectionState;
			if (connectionState != 4 && connectionState != 6)
			{
				throw new TlsFatalAlert(10);
			}
			if (m_connectionState != 6)
			{
				HandleSupplementalData(null);
			}
			m_authentication = TlsUtilities.ReceiveServerCertificate(m_tlsClientContext, m_tlsClient, buf);
			m_connectionState = 7;
			break;
		}
		case 12:
		{
			short connectionState = m_connectionState;
			if (connectionState != 4 && (uint)(connectionState - 6) > 2u)
			{
				throw new TlsFatalAlert(10);
			}
			if (m_connectionState == 4)
			{
				HandleSupplementalData(null);
			}
			if (m_connectionState != 7 && m_connectionState != 8)
			{
				m_authentication = null;
			}
			HandleServerCertificate();
			m_keyExchange.ProcessServerKeyExchange(buf);
			TlsProtocol.AssertEmpty(buf);
			m_connectionState = 10;
			break;
		}
		case 13:
		{
			short connectionState = m_connectionState;
			if ((uint)(connectionState - 7) > 1u && connectionState != 10)
			{
				throw new TlsFatalAlert(10);
			}
			if (m_connectionState != 10)
			{
				HandleServerCertificate();
				m_keyExchange.SkipServerKeyExchange();
			}
			ReceiveCertificateRequest(buf);
			TlsUtilities.EstablishServerSigAlgs(securityParameters, m_certificateRequest);
			TlsUtilities.TrackHashAlgorithms(m_handshakeHash, securityParameters.ServerSigAlgs);
			m_connectionState = 11;
			break;
		}
		case 14:
			switch (m_connectionState)
			{
			default:
				throw new TlsFatalAlert(10);
			case 4:
			case 6:
			case 7:
			case 8:
			case 10:
			case 11:
			{
				if (m_connectionState == 4)
				{
					HandleSupplementalData(null);
				}
				if (m_connectionState == 4 || m_connectionState == 6)
				{
					m_authentication = null;
				}
				if (m_connectionState != 10 && m_connectionState != 11)
				{
					HandleServerCertificate();
					m_keyExchange.SkipServerKeyExchange();
				}
				TlsProtocol.AssertEmpty(buf);
				m_connectionState = 12;
				IList clientSupplementalData = m_tlsClient.GetClientSupplementalData();
				if (clientSupplementalData != null)
				{
					SendSupplementalDataMessage(clientSupplementalData);
					m_connectionState = 14;
				}
				TlsCredentialedSigner tlsCredentialedSigner = null;
				TlsStreamSigner tlsStreamSigner = null;
				if (m_certificateRequest == null)
				{
					m_keyExchange.SkipClientCredentials();
				}
				else
				{
					Certificate certificate = null;
					TlsCredentials tlsCredentials = TlsUtilities.EstablishClientCredentials(m_authentication, m_certificateRequest);
					if (tlsCredentials == null)
					{
						m_keyExchange.SkipClientCredentials();
					}
					else
					{
						m_keyExchange.ProcessClientCredentials(tlsCredentials);
						certificate = tlsCredentials.Certificate;
						if (tlsCredentials is TlsCredentialedSigner)
						{
							tlsCredentialedSigner = (TlsCredentialedSigner)tlsCredentials;
							tlsStreamSigner = tlsCredentialedSigner.GetStreamSigner();
						}
					}
					SendCertificateMessage(certificate, null);
					m_connectionState = 15;
				}
				bool forceBuffering = tlsStreamSigner != null;
				TlsUtilities.SealHandshakeHash(m_tlsClientContext, m_handshakeHash, forceBuffering);
				SendClientKeyExchange();
				m_connectionState = 16;
				bool num = TlsUtilities.IsSsl(m_tlsClientContext);
				if (num)
				{
					TlsProtocol.EstablishMasterSecret(m_tlsClientContext, m_keyExchange);
				}
				securityParameters.m_sessionHash = TlsUtilities.GetCurrentPrfHash(m_handshakeHash);
				if (!num)
				{
					TlsProtocol.EstablishMasterSecret(m_tlsClientContext, m_keyExchange);
				}
				m_recordStream.SetPendingCipher(TlsUtilities.InitCipher(m_tlsClientContext));
				if (tlsCredentialedSigner != null)
				{
					DigitallySigned certificateVerify = TlsUtilities.GenerateCertificateVerifyClient(m_tlsClientContext, tlsCredentialedSigner, tlsStreamSigner, m_handshakeHash);
					SendCertificateVerifyMessage(certificateVerify);
					m_connectionState = 17;
				}
				m_handshakeHash = m_handshakeHash.StopTracking();
				SendChangeCipherSpec();
				SendFinishedMessage();
				m_connectionState = 18;
				break;
			}
			}
			break;
		case 20:
		{
			short connectionState = m_connectionState;
			if ((uint)(connectionState - 18) <= 1u)
			{
				if (m_connectionState != 19 && m_expectSessionTicket)
				{
					throw new TlsFatalAlert(10);
				}
				ProcessFinishedMessage(buf);
				m_connectionState = 20;
				CompleteHandshake();
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 22:
			if (m_connectionState == 7)
			{
				if (securityParameters.StatusRequestVersion < 1)
				{
					throw new TlsFatalAlert(10);
				}
				m_certificateStatus = CertificateStatus.Parse(m_tlsClientContext, buf);
				TlsProtocol.AssertEmpty(buf);
				m_connectionState = 8;
				break;
			}
			throw new TlsFatalAlert(10);
		case 23:
			if (m_connectionState != 4)
			{
				throw new TlsFatalAlert(10);
			}
			HandleSupplementalData(TlsProtocol.ReadSupplementalDataMessage(buf));
			break;
		default:
			throw new TlsFatalAlert(10);
		}
	}

	protected virtual void HandleServerCertificate()
	{
		TlsUtilities.ProcessServerCertificate(m_tlsClientContext, m_certificateStatus, m_keyExchange, m_authentication, m_clientExtensions, m_serverExtensions);
	}

	protected virtual void HandleSupplementalData(IList serverSupplementalData)
	{
		m_tlsClient.ProcessServerSupplementalData(serverSupplementalData);
		m_connectionState = 6;
		m_keyExchange = TlsUtilities.InitKeyExchangeClient(m_tlsClientContext, m_tlsClient);
	}

	protected virtual void Process13HelloRetryRequest(ServerHello helloRetryRequest)
	{
		ProtocolVersion tLSv = ProtocolVersion.TLSv12;
		m_recordStream.SetWriteVersion(tLSv);
		SecurityParameters securityParameters = m_tlsClientContext.SecurityParameters;
		ProtocolVersion version = helloRetryRequest.Version;
		byte[] sessionID = helloRetryRequest.SessionID;
		int cipherSuite = helloRetryRequest.CipherSuite;
		if (ProtocolVersion.TLSv12.Equals(version) && Arrays.AreEqual(m_clientHello.SessionID, sessionID) && TlsUtilities.IsValidCipherSuiteSelection(m_clientHello.CipherSuites, cipherSuite))
		{
			IDictionary extensions = helloRetryRequest.Extensions;
			if (extensions == null)
			{
				throw new TlsFatalAlert(47);
			}
			TlsUtilities.CheckExtensionData13(extensions, 6, 47);
			foreach (int key in extensions.Keys)
			{
				if (44 != key && TlsUtilities.GetExtensionData(m_clientExtensions, key) == null)
				{
					throw new TlsFatalAlert(110);
				}
			}
			ProtocolVersion supportedVersionsExtensionServer = TlsExtensionsUtilities.GetSupportedVersionsExtensionServer(extensions);
			if (supportedVersionsExtensionServer == null)
			{
				throw new TlsFatalAlert(109);
			}
			if (ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(supportedVersionsExtensionServer) && ProtocolVersion.Contains(m_tlsClientContext.ClientSupportedVersions, supportedVersionsExtensionServer) && TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, supportedVersionsExtensionServer))
			{
				if (m_clientBinders != null && !Arrays.Contains(m_clientBinders.m_pskKeyExchangeModes, 1))
				{
					m_clientBinders = null;
					m_tlsClient.NotifySelectedPsk(null);
				}
				int keyShareHelloRetryRequest = TlsExtensionsUtilities.GetKeyShareHelloRetryRequest(extensions);
				if (!TlsUtilities.IsValidKeyShareSelection(supportedVersionsExtensionServer, securityParameters.ClientSupportedGroups, m_clientAgreements, keyShareHelloRetryRequest))
				{
					throw new TlsFatalAlert(47);
				}
				byte[] cookieExtension = TlsExtensionsUtilities.GetCookieExtension(extensions);
				securityParameters.m_negotiatedVersion = supportedVersionsExtensionServer;
				TlsUtilities.NegotiatedVersionTlsClient(m_tlsClientContext, m_tlsClient);
				m_resumedSession = false;
				securityParameters.m_sessionID = TlsUtilities.EmptyBytes;
				m_tlsClient.NotifySessionID(TlsUtilities.EmptyBytes);
				TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
				m_tlsClient.NotifySelectedCipherSuite(cipherSuite);
				m_clientAgreements = null;
				m_retryCookie = cookieExtension;
				m_retryGroup = keyShareHelloRetryRequest;
				return;
			}
			throw new TlsFatalAlert(47);
		}
		throw new TlsFatalAlert(47);
	}

	protected virtual void Process13ServerHello(ServerHello serverHello, bool afterHelloRetryRequest)
	{
		SecurityParameters securityParameters = m_tlsClientContext.SecurityParameters;
		ProtocolVersion version = serverHello.Version;
		byte[] sessionID = serverHello.SessionID;
		int cipherSuite = serverHello.CipherSuite;
		if (ProtocolVersion.TLSv12.Equals(version) && Arrays.AreEqual(m_clientHello.SessionID, sessionID))
		{
			IDictionary extensions = serverHello.Extensions;
			if (extensions == null)
			{
				throw new TlsFatalAlert(47);
			}
			TlsUtilities.CheckExtensionData13(extensions, 2, 47);
			if (afterHelloRetryRequest)
			{
				ProtocolVersion supportedVersionsExtensionServer = TlsExtensionsUtilities.GetSupportedVersionsExtensionServer(extensions);
				if (supportedVersionsExtensionServer == null)
				{
					throw new TlsFatalAlert(109);
				}
				if (!securityParameters.NegotiatedVersion.Equals(supportedVersionsExtensionServer) || securityParameters.CipherSuite != cipherSuite)
				{
					throw new TlsFatalAlert(47);
				}
			}
			else
			{
				if (!TlsUtilities.IsValidCipherSuiteSelection(m_clientHello.CipherSuites, cipherSuite) || !TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, securityParameters.NegotiatedVersion))
				{
					throw new TlsFatalAlert(47);
				}
				m_resumedSession = false;
				securityParameters.m_sessionID = TlsUtilities.EmptyBytes;
				m_tlsClient.NotifySessionID(TlsUtilities.EmptyBytes);
				TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
				m_tlsClient.NotifySelectedCipherSuite(cipherSuite);
			}
			m_clientHello = null;
			securityParameters.m_serverRandom = serverHello.Random;
			securityParameters.m_secureRenegotiation = false;
			securityParameters.m_extendedMasterSecret = true;
			securityParameters.m_statusRequestVersion = (m_clientExtensions.Contains(5) ? 1 : 0);
			TlsSecret tlsSecret = null;
			int preSharedKeyServerHello = TlsExtensionsUtilities.GetPreSharedKeyServerHello(extensions);
			TlsPsk tlsPsk = null;
			if (preSharedKeyServerHello >= 0)
			{
				if (m_clientBinders == null || preSharedKeyServerHello >= m_clientBinders.m_psks.Length)
				{
					throw new TlsFatalAlert(47);
				}
				tlsPsk = m_clientBinders.m_psks[preSharedKeyServerHello];
				if (tlsPsk.PrfAlgorithm != securityParameters.PrfAlgorithm)
				{
					throw new TlsFatalAlert(47);
				}
				tlsSecret = m_clientBinders.m_earlySecrets[preSharedKeyServerHello];
				m_selectedPsk13 = true;
			}
			m_tlsClient.NotifySelectedPsk(tlsPsk);
			TlsSecret sharedSecret = null;
			KeyShareEntry keyShareServerHello = TlsExtensionsUtilities.GetKeyShareServerHello(extensions);
			if (keyShareServerHello == null)
			{
				if (afterHelloRetryRequest || tlsSecret == null || !Arrays.Contains(m_clientBinders.m_pskKeyExchangeModes, 0))
				{
					throw new TlsFatalAlert(47);
				}
			}
			else
			{
				if (tlsSecret != null && !Arrays.Contains(m_clientBinders.m_pskKeyExchangeModes, 1))
				{
					throw new TlsFatalAlert(47);
				}
				TlsAgreement tlsAgreement = (TlsAgreement)m_clientAgreements[keyShareServerHello.NamedGroup];
				if (tlsAgreement == null)
				{
					throw new TlsFatalAlert(47);
				}
				tlsAgreement.ReceivePeerValue(keyShareServerHello.KeyExchange);
				sharedSecret = tlsAgreement.CalculateSecret();
			}
			m_clientAgreements = null;
			m_clientBinders = null;
			TlsUtilities.Establish13PhaseSecrets(m_tlsClientContext, tlsSecret, sharedSecret);
			InvalidateSession();
			m_tlsSession = TlsUtilities.ImportSession(securityParameters.SessionID, null);
			m_sessionParameters = null;
			m_sessionMasterSecret = null;
			return;
		}
		throw new TlsFatalAlert(47);
	}

	protected virtual void Process13ServerHelloCoda(ServerHello serverHello, bool afterHelloRetryRequest)
	{
		byte[] currentPrfHash = TlsUtilities.GetCurrentPrfHash(m_handshakeHash);
		TlsUtilities.Establish13PhaseHandshake(m_tlsClientContext, currentPrfHash, m_recordStream);
		if (!afterHelloRetryRequest)
		{
			m_recordStream.SetIgnoreChangeCipherSpec(ignoreChangeCipherSpec: true);
			SendChangeCipherSpecMessage();
		}
		m_recordStream.EnablePendingCipherWrite();
		m_recordStream.EnablePendingCipherRead(deferred: false);
	}

	protected virtual void ProcessServerHello(ServerHello serverHello)
	{
		IDictionary extensions = serverHello.Extensions;
		ProtocolVersion version = serverHello.Version;
		ProtocolVersion supportedVersionsExtensionServer = TlsExtensionsUtilities.GetSupportedVersionsExtensionServer(extensions);
		ProtocolVersion protocolVersion;
		if (supportedVersionsExtensionServer == null)
		{
			protocolVersion = version;
		}
		else
		{
			if (!ProtocolVersion.TLSv12.Equals(version) || !ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(supportedVersionsExtensionServer))
			{
				throw new TlsFatalAlert(47);
			}
			protocolVersion = supportedVersionsExtensionServer;
		}
		SecurityParameters securityParameters = m_tlsClientContext.SecurityParameters;
		if (!ProtocolVersion.Contains(m_tlsClientContext.ClientSupportedVersions, protocolVersion))
		{
			throw new TlsFatalAlert(70);
		}
		ProtocolVersion writeVersion = (protocolVersion.IsLaterVersionOf(ProtocolVersion.TLSv12) ? ProtocolVersion.TLSv12 : protocolVersion);
		m_recordStream.SetWriteVersion(writeVersion);
		securityParameters.m_negotiatedVersion = protocolVersion;
		TlsUtilities.NegotiatedVersionTlsClient(m_tlsClientContext, m_tlsClient);
		if (ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(protocolVersion))
		{
			Process13ServerHello(serverHello, afterHelloRetryRequest: false);
			return;
		}
		int[] cipherSuites = m_clientHello.CipherSuites;
		m_clientHello = null;
		m_retryCookie = null;
		m_retryGroup = -1;
		securityParameters.m_serverRandom = serverHello.Random;
		if (!m_tlsClientContext.ClientVersion.Equals(protocolVersion))
		{
			TlsUtilities.CheckDowngradeMarker(protocolVersion, securityParameters.ServerRandom);
		}
		byte[] array = (securityParameters.m_sessionID = serverHello.SessionID);
		m_tlsClient.NotifySessionID(array);
		m_resumedSession = array.Length != 0 && m_tlsSession != null && Arrays.AreEqual(array, m_tlsSession.SessionID);
		int cipherSuite = serverHello.CipherSuite;
		if (TlsUtilities.IsValidCipherSuiteSelection(cipherSuites, cipherSuite) && TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, securityParameters.NegotiatedVersion))
		{
			TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
			m_tlsClient.NotifySelectedCipherSuite(cipherSuite);
			m_serverExtensions = extensions;
			if (m_serverExtensions != null)
			{
				foreach (int key in m_serverExtensions.Keys)
				{
					if (65281 != key && TlsUtilities.GetExtensionData(m_clientExtensions, key) == null)
					{
						throw new TlsFatalAlert(110);
					}
				}
			}
			byte[] extensionData = TlsUtilities.GetExtensionData(m_serverExtensions, 65281);
			if (extensionData == null)
			{
				securityParameters.m_secureRenegotiation = false;
			}
			else
			{
				securityParameters.m_secureRenegotiation = true;
				if (!Arrays.ConstantTimeAreEqual(extensionData, TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes)))
				{
					throw new TlsFatalAlert(40);
				}
			}
			m_tlsClient.NotifySecureRenegotiation(securityParameters.IsSecureRenegotiation);
			bool extendedMasterSecret;
			if (extendedMasterSecret = TlsExtensionsUtilities.HasExtendedMasterSecretExtension(m_serverExtensions))
			{
				if (protocolVersion.IsSsl || (!m_resumedSession && !m_tlsClient.ShouldUseExtendedMasterSecret()))
				{
					throw new TlsFatalAlert(40);
				}
			}
			else if (m_tlsClient.RequiresExtendedMasterSecret() || (m_resumedSession && !m_tlsClient.AllowLegacyResumption()))
			{
				throw new TlsFatalAlert(40);
			}
			securityParameters.m_extendedMasterSecret = extendedMasterSecret;
			securityParameters.m_applicationProtocol = TlsExtensionsUtilities.GetAlpnExtensionServer(m_serverExtensions);
			securityParameters.m_applicationProtocolSet = true;
			IDictionary dictionary = m_clientExtensions;
			IDictionary dictionary2 = m_serverExtensions;
			if (m_resumedSession)
			{
				if (securityParameters.CipherSuite != m_sessionParameters.CipherSuite || !protocolVersion.Equals(m_sessionParameters.NegotiatedVersion))
				{
					throw new TlsFatalAlert(47);
				}
				dictionary = null;
				dictionary2 = m_sessionParameters.ReadServerExtensions();
			}
			if (dictionary2 != null && dictionary2.Count > 0)
			{
				bool encryptThenMac;
				if ((encryptThenMac = TlsExtensionsUtilities.HasEncryptThenMacExtension(dictionary2)) && !TlsUtilities.IsBlockCipherSuite(securityParameters.CipherSuite))
				{
					throw new TlsFatalAlert(47);
				}
				securityParameters.m_encryptThenMac = encryptThenMac;
				securityParameters.m_maxFragmentLength = ProcessMaxFragmentLengthExtension(dictionary, dictionary2, 47);
				securityParameters.m_truncatedHmac = TlsExtensionsUtilities.HasTruncatedHmacExtension(dictionary2);
				if (!m_resumedSession)
				{
					if (TlsUtilities.HasExpectedEmptyExtensionData(dictionary2, 17, 47))
					{
						securityParameters.m_statusRequestVersion = 2;
					}
					else if (TlsUtilities.HasExpectedEmptyExtensionData(dictionary2, 5, 47))
					{
						securityParameters.m_statusRequestVersion = 1;
					}
					m_expectSessionTicket = TlsUtilities.HasExpectedEmptyExtensionData(dictionary2, 35, 47);
				}
			}
			if (dictionary != null)
			{
				m_tlsClient.ProcessServerExtensions(dictionary2);
			}
			ApplyMaxFragmentLengthExtension(securityParameters.MaxFragmentLength);
			if (m_resumedSession)
			{
				securityParameters.m_masterSecret = m_sessionMasterSecret;
				m_recordStream.SetPendingCipher(TlsUtilities.InitCipher(m_tlsClientContext));
				return;
			}
			InvalidateSession();
			m_tlsSession = TlsUtilities.ImportSession(securityParameters.SessionID, null);
			m_sessionParameters = null;
			m_sessionMasterSecret = null;
			return;
		}
		throw new TlsFatalAlert(47);
	}

	protected virtual void Receive13CertificateRequest(MemoryStream buf, bool postHandshakeAuth)
	{
		if (postHandshakeAuth)
		{
			throw new TlsFatalAlert(80);
		}
		if (m_selectedPsk13)
		{
			throw new TlsFatalAlert(10);
		}
		CertificateRequest certificateRequest = CertificateRequest.Parse(m_tlsClientContext, buf);
		TlsProtocol.AssertEmpty(buf);
		if (!certificateRequest.HasCertificateRequestContext(TlsUtilities.EmptyBytes))
		{
			throw new TlsFatalAlert(47);
		}
		m_certificateRequest = certificateRequest;
		TlsUtilities.EstablishServerSigAlgs(m_tlsClientContext.SecurityParameters, certificateRequest);
	}

	protected virtual void Receive13EncryptedExtensions(MemoryStream buf)
	{
		byte[] extBytes = TlsUtilities.ReadOpaque16(buf);
		TlsProtocol.AssertEmpty(buf);
		m_serverExtensions = TlsProtocol.ReadExtensionsData13(8, extBytes);
		foreach (int key in m_serverExtensions.Keys)
		{
			if (TlsUtilities.GetExtensionData(m_clientExtensions, key) == null)
			{
				throw new TlsFatalAlert(110);
			}
		}
		SecurityParameters securityParameters = m_tlsClientContext.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		securityParameters.m_applicationProtocol = TlsExtensionsUtilities.GetAlpnExtensionServer(m_serverExtensions);
		securityParameters.m_applicationProtocolSet = true;
		IDictionary dictionary = m_clientExtensions;
		IDictionary serverExtensions = m_serverExtensions;
		if (m_resumedSession)
		{
			if (securityParameters.CipherSuite != m_sessionParameters.CipherSuite || !negotiatedVersion.Equals(m_sessionParameters.NegotiatedVersion))
			{
				throw new TlsFatalAlert(47);
			}
			dictionary = null;
			serverExtensions = m_sessionParameters.ReadServerExtensions();
		}
		securityParameters.m_maxFragmentLength = ProcessMaxFragmentLengthExtension(dictionary, serverExtensions, 47);
		securityParameters.m_encryptThenMac = false;
		securityParameters.m_truncatedHmac = false;
		securityParameters.m_statusRequestVersion = (m_clientExtensions.Contains(5) ? 1 : 0);
		m_expectSessionTicket = false;
		if (dictionary != null)
		{
			m_tlsClient.ProcessServerExtensions(m_serverExtensions);
		}
		ApplyMaxFragmentLengthExtension(securityParameters.MaxFragmentLength);
	}

	protected virtual void Receive13NewSessionTicket(MemoryStream buf)
	{
		if (!base.IsApplicationDataReady)
		{
			throw new TlsFatalAlert(10);
		}
		TlsUtilities.ReadUint32(buf);
		TlsUtilities.ReadUint32(buf);
		TlsUtilities.ReadOpaque8(buf);
		TlsUtilities.ReadOpaque16(buf);
		TlsUtilities.ReadOpaque16(buf);
		TlsProtocol.AssertEmpty(buf);
	}

	protected virtual void Receive13ServerCertificate(MemoryStream buf)
	{
		if (m_selectedPsk13)
		{
			throw new TlsFatalAlert(10);
		}
		m_authentication = TlsUtilities.Receive13ServerCertificate(m_tlsClientContext, m_tlsClient, buf);
		HandleServerCertificate();
	}

	protected virtual void Receive13ServerCertificateVerify(MemoryStream buf)
	{
		Certificate peerCertificate = m_tlsClientContext.SecurityParameters.PeerCertificate;
		if (peerCertificate == null || peerCertificate.IsEmpty)
		{
			throw new TlsFatalAlert(80);
		}
		DigitallySigned certificateVerify = DigitallySigned.Parse(m_tlsClientContext, buf);
		TlsProtocol.AssertEmpty(buf);
		TlsUtilities.Verify13CertificateVerifyServer(m_tlsClientContext, certificateVerify, m_handshakeHash);
	}

	protected virtual void Receive13ServerFinished(MemoryStream buf)
	{
		Process13FinishedMessage(buf);
	}

	protected virtual void ReceiveCertificateRequest(MemoryStream buf)
	{
		if (m_authentication == null)
		{
			throw new TlsFatalAlert(40);
		}
		CertificateRequest certificateRequest = CertificateRequest.Parse(m_tlsClientContext, buf);
		TlsProtocol.AssertEmpty(buf);
		m_certificateRequest = TlsUtilities.ValidateCertificateRequest(certificateRequest, m_keyExchange);
	}

	protected virtual void ReceiveNewSessionTicket(MemoryStream buf)
	{
		NewSessionTicket newSessionTicket = NewSessionTicket.Parse(buf);
		TlsProtocol.AssertEmpty(buf);
		m_tlsClient.NotifyNewSessionTicket(newSessionTicket);
	}

	protected virtual ServerHello ReceiveServerHelloMessage(MemoryStream buf)
	{
		return ServerHello.Parse(buf);
	}

	protected virtual void Send13ClientHelloRetry()
	{
		IDictionary extensions = m_clientHello.Extensions;
		extensions.Remove(44);
		extensions.Remove(42);
		extensions.Remove(51);
		extensions.Remove(41);
		if (m_retryCookie != null)
		{
			TlsExtensionsUtilities.AddCookieExtension(extensions, m_retryCookie);
			m_retryCookie = null;
		}
		if (m_clientBinders != null)
		{
			m_clientBinders = TlsUtilities.AddPreSharedKeyToClientHelloRetry(m_tlsClientContext, m_clientBinders, extensions);
			if (m_clientBinders == null)
			{
				m_tlsClient.NotifySelectedPsk(null);
			}
		}
		if (m_retryGroup < 0)
		{
			throw new TlsFatalAlert(80);
		}
		m_clientAgreements = TlsUtilities.AddKeyShareToClientHelloRetry(m_tlsClientContext, extensions, m_retryGroup);
		m_recordStream.SetIgnoreChangeCipherSpec(ignoreChangeCipherSpec: true);
		SendChangeCipherSpecMessage();
		SendClientHelloMessage();
	}

	protected virtual void SendCertificateVerifyMessage(DigitallySigned certificateVerify)
	{
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(15);
		certificateVerify.Encode(handshakeMessageOutput);
		handshakeMessageOutput.Send(this);
	}

	protected virtual void SendClientHello()
	{
		SecurityParameters securityParameters = m_tlsClientContext.SecurityParameters;
		ProtocolVersion[] protocolVersions = m_tlsClient.GetProtocolVersions();
		if (ProtocolVersion.Contains(protocolVersions, ProtocolVersion.SSLv3))
		{
			m_recordStream.SetWriteVersion(ProtocolVersion.SSLv3);
		}
		else
		{
			m_recordStream.SetWriteVersion(ProtocolVersion.TLSv10);
		}
		ProtocolVersion earliestTls = ProtocolVersion.GetEarliestTls(protocolVersions);
		ProtocolVersion latestTls = ProtocolVersion.GetLatestTls(protocolVersions);
		if (!ProtocolVersion.IsSupportedTlsVersionClient(latestTls))
		{
			throw new TlsFatalAlert(80);
		}
		m_tlsClientContext.SetClientVersion(latestTls);
		m_tlsClientContext.SetClientSupportedVersions(protocolVersions);
		bool flag = ProtocolVersion.TLSv12.IsEqualOrLaterVersionOf(earliestTls);
		bool flag2 = ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(latestTls);
		EstablishSession(flag ? m_tlsClient.GetSessionToResume() : null);
		m_tlsClient.NotifySessionToResume(m_tlsSession);
		byte[] array = TlsUtilities.GetSessionID(m_tlsSession);
		bool num = m_tlsClient.IsFallback();
		int[] array2 = m_tlsClient.GetCipherSuites();
		if (array.Length != 0 && m_sessionParameters != null && !Arrays.Contains(array2, m_sessionParameters.CipherSuite))
		{
			array = TlsUtilities.EmptyBytes;
		}
		m_clientExtensions = TlsExtensionsUtilities.EnsureExtensionsInitialised(m_tlsClient.GetClientExtensions());
		ProtocolVersion protocolVersion = latestTls;
		if (flag2)
		{
			protocolVersion = ProtocolVersion.TLSv12;
			TlsExtensionsUtilities.AddSupportedVersionsExtensionClient(m_clientExtensions, protocolVersions);
			if (array.Length < 1)
			{
				array = m_tlsClientContext.NonceGenerator.GenerateNonce(32);
			}
		}
		m_tlsClientContext.SetRsaPreMasterSecretVersion(protocolVersion);
		securityParameters.m_clientServerNames = TlsExtensionsUtilities.GetServerNameExtensionClient(m_clientExtensions);
		if (TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(latestTls))
		{
			TlsUtilities.EstablishClientSigAlgs(securityParameters, m_clientExtensions);
		}
		securityParameters.m_clientSupportedGroups = TlsExtensionsUtilities.GetSupportedGroupsExtension(m_clientExtensions);
		m_clientBinders = TlsUtilities.AddPreSharedKeyToClientHello(m_tlsClientContext, m_tlsClient, m_clientExtensions, array2);
		m_clientAgreements = TlsUtilities.AddKeyShareToClientHello(m_tlsClientContext, m_tlsClient, m_clientExtensions);
		if (TlsUtilities.IsExtendedMasterSecretOptionalTls(protocolVersions) && (m_tlsClient.ShouldUseExtendedMasterSecret() || (m_sessionParameters != null && m_sessionParameters.IsExtendedMasterSecret)))
		{
			TlsExtensionsUtilities.AddExtendedMasterSecretExtension(m_clientExtensions);
		}
		else if (!flag2 && m_tlsClient.RequiresExtendedMasterSecret())
		{
			throw new TlsFatalAlert(80);
		}
		bool useGmtUnixTime = !flag2 && m_tlsClient.ShouldUseGmtUnixTime();
		securityParameters.m_clientRandom = TlsProtocol.CreateRandomBlock(useGmtUnixTime, m_tlsClientContext);
		if ((TlsUtilities.GetExtensionData(m_clientExtensions, 65281) == null) & !Arrays.Contains(array2, 255))
		{
			array2 = Arrays.Append(array2, 255);
		}
		if (num && !Arrays.Contains(array2, 22016))
		{
			array2 = Arrays.Append(array2, 22016);
		}
		int bindersSize = ((m_clientBinders != null) ? m_clientBinders.m_bindersSize : 0);
		m_clientHello = new ClientHello(protocolVersion, securityParameters.ClientRandom, array, null, array2, m_clientExtensions, bindersSize);
		SendClientHelloMessage();
	}

	protected virtual void SendClientHelloMessage()
	{
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(1);
		m_clientHello.Encode(m_tlsClientContext, handshakeMessageOutput);
		handshakeMessageOutput.PrepareClientHello(m_handshakeHash, m_clientHello.BindersSize);
		if (m_clientBinders != null)
		{
			OfferedPsks.EncodeBinders(handshakeMessageOutput, m_tlsClientContext.Crypto, m_handshakeHash, m_clientBinders);
		}
		handshakeMessageOutput.SendClientHello(this, m_handshakeHash, m_clientHello.BindersSize);
	}

	protected virtual void SendClientKeyExchange()
	{
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(16);
		m_keyExchange.GenerateClientKeyExchange(handshakeMessageOutput);
		handshakeMessageOutput.Send(this);
	}

	protected virtual void Skip13CertificateRequest()
	{
		m_certificateRequest = null;
	}

	protected virtual void Skip13ServerCertificate()
	{
		if (!m_selectedPsk13)
		{
			throw new TlsFatalAlert(10);
		}
		m_authentication = TlsUtilities.Skip13ServerCertificate(m_tlsClientContext);
	}
}
