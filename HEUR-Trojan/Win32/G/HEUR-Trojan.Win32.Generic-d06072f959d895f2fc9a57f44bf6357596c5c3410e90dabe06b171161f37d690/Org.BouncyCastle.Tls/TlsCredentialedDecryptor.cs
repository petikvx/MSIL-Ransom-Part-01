using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public interface TlsCredentialedDecryptor : TlsCredentials
{
	TlsSecret Decrypt(TlsCryptoParameters cryptoParams, byte[] ciphertext);
}
