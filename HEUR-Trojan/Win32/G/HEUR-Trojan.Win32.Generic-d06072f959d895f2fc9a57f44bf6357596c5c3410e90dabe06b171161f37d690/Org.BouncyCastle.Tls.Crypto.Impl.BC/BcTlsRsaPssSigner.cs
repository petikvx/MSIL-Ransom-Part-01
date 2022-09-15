using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsRsaPssSigner : BcTlsSigner
{
	private readonly int m_signatureScheme;

	public BcTlsRsaPssSigner(BcTlsCrypto crypto, RsaKeyParameters privateKey, int signatureScheme)
		: base(crypto, privateKey)
	{
		if (!SignatureScheme.IsRsaPss(signatureScheme))
		{
			throw new ArgumentException("signatureScheme");
		}
		m_signatureScheme = signatureScheme;
	}

	public override byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, byte[] hash)
	{
		throw new NotSupportedException();
	}

	public override TlsStreamSigner GetStreamSigner(SignatureAndHashAlgorithm algorithm)
	{
		if (algorithm == null || SignatureScheme.From(algorithm) != m_signatureScheme)
		{
			throw new InvalidOperationException("Invalid algorithm: " + algorithm);
		}
		int cryptoHashAlgorithm = SignatureScheme.GetCryptoHashAlgorithm(m_signatureScheme);
		IDigest digest = m_crypto.CreateDigest(cryptoHashAlgorithm);
		PssSigner pssSigner = new PssSigner(new RsaBlindedEngine(), digest, digest.GetDigestSize());
		pssSigner.Init(forSigning: true, new ParametersWithRandom(m_privateKey, m_crypto.SecureRandom));
		return new BcTlsStreamSigner(pssSigner);
	}
}
