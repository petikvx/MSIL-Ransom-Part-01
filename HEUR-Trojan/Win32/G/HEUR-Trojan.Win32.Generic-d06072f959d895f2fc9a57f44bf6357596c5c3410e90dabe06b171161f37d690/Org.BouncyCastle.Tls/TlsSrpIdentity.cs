namespace Org.BouncyCastle.Tls;

public interface TlsSrpIdentity
{
	byte[] GetSrpIdentity();

	byte[] GetSrpPassword();
}
