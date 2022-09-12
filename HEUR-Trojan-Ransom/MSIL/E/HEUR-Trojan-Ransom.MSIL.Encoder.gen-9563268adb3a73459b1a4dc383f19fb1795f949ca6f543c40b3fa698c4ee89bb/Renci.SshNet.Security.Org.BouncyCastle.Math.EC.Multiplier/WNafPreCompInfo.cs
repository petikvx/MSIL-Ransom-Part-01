namespace Renci.SshNet.Security.Org.BouncyCastle.Math.EC.Multiplier;

internal class WNafPreCompInfo : PreCompInfo
{
	protected ECPoint[] m_preComp;

	protected ECPoint[] m_preCompNeg;

	protected ECPoint m_twice;

	public virtual ECPoint[] PreComp
	{
		get
		{
			return m_preComp;
		}
		set
		{
			m_preComp = value;
		}
	}

	public virtual ECPoint[] PreCompNeg
	{
		get
		{
			return m_preCompNeg;
		}
		set
		{
			m_preCompNeg = value;
		}
	}

	public virtual ECPoint Twice
	{
		get
		{
			return m_twice;
		}
		set
		{
			m_twice = value;
		}
	}
}
