namespace Org.BouncyCastle.Tls;

public interface TlsSrpIdentityManager
{
	TlsSrpLoginParameters GetLoginParameters(byte[] identity);
}
