namespace Org.BouncyCastle.Tls.Crypto;

public class TlsDHConfig
{
	protected readonly DHGroup m_explicitGroup;

	protected readonly int m_namedGroup;

	protected readonly bool m_padded;

	public virtual DHGroup ExplicitGroup => m_explicitGroup;

	public virtual int NamedGroup => m_namedGroup;

	public virtual bool IsPadded => m_padded;

	public TlsDHConfig(DHGroup explicitGroup)
	{
		m_explicitGroup = explicitGroup;
		m_namedGroup = -1;
		m_padded = false;
	}

	public TlsDHConfig(int namedGroup, bool padded)
	{
		m_explicitGroup = null;
		m_namedGroup = namedGroup;
		m_padded = padded;
	}
}
