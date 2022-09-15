using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsCertificate : TlsCertificate
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly X509CertificateStructure m_certificate;

	protected DHPublicKeyParameters m_pubKeyDH;

	protected ECPublicKeyParameters m_pubKeyEC;

	protected Ed25519PublicKeyParameters m_pubKeyEd25519;

	protected Ed448PublicKeyParameters m_pubKeyEd448;

	protected RsaKeyParameters m_pubKeyRsa;

	public virtual BigInteger SerialNumber => m_certificate.SerialNumber.Value;

	public virtual string SigAlgOid => m_certificate.SignatureAlgorithm.Algorithm.Id;

	public static BcTlsCertificate Convert(BcTlsCrypto crypto, TlsCertificate certificate)
	{
		if (certificate is BcTlsCertificate)
		{
			return (BcTlsCertificate)certificate;
		}
		return new BcTlsCertificate(crypto, certificate.GetEncoded());
	}

	public static X509CertificateStructure ParseCertificate(byte[] encoding)
	{
		try
		{
			return X509CertificateStructure.GetInstance(encoding);
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(42, alertCause);
		}
	}

	public BcTlsCertificate(BcTlsCrypto crypto, byte[] encoding)
		: this(crypto, ParseCertificate(encoding))
	{
	}

	public BcTlsCertificate(BcTlsCrypto crypto, X509CertificateStructure certificate)
	{
		m_crypto = crypto;
		m_certificate = certificate;
	}

	public virtual TlsEncryptor CreateEncryptor(int tlsCertificateRole)
	{
		ValidateKeyUsage(32);
		if (tlsCertificateRole != 3)
		{
			throw new TlsFatalAlert(46);
		}
		m_pubKeyRsa = GetPubKeyRsa();
		return new BcTlsRsaEncryptor(m_crypto, m_pubKeyRsa);
	}

	public virtual TlsVerifier CreateVerifier(short signatureAlgorithm)
	{
		if ((uint)(signatureAlgorithm - 4) <= 7u)
		{
			return CreateVerifier(SignatureScheme.From(8, signatureAlgorithm));
		}
		ValidateKeyUsage(128);
		switch (signatureAlgorithm)
		{
		default:
			throw new TlsFatalAlert(46);
		case 1:
			ValidateRsa_Pkcs1();
			return new BcTlsRsaVerifier(m_crypto, GetPubKeyRsa());
		case 2:
			return new BcTlsDsaVerifier(m_crypto, GetPubKeyDss());
		case 3:
			return new BcTlsECDsaVerifier(m_crypto, GetPubKeyEC());
		}
	}

	public virtual TlsVerifier CreateVerifier(int signatureScheme)
	{
		ValidateKeyUsage(128);
		switch (signatureScheme)
		{
		case 513:
		case 1025:
		case 1281:
		case 1537:
			ValidateRsa_Pkcs1();
			return new BcTlsRsaVerifier(m_crypto, GetPubKeyRsa());
		default:
			throw new TlsFatalAlert(46);
		case 2052:
		case 2053:
		case 2054:
			ValidateRsa_Pss_Rsae();
			return new BcTlsRsaPssVerifier(m_crypto, GetPubKeyRsa(), signatureScheme);
		case 2055:
			return new BcTlsEd25519Verifier(m_crypto, GetPubKeyEd25519());
		case 2056:
			return new BcTlsEd448Verifier(m_crypto, GetPubKeyEd448());
		case 2057:
		case 2058:
		case 2059:
			ValidateRsa_Pss_Pss(SignatureScheme.GetSignatureAlgorithm(signatureScheme));
			return new BcTlsRsaPssVerifier(m_crypto, GetPubKeyRsa(), signatureScheme);
		case 515:
		case 1027:
		case 1283:
		case 1539:
		case 2074:
		case 2075:
		case 2076:
			return new BcTlsECDsa13Verifier(m_crypto, GetPubKeyEC(), signatureScheme);
		}
	}

	public virtual byte[] GetEncoded()
	{
		return m_certificate.GetEncoded("DER");
	}

	public virtual byte[] GetExtension(DerObjectIdentifier extensionOid)
	{
		X509Extensions extensions = m_certificate.TbsCertificate.Extensions;
		if (extensions != null)
		{
			X509Extension extension = extensions.GetExtension(extensionOid);
			if (extension != null)
			{
				return Arrays.Clone(extension.Value.GetOctets());
			}
		}
		return null;
	}

	public virtual Asn1Encodable GetSigAlgParams()
	{
		return m_certificate.SignatureAlgorithm.Parameters;
	}

	public virtual short GetLegacySignatureAlgorithm()
	{
		AsymmetricKeyParameter publicKey = GetPublicKey();
		if (publicKey.IsPrivate)
		{
			throw new TlsFatalAlert(80);
		}
		if (!SupportsKeyUsage(128))
		{
			return -1;
		}
		if (publicKey is RsaKeyParameters)
		{
			return 1;
		}
		if (publicKey is DsaPublicKeyParameters)
		{
			return 2;
		}
		if (publicKey is ECPublicKeyParameters)
		{
			return 3;
		}
		return -1;
	}

	public virtual DHPublicKeyParameters GetPubKeyDH()
	{
		try
		{
			return (DHPublicKeyParameters)GetPublicKey();
		}
		catch (InvalidCastException alertCause)
		{
			throw new TlsFatalAlert(46, alertCause);
		}
	}

	public virtual DsaPublicKeyParameters GetPubKeyDss()
	{
		try
		{
			return (DsaPublicKeyParameters)GetPublicKey();
		}
		catch (InvalidCastException alertCause)
		{
			throw new TlsFatalAlert(46, alertCause);
		}
	}

	public virtual ECPublicKeyParameters GetPubKeyEC()
	{
		try
		{
			return (ECPublicKeyParameters)GetPublicKey();
		}
		catch (InvalidCastException alertCause)
		{
			throw new TlsFatalAlert(46, alertCause);
		}
	}

	public virtual Ed25519PublicKeyParameters GetPubKeyEd25519()
	{
		try
		{
			return (Ed25519PublicKeyParameters)GetPublicKey();
		}
		catch (InvalidCastException alertCause)
		{
			throw new TlsFatalAlert(46, alertCause);
		}
	}

	public virtual Ed448PublicKeyParameters GetPubKeyEd448()
	{
		try
		{
			return (Ed448PublicKeyParameters)GetPublicKey();
		}
		catch (InvalidCastException alertCause)
		{
			throw new TlsFatalAlert(46, alertCause);
		}
	}

	public virtual RsaKeyParameters GetPubKeyRsa()
	{
		try
		{
			return (RsaKeyParameters)GetPublicKey();
		}
		catch (InvalidCastException alertCause)
		{
			throw new TlsFatalAlert(46, alertCause);
		}
	}

	public virtual bool SupportsSignatureAlgorithm(short signatureAlgorithm)
	{
		return SupportsSignatureAlgorithm(signatureAlgorithm, 128);
	}

	public virtual bool SupportsSignatureAlgorithmCA(short signatureAlgorithm)
	{
		return SupportsSignatureAlgorithm(signatureAlgorithm, 4);
	}

	public virtual TlsCertificate CheckUsageInRole(int tlsCertificateRole)
	{
		switch (tlsCertificateRole)
		{
		default:
			throw new TlsFatalAlert(46);
		case 2:
			ValidateKeyUsage(8);
			m_pubKeyEC = GetPubKeyEC();
			return this;
		case 1:
			ValidateKeyUsage(8);
			m_pubKeyDH = GetPubKeyDH();
			return this;
		}
	}

	protected virtual AsymmetricKeyParameter GetPublicKey()
	{
		SubjectPublicKeyInfo subjectPublicKeyInfo = m_certificate.SubjectPublicKeyInfo;
		try
		{
			return PublicKeyFactory.CreateKey(subjectPublicKeyInfo);
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(43, alertCause);
		}
	}

	protected virtual bool SupportsKeyUsage(int keyUsageBits)
	{
		X509Extensions extensions = m_certificate.TbsCertificate.Extensions;
		if (extensions != null)
		{
			KeyUsage keyUsage = KeyUsage.FromExtensions(extensions);
			if (keyUsage != null && (keyUsage.GetBytes()[0] & 0xFF & keyUsageBits) != keyUsageBits)
			{
				return false;
			}
		}
		return true;
	}

	protected virtual bool SupportsRsa_Pkcs1()
	{
		return RsaUtilities.SupportsPkcs1(m_certificate.SubjectPublicKeyInfo.AlgorithmID);
	}

	protected virtual bool SupportsRsa_Pss_Pss(short signatureAlgorithm)
	{
		AlgorithmIdentifier algorithmID = m_certificate.SubjectPublicKeyInfo.AlgorithmID;
		return RsaUtilities.SupportsPss_Pss(signatureAlgorithm, algorithmID);
	}

	protected virtual bool SupportsRsa_Pss_Rsae()
	{
		return RsaUtilities.SupportsPss_Rsae(m_certificate.SubjectPublicKeyInfo.AlgorithmID);
	}

	protected virtual bool SupportsSignatureAlgorithm(short signatureAlgorithm, int keyUsage)
	{
		if (!SupportsKeyUsage(keyUsage))
		{
			return false;
		}
		AsymmetricKeyParameter publicKey = GetPublicKey();
		switch (signatureAlgorithm)
		{
		default:
			return false;
		case 1:
			if (SupportsRsa_Pkcs1())
			{
				return publicKey is RsaKeyParameters;
			}
			return false;
		case 2:
			return publicKey is DsaPublicKeyParameters;
		case 3:
		case 26:
		case 27:
		case 28:
			return publicKey is ECPublicKeyParameters;
		case 4:
		case 5:
		case 6:
			if (SupportsRsa_Pss_Rsae())
			{
				return publicKey is RsaKeyParameters;
			}
			return false;
		case 7:
			return publicKey is Ed25519PublicKeyParameters;
		case 8:
			return publicKey is Ed448PublicKeyParameters;
		case 9:
		case 10:
		case 11:
			if (SupportsRsa_Pss_Pss(signatureAlgorithm))
			{
				return publicKey is RsaKeyParameters;
			}
			return false;
		}
	}

	public virtual void ValidateKeyUsage(int keyUsageBits)
	{
		if (!SupportsKeyUsage(keyUsageBits))
		{
			throw new TlsFatalAlert(46);
		}
	}

	protected virtual void ValidateRsa_Pkcs1()
	{
		if (!SupportsRsa_Pkcs1())
		{
			throw new TlsFatalAlert(46);
		}
	}

	protected virtual void ValidateRsa_Pss_Pss(short signatureAlgorithm)
	{
		if (!SupportsRsa_Pss_Pss(signatureAlgorithm))
		{
			throw new TlsFatalAlert(46);
		}
	}

	protected virtual void ValidateRsa_Pss_Rsae()
	{
		if (!SupportsRsa_Pss_Rsae())
		{
			throw new TlsFatalAlert(46);
		}
	}
}
