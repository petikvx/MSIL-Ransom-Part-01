using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NuGet.Common;

public abstract class KqOHfPFXv6 : ILogger
{
	[CompilerGenerated]
	private HVe4ZaB2Yt _4WqFkai4OS;

	public HVe4ZaB2Yt _8A3RHpn6ya
	{
		[CompilerGenerated]
		get
		{
			return _4WqFkai4OS;
		}
		[CompilerGenerated]
		set
		{
			_4WqFkai4OS = value;
		}
	}

	public KqOHfPFXv6()
	{
	}

	public KqOHfPFXv6(HVe4ZaB2Yt verbosityLevel)
	{
		_8A3RHpn6ya = verbosityLevel;
	}

	public abstract void xHo4JpSHQ1(ILogMessage a1bdzuUZaU);

	public abstract Task P9pB7ztBTL(ILogMessage SvW3aidoKS);

	public virtual void tqYQ87nacT(HVe4ZaB2Yt D1LwBVuolR, string KvJZ6c4BkO)
	{
		if (DisplayMessage(D1LwBVuolR))
		{
			xHo4JpSHQ1(new coTQJabLMP(D1LwBVuolR, KvJZ6c4BkO));
		}
	}

	public virtual Task eTYfRjOcFo(HVe4ZaB2Yt _4cpD037ayL, string bLWIdhUWcZ)
	{
		if (DisplayMessage(_4cpD037ayL))
		{
			return P9pB7ztBTL(new coTQJabLMP(_4cpD037ayL, bLWIdhUWcZ));
		}
		return Task.FromResult(result: true);
	}

	public virtual void IFcCtaXS0B(string QPro0P5Ebs)
	{
		tqYQ87nacT(HVe4ZaB2Yt.Debug, QPro0P5Ebs);
	}

	public virtual void WItAbZCpxw(string HtKsWJ0AdJ)
	{
		tqYQ87nacT(HVe4ZaB2Yt.Error, HtKsWJ0AdJ);
	}

	public virtual void DdWyo9zgoB(string _3qBqkvXXZB)
	{
		tqYQ87nacT(HVe4ZaB2Yt.Information, _3qBqkvXXZB);
	}

	public virtual void OBku3sLfSZ(string dbkjLtGeS9)
	{
		tqYQ87nacT(HVe4ZaB2Yt.Information, dbkjLtGeS9);
	}

	public virtual void QhP8Gq8KGu(string w6hdx4TxiL)
	{
		tqYQ87nacT(HVe4ZaB2Yt.Minimal, w6hdx4TxiL);
	}

	public virtual void gpbxBdUINX(string tgEe0ShXXD)
	{
		tqYQ87nacT(HVe4ZaB2Yt.Verbose, tgEe0ShXXD);
	}

	public virtual void wQb3Embg1Z(string gXemWDf29E)
	{
		tqYQ87nacT(HVe4ZaB2Yt.Warning, gXemWDf29E);
	}

	protected virtual bool DisplayMessage(HVe4ZaB2Yt messageLevel)
	{
		return messageLevel >= _8A3RHpn6ya;
	}

	protected virtual bool CollectMessage(HVe4ZaB2Yt messageLevel)
	{
		return messageLevel >= HVe4ZaB2Yt.Warning;
	}
}
