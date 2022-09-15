using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class BasicTlsSrpIdentity : TlsSrpIdentity
{
	protected readonly byte[] m_identity;

	protected readonly byte[] m_password;

	public BasicTlsSrpIdentity(byte[] identity, byte[] password)
	{
		m_identity = Arrays.Clone(identity);
		m_password = Arrays.Clone(password);
	}

	public BasicTlsSrpIdentity(string identity, string password)
	{
		m_identity = Strings.ToUtf8ByteArray(identity);
		m_password = Strings.ToUtf8ByteArray(password);
	}

	public virtual byte[] GetSrpIdentity()
	{
		return m_identity;
	}

	public virtual byte[] GetSrpPassword()
	{
		return m_password;
	}
}
