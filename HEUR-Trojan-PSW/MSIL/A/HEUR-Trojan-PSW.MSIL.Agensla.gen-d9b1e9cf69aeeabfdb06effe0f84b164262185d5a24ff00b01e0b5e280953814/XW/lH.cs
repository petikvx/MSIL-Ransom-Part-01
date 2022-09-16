using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace XW;

public class lH<lv> : IComparer<lv>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool rC;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string cB;

	private PropertyInfo jo;

	internal static object bE;

	public lH(bool bool_0, string string_0)
	{
		G3.nJ(G3.By);
		base._002Ector();
		Gp(bool_0);
		Qe(string_0);
	}

	public int Compare(lv tG, lv VI)
	{
		if (Am.nJ(jo, null, Am.l1))
		{
			jo = FJ();
		}
		string text = pj.nJ(jo, tG, null, pj.h8) as string;
		string text2 = pj.nJ(jo, VI, null, pj.h8) as string;
		if (text == null || text2 == null)
		{
			return 0;
		}
		return wT.nJ(text, text2, wT.X5) * (E9() ? 1 : (-1));
	}

	[SpecialName]
	[CompilerGenerated]
	private bool E9()
	{
		return rC;
	}

	[SpecialName]
	[CompilerGenerated]
	private void Gp(bool bool_0)
	{
		rC = bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private string Ru()
	{
		return cB;
	}

	[SpecialName]
	[CompilerGenerated]
	private void Qe(string string_0)
	{
		cB = string_0;
	}

	private PropertyInfo FJ()
	{
		Type object_ = aG.nJ(typeof(lv).TypeHandle, aG.ta);
		return QA.nJ(object_, Ru(), QA.Hv);
	}

	internal static bool rT()
	{
		return bE == null;
	}

	internal static object Gl()
	{
		return bE;
	}
}
