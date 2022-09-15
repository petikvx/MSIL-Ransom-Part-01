using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto;

public class TlsSrpConfig
{
	protected BigInteger[] m_explicitNG;

	public BigInteger[] GetExplicitNG()
	{
		return (BigInteger[])m_explicitNG.Clone();
	}

	public void SetExplicitNG(BigInteger[] explicitNG)
	{
		m_explicitNG = (BigInteger[])explicitNG.Clone();
	}
}
