namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsSigner
{
	byte[] GenerateRawSignature(SignatureAndHashAlgorithm algorithm, byte[] hash);

	TlsStreamSigner GetStreamSigner(SignatureAndHashAlgorithm algorithm);
}
