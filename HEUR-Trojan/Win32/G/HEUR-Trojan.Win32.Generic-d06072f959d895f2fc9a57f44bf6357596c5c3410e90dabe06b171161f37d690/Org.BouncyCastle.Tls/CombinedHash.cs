using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class CombinedHash : TlsHash
{
	protected readonly TlsContext m_context;

	protected readonly TlsCrypto m_crypto;

	protected readonly TlsHash m_md5;

	protected readonly TlsHash m_sha1;

	internal CombinedHash(TlsContext context, TlsHash md5, TlsHash sha1)
	{
		m_context = context;
		m_crypto = context.Crypto;
		m_md5 = md5;
		m_sha1 = sha1;
	}

	public CombinedHash(TlsCrypto crypto)
	{
		m_crypto = crypto;
		m_md5 = crypto.CreateHash(1);
		m_sha1 = crypto.CreateHash(2);
	}

	public CombinedHash(CombinedHash t)
	{
		m_context = t.m_context;
		m_crypto = t.m_crypto;
		m_md5 = t.m_md5.CloneHash();
		m_sha1 = t.m_sha1.CloneHash();
	}

	public virtual void Update(byte[] input, int inOff, int len)
	{
		m_md5.Update(input, inOff, len);
		m_sha1.Update(input, inOff, len);
	}

	public virtual byte[] CalculateHash()
	{
		if (m_context != null && TlsUtilities.IsSsl(m_context))
		{
			Ssl3Utilities.CompleteCombinedHash(m_context, m_md5, m_sha1);
		}
		return Arrays.Concatenate(m_md5.CalculateHash(), m_sha1.CalculateHash());
	}

	public virtual TlsHash CloneHash()
	{
		return new CombinedHash(this);
	}

	public virtual void Reset()
	{
		m_md5.Reset();
		m_sha1.Reset();
	}
}
