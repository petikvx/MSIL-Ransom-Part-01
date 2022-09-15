namespace Org.BouncyCastle.Tls;

public abstract class ClientAuthenticationType
{
	public const short anonymous = 0;

	public const short certificate_based = 1;

	public const short psk = 2;
}
