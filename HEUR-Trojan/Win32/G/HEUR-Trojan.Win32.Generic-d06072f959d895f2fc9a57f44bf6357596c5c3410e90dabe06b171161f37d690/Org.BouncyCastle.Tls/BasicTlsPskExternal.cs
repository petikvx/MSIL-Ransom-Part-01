using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class BasicTlsPskExternal : TlsPsk, TlsPskExternal
{
	protected readonly byte[] m_identity;

	protected readonly TlsSecret m_key;

	protected readonly int m_prfAlgorithm;

	public virtual byte[] Identity => m_identity;

	public virtual TlsSecret Key => m_key;

	public virtual int PrfAlgorithm => m_prfAlgorithm;

	public BasicTlsPskExternal(byte[] identity, TlsSecret key)
		: this(identity, key, 4)
	{
	}

	public BasicTlsPskExternal(byte[] identity, TlsSecret key, int prfAlgorithm)
	{
		m_identity = Arrays.Clone(identity);
		m_key = key;
		m_prfAlgorithm = prfAlgorithm;
	}
}
