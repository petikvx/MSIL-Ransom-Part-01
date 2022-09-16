using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Web;

namespace XW;

public class VWt<nWD> : IDisposable, YWs<nWD> where nWD : class
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string Ia7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TimeSpan kaj;

	private static object wq3;

	public VWt(string string_0, TimeSpan timeSpan_0)
	{
		G3.nJ(G3.By);
		base._002Ector();
		oOp(string_0);
		cat(timeSpan_0);
	}

	[SpecialName]
	[CompilerGenerated]
	public string iOd()
	{
		return Ia7;
	}

	[SpecialName]
	[CompilerGenerated]
	public void oOp(string string_0)
	{
		Ia7 = string_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public TimeSpan waS()
	{
		return kaj;
	}

	[SpecialName]
	[CompilerGenerated]
	public void cat(TimeSpan timeSpan_0)
	{
		kaj = timeSpan_0;
	}

	public void tOn(nWD dWj)
	{
		if (dWj != null)
		{
			Guid? guid = yaF(iOd());
			if (!guid.HasValue)
			{
				guid = vP6.nJ(vP6.iPF);
				Ma2(iOd(), guid.Value);
			}
			JPN.nJ(aPx.nJ(RcT.nJ(RcT.fc5), aPx.yPR), guid.ToString(), dWj, null, DateTime.MaxValue, waS(), JPN.SPW);
		}
	}

	[SpecialName]
	public nWD SOl()
	{
		object obj = o3E.nJ(string_0: yaF(iOd()).ToString(), object_0: aPx.nJ(RcT.nJ(RcT.fc5), aPx.yPR), o3E_0: o3E.lPi);
		return obj as nWD;
	}

	public void Dispose()
	{
		LP5.nJ(TP8.nJ(fPU.nJ(RcT.nJ(RcT.fc5), fPU.jPj), TP8.RPT), iOd(), LP5.xPl);
	}

	private Guid? yaF(string string_0)
	{
		HttpCookie val = JPL.nJ(TP8.nJ(Lcl.nJ(RcT.nJ(RcT.fc5), Lcl.qcC), TP8.EPC), string_0, JPL.WP2);
		return (val == null) ? null : new Guid?(new Guid(lcz.nJ(val, lcz.dPS)));
	}

	private void Ma2(string string_0, Guid guid_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		HttpCookie httpCookie_ = new HttpCookie(string_0, guid_0.ToString());
		JPz.nJ(TP8.nJ(fPU.nJ(RcT.nJ(RcT.fc5), fPU.jPj), TP8.RPT), httpCookie_, JPz.ztO);
	}

	internal static bool SqO()
	{
		return wq3 == null;
	}

	internal static object wqt()
	{
		return wq3;
	}
}
