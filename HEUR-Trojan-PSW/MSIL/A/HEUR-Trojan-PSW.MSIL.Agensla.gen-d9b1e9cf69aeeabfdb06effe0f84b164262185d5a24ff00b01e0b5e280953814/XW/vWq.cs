using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace XW;

public static class vWq
{
	[Serializable]
	[CompilerGenerated]
	private sealed class kW5
	{
		public static readonly kW5 aau;

		public static Func<int, string> Jae;

		public static Func<int, string> MaA;

		private static kW5 Df7;

		static kW5()
		{
			G3.nJ(G3.By);
			aau = new kW5();
		}

		public kW5()
		{
			G3.nJ(G3.By);
			base._002Ector();
		}

		internal string yap(int x)
		{
			return gtd.nJ(ref x, "00", gtd.EtQ);
		}

		internal string RaZ(int x)
		{
			return gtd.nJ(ref x, "00", gtd.EtQ);
		}

		internal static bool DfV()
		{
			return Df7 == null;
		}

		internal static kW5 qfE()
		{
			return Df7;
		}
	}

	[SpecialName]
	public static IEnumerable<string> RiV()
	{
		TimeSpan timeSpan_ = new TimeSpan(1, 0, 0, 0);
		return from x in RuC.nJ(0, (int)ccM.nJ(ref timeSpan_, ccM.ycI), RuC.GuL)
			select gtd.nJ(ref x, "00", gtd.EtQ);
	}

	[SpecialName]
	public static IEnumerable<string> NiO()
	{
		TimeSpan timeSpan_ = new TimeSpan(0, 1, 0, 0);
		return from x in RuC.nJ(0, (int)ccM.nJ(ref timeSpan_, ccM.Iu2), RuC.GuL)
			select gtd.nJ(ref x, "00", gtd.EtQ);
	}
}
