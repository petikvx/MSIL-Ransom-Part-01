using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

public class TlsServerProtocol : TlsProtocol
{
	protected TlsServer mTlsServer;

	internal TlsServerContextImpl mTlsServerContext;

	protected TlsKeyExchange mKeyExchange;

	protected TlsCredentials mServerCredentials;

	protected CertificateRequest mCertificateRequest;

	protected short mClientCertificateType = -1;

	protected TlsHandshakeHash mPrepareFinishHash;

	protected override TlsContext Context => mTlsServerContext;

	internal override AbstractTlsContext ContextAdmin => mTlsServerContext;

	protected override TlsPeer Peer => mTlsServer;

	public TlsServerProtocol(Stream stream, SecureRandom secureRandom)
		: base(stream, secureRandom)
	{
	}

	public TlsServerProtocol(Stream input, Stream output, SecureRandom secureRandom)
		: base(input, output, secureRandom)
	{
	}

	public TlsServerProtocol(SecureRandom secureRandom)
		: base(secureRandom)
	{
	}

	public virtual void Accept(TlsServer tlsServer)
	{
		if (tlsServer == null)
		{
			throw new ArgumentNullException("tlsServer");
		}
		if (mTlsServer != null)
		{
			throw new InvalidOperationException("'Accept' can only be called once");
		}
		mTlsServer = tlsServer;
		mSecurityParameters = new SecurityParameters();
		mSecurityParameters.entity = 0;
		mTlsServerContext = new TlsServerContextImpl(mSecureRandom, mSecurityParameters);
		mSecurityParameters.serverRandom = TlsProtocol.CreateRandomBlock(tlsServer.ShouldUseGmtUnixTime(), mTlsServerContext.NonceRandomGenerator);
		mTlsServer.Init(mTlsServerContext);
		mRecordStream.Init(mTlsServerContext);
		tlsServer.NotifyCloseHandle(this);
		mRecordStream.SetRestrictReadVersion(enabled: false);
		BlockForHandshake();
	}

	protected override void CleanupHandshake()
	{
		base.CleanupHandshake();
		mKeyExchange = null;
		mServerCredentials = null;
		mCertificateRequest = null;
		mPrepareFinishHash = null;
	}

	protected override void HandleHandshakeMessage(byte type, MemoryStream buf)
	{
		switch (type)
		{
		case 1:
			switch (mConnectionState)
			{
			default:
				throw new TlsFatalAlert(10);
			case 16:
				RefuseRenegotiation();
				break;
			case 0:
			{
				ReceiveClientHelloMessage(buf);
				mConnectionState = 1;
				SendServerHelloMessage();
				mConnectionState = 2;
				mRecordStream.NotifyHelloComplete();
				IList serverSupplementalData = mTlsServer.GetServerSupplementalData();
				if (serverSupplementalData != null)
				{
					SendSupplementalDataMessage(serverSupplementalData);
				}
				mConnectionState = 3;
				mKeyExchange = mTlsServer.GetKeyExchange();
				mKeyExchange.Init(Context);
				mServerCredentials = mTlsServer.GetCredentials();
				Certificate certificate = null;
				if (mServerCredentials == null)
				{
					mKeyExchange.SkipServerCredentials();
				}
				else
				{
					mKeyExchange.ProcessServerCredentials(mServerCredentials);
					certificate = mServerCredentials.Certificate;
					SendCertificateMessage(certificate);
				}
				mConnectionState = 4;
				if (certificate == null || certificate.IsEmpty)
				{
					mAllowCertificateStatus = false;
				}
				if (mAllowCertificateStatus)
				{
					CertificateStatus certificateStatus = mTlsServer.GetCertificateStatus();
					if (certificateStatus != null)
					{
						SendCertificateStatusMessage(certificateStatus);
					}
				}
				mConnectionState = 5;
				byte[] array = mKeyExchange.GenerateServerKeyExchange();
				if (array != null)
				{
					SendServerKeyExchangeMessage(array);
				}
				mConnectionState = 6;
				if (mServerCredentials != null)
				{
					mCertificateRequest = mTlsServer.GetCertificateRequest();
					if (mCertificateRequest != null)
					{
						if (TlsUtilities.IsTlsV12(Context) != (mCertificateRequest.SupportedSignatureAlgorithms != null))
						{
							throw new TlsFatalAlert(80);
						}
						mKeyExchange.ValidateCertificateRequest(mCertificateRequest);
						SendCertificateRequestMessage(mCertificateRequest);
						TlsUtilities.TrackHashAlgorithms(mRecordStream.HandshakeHash, mCertificateRequest.SupportedSignatureAlgorithms);
					}
				}
				mConnectionState = 7;
				SendServerHelloDoneMessage();
				mConnectionState = 8;
				mRecordStream.HandshakeHash.SealHashAlgorithms();
				break;
			}
			}
			break;
		case 11:
		{
			short num = mConnectionState;
			if ((uint)(num - 8) <= 1u)
			{
				if (mConnectionState < 9)
				{
					mTlsServer.ProcessClientSupplementalData(null);
				}
				if (mCertificateRequest == null)
				{
					throw new TlsFatalAlert(10);
				}
				ReceiveCertificateMessage(buf);
				mConnectionState = 10;
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 15:
			if (mConnectionState == 11)
			{
				if (!ExpectCertificateVerifyMessage())
				{
					throw new TlsFatalAlert(10);
				}
				ReceiveCertificateVerifyMessage(buf);
				mConnectionState = 12;
				break;
			}
			throw new TlsFatalAlert(10);
		case 16:
		{
			short num = mConnectionState;
			if ((uint)(num - 8) <= 2u)
			{
				if (mConnectionState < 9)
				{
					mTlsServer.ProcessClientSupplementalData(null);
				}
				if (mConnectionState < 10)
				{
					if (mCertificateRequest == null)
					{
						mKeyExchange.SkipClientCredentials();
					}
					else
					{
						if (TlsUtilities.IsTlsV12(Context))
						{
							throw new TlsFatalAlert(10);
						}
						if (TlsUtilities.IsSsl(Context))
						{
							if (mPeerCertificate == null)
							{
								throw new TlsFatalAlert(10);
							}
						}
						else
						{
							NotifyClientCertificate(Certificate.EmptyChain);
						}
					}
				}
				ReceiveClientKeyExchangeMessage(buf);
				mConnectionState = 11;
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 20:
		{
			short num = mConnectionState;
			if ((uint)(num - 11) <= 1u)
			{
				if (mConnectionState < 12 && ExpectCertificateVerifyMessage())
				{
					throw new TlsFatalAlert(10);
				}
				ProcessFinishedMessage(buf);
				mConnectionState = 13;
				if (mExpectSessionTicket)
				{
					SendNewSessionTicketMessage(mTlsServer.GetNewSessionTicket());
				}
				mConnectionState = 14;
				SendChangeCipherSpecMessage();
				SendFinishedMessage();
				mConnectionState = 15;
				CompleteHandshake();
				break;
			}
			throw new TlsFatalAlert(10);
		}
		default:
			throw new TlsFatalAlert(10);
		case 23:
			if (mConnectionState != 8)
			{
				throw new TlsFatalAlert(10);
			}
			mTlsServer.ProcessClientSupplementalData(TlsProtocol.ReadSupplementalDataMessage(buf));
			mConnectionState = 9;
			break;
		}
	}

	protected override void HandleAlertWarningMessage(byte alertDescription)
	{
		if (41 == alertDescription && mCertificateRequest != null && TlsUtilities.IsSsl(mTlsServerContext))
		{
			short num = mConnectionState;
			if ((uint)(num - 8) <= 1u)
			{
				if (mConnectionState < 9)
				{
					mTlsServer.ProcessClientSupplementalData(null);
				}
				NotifyClientCertificate(Certificate.EmptyChain);
				mConnectionState = 10;
				return;
			}
		}
		base.HandleAlertWarningMessage(alertDescription);
	}

	protected virtual void NotifyClientCertificate(Certificate clientCertificate)
	{
		if (mCertificateRequest == null)
		{
			throw new InvalidOperationException();
		}
		if (mPeerCertificate != null)
		{
			throw new TlsFatalAlert(10);
		}
		mPeerCertificate = clientCertificate;
		if (clientCertificate.IsEmpty)
		{
			mKeyExchange.SkipClientCredentials();
		}
		else
		{
			mClientCertificateType = TlsUtilities.GetClientCertificateType(clientCertificate, mServerCredentials.Certificate);
			mKeyExchange.ProcessClientCertificate(clientCertificate);
		}
		mTlsServer.NotifyClientCertificate(clientCertificate);
	}

	protected virtual void ReceiveCertificateMessage(MemoryStream buf)
	{
		Certificate clientCertificate = Certificate.Parse(buf);
		TlsProtocol.AssertEmpty(buf);
		NotifyClientCertificate(clientCertificate);
	}

	protected virtual void ReceiveCertificateVerifyMessage(MemoryStream buf)
	{
		if (mCertificateRequest == null)
		{
			throw new InvalidOperationException();
		}
		DigitallySigned digitallySigned = DigitallySigned.Parse(Context, buf);
		TlsProtocol.AssertEmpty(buf);
		try
		{
			SignatureAndHashAlgorithm algorithm = digitallySigned.Algorithm;
			byte[] hash;
			if (TlsUtilities.IsTlsV12(Context))
			{
				TlsUtilities.VerifySupportedSignatureAlgorithm(mCertificateRequest.SupportedSignatureAlgorithms, algorithm);
				hash = mPrepareFinishHash.GetFinalHash(algorithm.Hash);
			}
			else
			{
				hash = mSecurityParameters.SessionHash;
			}
			AsymmetricKeyParameter publicKey = PublicKeyFactory.CreateKey(mPeerCertificate.GetCertificateAt(0).SubjectPublicKeyInfo);
			TlsSigner tlsSigner = TlsUtilities.CreateTlsSigner((byte)mClientCertificateType);
			tlsSigner.Init(Context);
			if (!tlsSigner.VerifyRawSignature(algorithm, digitallySigned.Signature, publicKey, hash))
			{
				throw new TlsFatalAlert(51);
			}
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			throw tlsFatalAlert;
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(51, alertCause);
		}
	}

	protected virtual void ReceiveClientHelloMessage(MemoryStream buf)
	{
		ProtocolVersion protocolVersion = TlsUtilities.ReadVersion(buf);
		mRecordStream.SetWriteVersion(protocolVersion);
		if (protocolVersion.IsDtls)
		{
			throw new TlsFatalAlert(47);
		}
		byte[] clientRandom = TlsUtilities.ReadFully(32, buf);
		if (TlsUtilities.ReadOpaque8(buf).Length > 32)
		{
			throw new TlsFatalAlert(47);
		}
		int num = TlsUtilities.ReadUint16(buf);
		if (num >= 2 && (num & 1) == 0)
		{
			mOfferedCipherSuites = TlsUtilities.ReadUint16Array(num / 2, buf);
			int num2 = TlsUtilities.ReadUint8(buf);
			if (num2 < 1)
			{
				throw new TlsFatalAlert(47);
			}
			mOfferedCompressionMethods = TlsUtilities.ReadUint8Array(num2, buf);
			mClientExtensions = TlsProtocol.ReadExtensions(buf);
			mSecurityParameters.extendedMasterSecret = TlsExtensionsUtilities.HasExtendedMasterSecretExtension(mClientExtensions);
			if (!mSecurityParameters.IsExtendedMasterSecret && mTlsServer.RequiresExtendedMasterSecret())
			{
				throw new TlsFatalAlert(40);
			}
			ContextAdmin.SetClientVersion(protocolVersion);
			mTlsServer.NotifyClientVersion(protocolVersion);
			mTlsServer.NotifyFallback(Arrays.Contains(mOfferedCipherSuites, 22016));
			mSecurityParameters.clientRandom = clientRandom;
			mTlsServer.NotifyOfferedCipherSuites(mOfferedCipherSuites);
			mTlsServer.NotifyOfferedCompressionMethods(mOfferedCompressionMethods);
			if (Arrays.Contains(mOfferedCipherSuites, 255))
			{
				mSecureRenegotiation = true;
			}
			byte[] extensionData = TlsUtilities.GetExtensionData(mClientExtensions, 65281);
			if (extensionData != null)
			{
				mSecureRenegotiation = true;
				if (!Arrays.ConstantTimeAreEqual(extensionData, TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes)))
				{
					throw new TlsFatalAlert(40);
				}
			}
			mTlsServer.NotifySecureRenegotiation(mSecureRenegotiation);
			if (mClientExtensions != null)
			{
				TlsExtensionsUtilities.GetPaddingExtension(mClientExtensions);
				mTlsServer.ProcessClientExtensions(mClientExtensions);
			}
			return;
		}
		throw new TlsFatalAlert(50);
	}

	protected virtual void ReceiveClientKeyExchangeMessage(MemoryStream buf)
	{
		mKeyExchange.ProcessClientKeyExchange(buf);
		TlsProtocol.AssertEmpty(buf);
		if (TlsUtilities.IsSsl(Context))
		{
			TlsProtocol.EstablishMasterSecret(Context, mKeyExchange);
		}
		mPrepareFinishHash = mRecordStream.PrepareToFinish();
		mSecurityParameters.sessionHash = TlsProtocol.GetCurrentPrfHash(Context, mPrepareFinishHash, null);
		if (!TlsUtilities.IsSsl(Context))
		{
			TlsProtocol.EstablishMasterSecret(Context, mKeyExchange);
		}
		mRecordStream.SetPendingConnectionState(Peer.GetCompression(), Peer.GetCipher());
	}

	protected virtual void SendCertificateRequestMessage(CertificateRequest certificateRequest)
	{
		HandshakeMessage handshakeMessage = new HandshakeMessage(13);
		certificateRequest.Encode(handshakeMessage);
		handshakeMessage.WriteToRecordStream(this);
	}

	protected virtual void SendCertificateStatusMessage(CertificateStatus certificateStatus)
	{
		HandshakeMessage handshakeMessage = new HandshakeMessage(22);
		certificateStatus.Encode(handshakeMessage);
		handshakeMessage.WriteToRecordStream(this);
	}

	protected virtual void SendNewSessionTicketMessage(NewSessionTicket newSessionTicket)
	{
		if (newSessionTicket == null)
		{
			throw new TlsFatalAlert(80);
		}
		HandshakeMessage handshakeMessage = new HandshakeMessage(4);
		newSessionTicket.Encode(handshakeMessage);
		handshakeMessage.WriteToRecordStream(this);
	}

	protected virtual void SendServerHelloMessage()
	{
		HandshakeMessage handshakeMessage = new HandshakeMessage(2);
		ProtocolVersion serverVersion = mTlsServer.GetServerVersion();
		if (!serverVersion.IsEqualOrEarlierVersionOf(Context.ClientVersion))
		{
			throw new TlsFatalAlert(80);
		}
		mRecordStream.ReadVersion = serverVersion;
		mRecordStream.SetWriteVersion(serverVersion);
		mRecordStream.SetRestrictReadVersion(enabled: true);
		ContextAdmin.SetServerVersion(serverVersion);
		TlsUtilities.WriteVersion(serverVersion, handshakeMessage);
		handshakeMessage.Write(mSecurityParameters.serverRandom);
		TlsUtilities.WriteOpaque8(TlsUtilities.EmptyBytes, handshakeMessage);
		int selectedCipherSuite = mTlsServer.GetSelectedCipherSuite();
		if (Arrays.Contains(mOfferedCipherSuites, selectedCipherSuite) && selectedCipherSuite != 0 && !CipherSuite.IsScsv(selectedCipherSuite) && TlsUtilities.IsValidCipherSuiteForVersion(selectedCipherSuite, Context.ServerVersion))
		{
			mSecurityParameters.cipherSuite = selectedCipherSuite;
			byte selectedCompressionMethod = mTlsServer.GetSelectedCompressionMethod();
			if (!Arrays.Contains(mOfferedCompressionMethods, selectedCompressionMethod))
			{
				throw new TlsFatalAlert(80);
			}
			mSecurityParameters.compressionAlgorithm = selectedCompressionMethod;
			TlsUtilities.WriteUint16(selectedCipherSuite, handshakeMessage);
			TlsUtilities.WriteUint8(selectedCompressionMethod, handshakeMessage);
			mServerExtensions = TlsExtensionsUtilities.EnsureExtensionsInitialised(mTlsServer.GetServerExtensions());
			if (mSecureRenegotiation)
			{
				byte[] extensionData = TlsUtilities.GetExtensionData(mServerExtensions, 65281);
				if (extensionData == null)
				{
					mServerExtensions[65281] = TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes);
				}
			}
			if (TlsUtilities.IsSsl(mTlsServerContext))
			{
				mSecurityParameters.extendedMasterSecret = false;
			}
			else if (mSecurityParameters.IsExtendedMasterSecret)
			{
				TlsExtensionsUtilities.AddExtendedMasterSecretExtension(mServerExtensions);
			}
			if (mServerExtensions.Count > 0)
			{
				mSecurityParameters.encryptThenMac = TlsExtensionsUtilities.HasEncryptThenMacExtension(mServerExtensions);
				mSecurityParameters.maxFragmentLength = ProcessMaxFragmentLengthExtension(mClientExtensions, mServerExtensions, 80);
				mSecurityParameters.truncatedHMac = TlsExtensionsUtilities.HasTruncatedHMacExtension(mServerExtensions);
				mAllowCertificateStatus = !mResumedSession && TlsUtilities.HasExpectedEmptyExtensionData(mServerExtensions, 5, 80);
				mExpectSessionTicket = !mResumedSession && TlsUtilities.HasExpectedEmptyExtensionData(mServerExtensions, 35, 80);
				TlsProtocol.WriteExtensions(handshakeMessage, mServerExtensions);
			}
			mSecurityParameters.prfAlgorithm = TlsProtocol.GetPrfAlgorithm(Context, mSecurityParameters.CipherSuite);
			mSecurityParameters.verifyDataLength = 12;
			ApplyMaxFragmentLengthExtension();
			handshakeMessage.WriteToRecordStream(this);
			return;
		}
		throw new TlsFatalAlert(80);
	}

	protected virtual void SendServerHelloDoneMessage()
	{
		byte[] array = new byte[4];
		TlsUtilities.WriteUint8(14, array, 0);
		TlsUtilities.WriteUint24(0, array, 1);
		WriteHandshakeMessage(array, 0, array.Length);
	}

	protected virtual void SendServerKeyExchangeMessage(byte[] serverKeyExchange)
	{
		HandshakeMessage handshakeMessage = new HandshakeMessage(12, serverKeyExchange.Length);
		handshakeMessage.Write(serverKeyExchange);
		handshakeMessage.WriteToRecordStream(this);
	}

	protected virtual bool ExpectCertificateVerifyMessage()
	{
		if (mClientCertificateType >= 0)
		{
			return TlsUtilities.HasSigningCapability((byte)mClientCertificateType);
		}
		return false;
	}
}
