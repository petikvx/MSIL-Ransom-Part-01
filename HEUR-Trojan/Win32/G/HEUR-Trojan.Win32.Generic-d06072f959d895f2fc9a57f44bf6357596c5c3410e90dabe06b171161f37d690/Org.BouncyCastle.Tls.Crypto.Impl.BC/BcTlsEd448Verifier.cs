using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsEd448Verifier : BcTlsVerifier
{
	public BcTlsEd448Verifier(BcTlsCrypto crypto, Ed448PublicKeyParameters publicKey)
		: base(crypto, publicKey)
	{
	}

	public override bool VerifyRawSignature(DigitallySigned signature, byte[] hash)
	{
		throw new NotSupportedException();
	}

	public override TlsStreamVerifier GetStreamVerifier(DigitallySigned signature)
	{
		SignatureAndHashAlgorithm algorithm = signature.Algorithm;
		if (algorithm == null || SignatureScheme.From(algorithm) != 2056)
		{
			throw new InvalidOperationException("Invalid algorithm: " + algorithm);
		}
		Ed448Signer ed448Signer = new Ed448Signer(TlsUtilities.EmptyBytes);
		ed448Signer.Init(forSigning: false, m_publicKey);
		return new BcTlsStreamVerifier(ed448Signer, signature.Signature);
	}
}
