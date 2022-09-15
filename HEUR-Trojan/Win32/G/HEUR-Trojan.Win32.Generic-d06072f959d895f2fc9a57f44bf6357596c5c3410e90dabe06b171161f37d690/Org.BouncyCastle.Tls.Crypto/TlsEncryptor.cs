namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsEncryptor
{
	byte[] Encrypt(byte[] input, int inOff, int length);
}
