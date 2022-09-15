using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public interface TlsCredentialedSigner : TlsCredentials
{
	SignatureAndHashAlgorithm SignatureAndHashAlgorithm { get; }

	byte[] GenerateRawSignature(byte[] hash);

	TlsStreamSigner GetStreamSigner();
}
