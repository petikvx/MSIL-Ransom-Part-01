namespace Org.BouncyCastle.Tls.Crypto;

public class TlsECConfig
{
	protected readonly int m_namedGroup;

	public virtual int NamedGroup => m_namedGroup;

	public TlsECConfig(int namedGroup)
	{
		m_namedGroup = namedGroup;
	}
}
