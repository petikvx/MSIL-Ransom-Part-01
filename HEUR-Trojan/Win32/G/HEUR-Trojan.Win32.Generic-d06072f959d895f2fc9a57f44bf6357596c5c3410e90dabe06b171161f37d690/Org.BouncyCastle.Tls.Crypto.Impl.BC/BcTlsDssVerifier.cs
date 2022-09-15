using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public abstract class BcTlsDssVerifier : BcTlsVerifier
{
	protected abstract short SignatureAlgorithm { get; }

	protected BcTlsDssVerifier(BcTlsCrypto crypto, AsymmetricKeyParameter publicKey)
		: base(crypto, publicKey)
	{
	}

	protected abstract IDsa CreateDsaImpl(int cryptoHashAlgorithm);

	public override bool VerifyRawSignature(DigitallySigned signedParams, byte[] hash)
	{
		SignatureAndHashAlgorithm algorithm = signedParams.Algorithm;
		if (algorithm != null && algorithm.Signature != SignatureAlgorithm)
		{
			throw new InvalidOperationException("Invalid algorithm: " + algorithm);
		}
		int cryptoHashAlgorithm = ((algorithm == null) ? 2 : TlsCryptoUtilities.GetHash(algorithm.Hash));
		ISigner signer = new DsaDigestSigner(CreateDsaImpl(cryptoHashAlgorithm), new NullDigest());
		signer.Init(forSigning: false, m_publicKey);
		if (algorithm == null)
		{
			signer.BlockUpdate(hash, 16, 20);
		}
		else
		{
			signer.BlockUpdate(hash, 0, hash.Length);
		}
		return signer.VerifySignature(signedParams.Signature);
	}
}
