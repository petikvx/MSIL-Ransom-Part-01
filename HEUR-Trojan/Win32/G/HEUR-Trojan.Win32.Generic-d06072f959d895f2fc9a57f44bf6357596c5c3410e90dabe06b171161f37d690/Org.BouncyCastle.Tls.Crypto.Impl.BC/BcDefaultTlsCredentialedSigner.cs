using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcDefaultTlsCredentialedSigner : DefaultTlsCredentialedSigner
{
	private static BcTlsCertificate GetEndEntity(BcTlsCrypto crypto, Certificate certificate)
	{
		if (certificate == null || certificate.IsEmpty)
		{
			throw new ArgumentException("No certificate");
		}
		return BcTlsCertificate.Convert(crypto, certificate.GetCertificateAt(0));
	}

	private static TlsSigner MakeSigner(BcTlsCrypto crypto, AsymmetricKeyParameter privateKey, Certificate certificate, SignatureAndHashAlgorithm signatureAndHashAlgorithm)
	{
		if (privateKey is RsaKeyParameters)
		{
			RsaKeyParameters privateKey2 = (RsaKeyParameters)privateKey;
			if (signatureAndHashAlgorithm != null)
			{
				int signatureScheme = SignatureScheme.From(signatureAndHashAlgorithm);
				if (SignatureScheme.IsRsaPss(signatureScheme))
				{
					return new BcTlsRsaPssSigner(crypto, privateKey2, signatureScheme);
				}
			}
			RsaKeyParameters pubKeyRsa = GetEndEntity(crypto, certificate).GetPubKeyRsa();
			return new BcTlsRsaSigner(crypto, privateKey2, pubKeyRsa);
		}
		if (privateKey is DsaPrivateKeyParameters)
		{
			return new BcTlsDsaSigner(crypto, (DsaPrivateKeyParameters)privateKey);
		}
		if (privateKey is ECPrivateKeyParameters)
		{
			ECPrivateKeyParameters privateKey3 = (ECPrivateKeyParameters)privateKey;
			if (signatureAndHashAlgorithm != null)
			{
				int signatureScheme2 = SignatureScheme.From(signatureAndHashAlgorithm);
				if (SignatureScheme.IsECDsa(signatureScheme2))
				{
					return new BcTlsECDsa13Signer(crypto, privateKey3, signatureScheme2);
				}
			}
			return new BcTlsECDsaSigner(crypto, privateKey3);
		}
		if (privateKey is Ed25519PrivateKeyParameters)
		{
			return new BcTlsEd25519Signer(crypto, (Ed25519PrivateKeyParameters)privateKey);
		}
		if (privateKey is Ed448PrivateKeyParameters)
		{
			return new BcTlsEd448Signer(crypto, (Ed448PrivateKeyParameters)privateKey);
		}
		throw new ArgumentException("'privateKey' type not supported: " + Platform.GetTypeName(privateKey));
	}

	public BcDefaultTlsCredentialedSigner(TlsCryptoParameters cryptoParams, BcTlsCrypto crypto, AsymmetricKeyParameter privateKey, Certificate certificate, SignatureAndHashAlgorithm signatureAndHashAlgorithm)
		: base(cryptoParams, MakeSigner(crypto, privateKey, certificate, signatureAndHashAlgorithm), certificate, signatureAndHashAlgorithm)
	{
	}
}
