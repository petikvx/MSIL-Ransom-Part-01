using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsEd25519Signer : BcTlsSigner
{
	public BcTlsEd25519Signer(BcTlsCrypto crypto, Ed25519PrivateKeyParameters privateKey)
		: base(crypto, privateKey)
	{
	}

	public override byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, byte[] hash)
	{
		throw new NotSupportedException();
	}

	public override TlsStreamSigner GetStreamSigner(SignatureAndHashAlgorithm algorithm)
	{
		if (algorithm == null || SignatureScheme.From(algorithm) != 2055)
		{
			throw new InvalidOperationException("Invalid algorithm: " + algorithm);
		}
		Ed25519Signer ed25519Signer = new Ed25519Signer();
		ed25519Signer.Init(forSigning: true, m_privateKey);
		return new BcTlsStreamSigner(ed25519Signer);
	}
}
