namespace Renci.SshNet.Security.Org.BouncyCastle.Math.EC.Multiplier;

internal class WTauNafPreCompInfo : PreCompInfo
{
	protected AbstractF2mPoint[] m_preComp;

	public virtual AbstractF2mPoint[] PreComp
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
}
