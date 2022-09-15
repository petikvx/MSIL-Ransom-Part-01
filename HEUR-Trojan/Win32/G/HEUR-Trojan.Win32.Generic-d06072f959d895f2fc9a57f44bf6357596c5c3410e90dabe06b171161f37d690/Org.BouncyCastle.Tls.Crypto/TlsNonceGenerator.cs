namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsNonceGenerator
{
	byte[] GenerateNonce(int size);
}
