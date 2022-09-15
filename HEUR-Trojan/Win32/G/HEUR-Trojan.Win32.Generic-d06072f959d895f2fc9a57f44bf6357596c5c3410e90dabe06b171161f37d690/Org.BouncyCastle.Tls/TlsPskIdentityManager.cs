namespace Org.BouncyCastle.Tls;

public interface TlsPskIdentityManager
{
	byte[] GetHint();

	byte[] GetPsk(byte[] identity);
}
