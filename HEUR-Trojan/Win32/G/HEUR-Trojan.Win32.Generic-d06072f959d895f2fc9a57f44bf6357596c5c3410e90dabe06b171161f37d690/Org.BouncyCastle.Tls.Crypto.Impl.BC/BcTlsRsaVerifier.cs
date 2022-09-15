using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsRsaVerifier : BcTlsVerifier
{
	public BcTlsRsaVerifier(BcTlsCrypto crypto, RsaKeyParameters publicKey)
		: base(crypto, publicKey)
	{
	}

	public override bool VerifyRawSignature(DigitallySigned signedParams, byte[] hash)
	{
		IDigest digest = new NullDigest();
		SignatureAndHashAlgorithm algorithm = signedParams.Algorithm;
		ISigner signer;
		if (algorithm != null)
		{
			if (algorithm.Signature != 1)
			{
				throw new InvalidOperationException("Invalid algorithm: " + algorithm);
			}
			signer = new RsaDigestSigner(digest, TlsUtilities.GetOidForHashAlgorithm(algorithm.Hash));
		}
		else
		{
			signer = new GenericSigner(new Pkcs1Encoding(new RsaBlindedEngine()), digest);
		}
		signer.Init(forSigning: false, m_publicKey);
		signer.BlockUpdate(hash, 0, hash.Length);
		return signer.VerifySignature(signedParams.Signature);
	}
}
