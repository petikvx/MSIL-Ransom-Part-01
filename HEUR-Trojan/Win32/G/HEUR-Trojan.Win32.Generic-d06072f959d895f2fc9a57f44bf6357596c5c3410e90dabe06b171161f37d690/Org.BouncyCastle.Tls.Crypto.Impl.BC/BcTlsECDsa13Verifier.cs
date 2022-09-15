using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsECDsa13Verifier : BcTlsVerifier
{
	private readonly int m_signatureScheme;

	public BcTlsECDsa13Verifier(BcTlsCrypto crypto, ECPublicKeyParameters publicKey, int signatureScheme)
		: base(crypto, publicKey)
	{
		if (!SignatureScheme.IsECDsa(signatureScheme))
		{
			throw new ArgumentException("signatureScheme");
		}
		m_signatureScheme = signatureScheme;
	}

	public override bool VerifyRawSignature(DigitallySigned signature, byte[] hash)
	{
		SignatureAndHashAlgorithm algorithm = signature.Algorithm;
		if (algorithm == null || SignatureScheme.From(algorithm) != m_signatureScheme)
		{
			throw new InvalidOperationException("Invalid algorithm: " + algorithm);
		}
		int cryptoHashAlgorithm = SignatureScheme.GetCryptoHashAlgorithm(m_signatureScheme);
		DsaDigestSigner dsaDigestSigner = new DsaDigestSigner(new ECDsaSigner(new HMacDsaKCalculator(m_crypto.CreateDigest(cryptoHashAlgorithm))), new NullDigest());
		((ISigner)dsaDigestSigner).Init(forSigning: false, (ICipherParameters)m_publicKey);
		((ISigner)dsaDigestSigner).BlockUpdate(hash, 0, hash.Length);
		return ((ISigner)dsaDigestSigner).VerifySignature(signature.Signature);
	}
}
