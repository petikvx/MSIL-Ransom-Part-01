using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcDefaultTlsCredentialedAgreement : TlsCredentialedAgreement, TlsCredentials
{
	private sealed class DHCredentialedAgreement : TlsCredentialedAgreement, TlsCredentials
	{
		private readonly BcTlsCrypto m_crypto;

		private readonly Certificate m_certificate;

		private readonly DHPrivateKeyParameters m_privateKey;

		public Certificate Certificate => m_certificate;

		internal DHCredentialedAgreement(BcTlsCrypto crypto, Certificate certificate, DHPrivateKeyParameters privateKey)
		{
			m_crypto = crypto;
			m_certificate = certificate;
			m_privateKey = privateKey;
		}

		public TlsSecret GenerateAgreement(TlsCertificate peerCertificate)
		{
			DHPublicKeyParameters pubKeyDH = BcTlsCertificate.Convert(m_crypto, peerCertificate).GetPubKeyDH();
			return BcTlsDHDomain.CalculateDHAgreement(m_crypto, m_privateKey, pubKeyDH, padded: false);
		}
	}

	private sealed class ECCredentialedAgreement : TlsCredentialedAgreement, TlsCredentials
	{
		private readonly BcTlsCrypto m_crypto;

		private readonly Certificate m_certificate;

		private readonly ECPrivateKeyParameters m_privateKey;

		public Certificate Certificate => m_certificate;

		internal ECCredentialedAgreement(BcTlsCrypto crypto, Certificate certificate, ECPrivateKeyParameters privateKey)
		{
			m_crypto = crypto;
			m_certificate = certificate;
			m_privateKey = privateKey;
		}

		public TlsSecret GenerateAgreement(TlsCertificate peerCertificate)
		{
			ECPublicKeyParameters pubKeyEC = BcTlsCertificate.Convert(m_crypto, peerCertificate).GetPubKeyEC();
			return BcTlsECDomain.CalculateBasicAgreement(m_crypto, m_privateKey, pubKeyEC);
		}
	}

	protected readonly TlsCredentialedAgreement m_agreementCredentials;

	public virtual Certificate Certificate => m_agreementCredentials.Certificate;

	public BcDefaultTlsCredentialedAgreement(BcTlsCrypto crypto, Certificate certificate, AsymmetricKeyParameter privateKey)
	{
		if (crypto == null)
		{
			throw new ArgumentNullException("crypto");
		}
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (certificate.IsEmpty)
		{
			throw new ArgumentException("cannot be empty", "certificate");
		}
		if (privateKey == null)
		{
			throw new ArgumentNullException("privateKey");
		}
		if (!privateKey.IsPrivate)
		{
			throw new ArgumentException("must be private", "privateKey");
		}
		if (privateKey is DHPrivateKeyParameters)
		{
			m_agreementCredentials = new DHCredentialedAgreement(crypto, certificate, (DHPrivateKeyParameters)privateKey);
			return;
		}
		if (!(privateKey is ECPrivateKeyParameters))
		{
			throw new ArgumentException("'privateKey' type not supported: " + Platform.GetTypeName(privateKey));
		}
		m_agreementCredentials = new ECCredentialedAgreement(crypto, certificate, (ECPrivateKeyParameters)privateKey);
	}

	public virtual TlsSecret GenerateAgreement(TlsCertificate peerCertificate)
	{
		return m_agreementCredentials.GenerateAgreement(peerCertificate);
	}
}
