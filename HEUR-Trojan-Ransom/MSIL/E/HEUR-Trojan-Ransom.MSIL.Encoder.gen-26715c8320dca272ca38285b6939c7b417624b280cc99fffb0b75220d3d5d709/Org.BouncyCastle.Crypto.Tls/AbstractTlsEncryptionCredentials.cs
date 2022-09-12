namespace Org.BouncyCastle.Crypto.Tls;

public abstract class AbstractTlsEncryptionCredentials : AbstractTlsCredentials, TlsCredentials, TlsEncryptionCredentials
{
	public abstract byte[] DecryptPreMasterSecret(byte[] encryptedPreMasterSecret);
}
