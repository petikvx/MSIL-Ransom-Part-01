using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls;

public class TlsDHKeyExchange : AbstractTlsKeyExchange
{
	protected TlsSigner mTlsSigner;

	protected TlsDHVerifier mDHVerifier;

	protected DHParameters mDHParameters;

	protected AsymmetricKeyParameter mServerPublicKey;

	protected TlsAgreementCredentials mAgreementCredentials;

	protected DHPrivateKeyParameters mDHAgreePrivateKey;

	protected DHPublicKeyParameters mDHAgreePublicKey;

	public override bool RequiresServerKeyExchange
	{
		get
		{
			int num = mKeyExchange;
			if (num != 3 && num != 5 && num != 11)
			{
				return false;
			}
			return true;
		}
	}

	[Obsolete("Use constructor that takes a TlsDHVerifier")]
	public TlsDHKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, DHParameters dhParameters)
		: this(keyExchange, supportedSignatureAlgorithms, new DefaultTlsDHVerifier(), dhParameters)
	{
	}

	public TlsDHKeyExchange(int keyExchange, IList supportedSignatureAlgorithms, TlsDHVerifier dhVerifier, DHParameters dhParameters)
		: base(keyExchange, supportedSignatureAlgorithms)
	{
		switch (keyExchange)
		{
		case 3:
			mTlsSigner = new TlsDssSigner();
			break;
		case 5:
			mTlsSigner = new TlsRsaSigner();
			break;
		default:
			throw new InvalidOperationException("unsupported key exchange algorithm");
		case 7:
		case 9:
		case 11:
			mTlsSigner = null;
			break;
		}
		mDHVerifier = dhVerifier;
		mDHParameters = dhParameters;
	}

	public override void Init(TlsContext context)
	{
		base.Init(context);
		if (mTlsSigner != null)
		{
			mTlsSigner.Init(context);
		}
	}

	public override void SkipServerCredentials()
	{
		if (mKeyExchange != 11)
		{
			throw new TlsFatalAlert(10);
		}
	}

	public override void ProcessServerCertificate(Certificate serverCertificate)
	{
		if (mKeyExchange == 11)
		{
			throw new TlsFatalAlert(10);
		}
		if (serverCertificate.IsEmpty)
		{
			throw new TlsFatalAlert(50);
		}
		X509CertificateStructure certificateAt = serverCertificate.GetCertificateAt(0);
		SubjectPublicKeyInfo subjectPublicKeyInfo = certificateAt.SubjectPublicKeyInfo;
		try
		{
			mServerPublicKey = PublicKeyFactory.CreateKey(subjectPublicKeyInfo);
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(43, alertCause);
		}
		if (mTlsSigner == null)
		{
			try
			{
				mDHAgreePublicKey = (DHPublicKeyParameters)mServerPublicKey;
				mDHParameters = mDHAgreePublicKey.Parameters;
			}
			catch (InvalidCastException alertCause2)
			{
				throw new TlsFatalAlert(46, alertCause2);
			}
			TlsUtilities.ValidateKeyUsage(certificateAt, 8);
		}
		else
		{
			if (!mTlsSigner.IsValidPublicKey(mServerPublicKey))
			{
				throw new TlsFatalAlert(46);
			}
			TlsUtilities.ValidateKeyUsage(certificateAt, 128);
		}
		base.ProcessServerCertificate(serverCertificate);
	}

	public override byte[] GenerateServerKeyExchange()
	{
		if (!RequiresServerKeyExchange)
		{
			return null;
		}
		MemoryStream memoryStream = new MemoryStream();
		mDHAgreePrivateKey = TlsDHUtilities.GenerateEphemeralServerKeyExchange(mContext.SecureRandom, mDHParameters, memoryStream);
		return memoryStream.ToArray();
	}

	public override void ProcessServerKeyExchange(Stream input)
	{
		if (!RequiresServerKeyExchange)
		{
			throw new TlsFatalAlert(10);
		}
		mDHParameters = TlsDHUtilities.ReceiveDHParameters(mDHVerifier, input);
		mDHAgreePublicKey = new DHPublicKeyParameters(TlsDHUtilities.ReadDHParameter(input), mDHParameters);
	}

	public override void ValidateCertificateRequest(CertificateRequest certificateRequest)
	{
		if (mKeyExchange == 11)
		{
			throw new TlsFatalAlert(40);
		}
		byte[] certificateTypes = certificateRequest.CertificateTypes;
		int num = 0;
		while (true)
		{
			if (num < certificateTypes.Length)
			{
				byte b = certificateTypes[num];
				if ((uint)(b - 1) > 3u && b != 64)
				{
					break;
				}
				num++;
				continue;
			}
			return;
		}
		throw new TlsFatalAlert(47);
	}

	public override void ProcessClientCredentials(TlsCredentials clientCredentials)
	{
		if (mKeyExchange == 11)
		{
			throw new TlsFatalAlert(80);
		}
		if (clientCredentials is TlsAgreementCredentials)
		{
			mAgreementCredentials = (TlsAgreementCredentials)clientCredentials;
		}
		else if (!(clientCredentials is TlsSignerCredentials))
		{
			throw new TlsFatalAlert(80);
		}
	}

	public override void GenerateClientKeyExchange(Stream output)
	{
		if (mAgreementCredentials == null)
		{
			mDHAgreePrivateKey = TlsDHUtilities.GenerateEphemeralClientKeyExchange(mContext.SecureRandom, mDHParameters, output);
		}
	}

	public override void ProcessClientCertificate(Certificate clientCertificate)
	{
		if (mKeyExchange == 11)
		{
			throw new TlsFatalAlert(10);
		}
	}

	public override void ProcessClientKeyExchange(Stream input)
	{
		if (mDHAgreePublicKey == null)
		{
			mDHAgreePublicKey = new DHPublicKeyParameters(TlsDHUtilities.ReadDHParameter(input), mDHParameters);
		}
	}

	public override byte[] GeneratePremasterSecret()
	{
		if (mAgreementCredentials != null)
		{
			return mAgreementCredentials.GenerateAgreement(mDHAgreePublicKey);
		}
		if (mDHAgreePrivateKey == null)
		{
			throw new TlsFatalAlert(80);
		}
		return TlsDHUtilities.CalculateDHBasicAgreement(mDHAgreePublicKey, mDHAgreePrivateKey);
	}
}
