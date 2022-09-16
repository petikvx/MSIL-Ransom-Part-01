using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace XW;

public class KWa
{
	[Serializable]
	[CompilerGenerated]
	private sealed class bW1
	{
		public static readonly bW1 baJ;

		public static Func<string, bool> Ba9;

		private static bW1 afY;

		static bW1()
		{
			G3.nJ(G3.By);
			baJ = new bW1();
		}

		public bW1()
		{
			G3.nJ(G3.By);
			base._002Ector();
		}

		internal bool Ua5(string m)
		{
			return !FXs.nJ(m, FXs.iXV);
		}

		internal static bool gfZ()
		{
			return afY == null;
		}

		internal static bW1 WfL()
		{
			return afY;
		}
	}

	private static KWa lqg;

	public static IEnumerable<int> Li0()
	{
		int i = 1;
		if (i < 32)
		{
			yield return i;
			/*Error: Unable to find 'return true' for yield return*/;
		}
	}

	public static IEnumerable<KeyValuePair<string, int>> Hil()
	{
		//yield-return decompiler failed: Unexpected instruction in Iterator.Dispose()
		return new _003CMonthsOfYear_003Ed__1(-2);
	}

	public static IEnumerable<int> Iid(int int_0, int int_1)
	{
		DateTime dateTime_ = XyV.nJ(XyV.Jy6);
		int thisYear = suA.nJ(ref dateTime_, suA.Uuv);
		int num = 2;
		if (_003CAgeYearSpanRange_003Ed__2.PfF() != null)
		{
			goto IL_0095;
		}
		goto IL_00cd;
		IL_00cd:
		int lowerYear = default(int);
		int i = default(int);
		int upperYear = default(int);
		switch (num)
		{
		case 3:
			lowerYear = thisYear - (int_1 + 1);
			i = upperYear - 1;
			break;
		case 1:
			break;
		case 2:
			upperYear = thisYear - (int_0 - 1);
			goto case 3;
		default:
			goto IL_00e5;
		}
		goto IL_0095;
		IL_00e5:
		bool flag = default(bool);
		if (!flag)
		{
			yield break;
		}
		yield return i;
		i--;
		num = 1;
		if (!_003CAgeYearSpanRange_003Ed__2.ffQ())
		{
			goto IL_0095;
		}
		goto IL_00cd;
		IL_0095:
		flag = i >= lowerYear;
		num = 0;
		if (_003CAgeYearSpanRange_003Ed__2.PfF() == null)
		{
			goto IL_00cd;
		}
		goto IL_00e5;
	}

	public KWa()
	{
		G3.nJ(G3.By);
		base._002Ector();
	}

	internal static bool DqI()
	{
		return lqg == null;
	}

	internal static KWa NqS()
	{
		return lqg;
	}
}
