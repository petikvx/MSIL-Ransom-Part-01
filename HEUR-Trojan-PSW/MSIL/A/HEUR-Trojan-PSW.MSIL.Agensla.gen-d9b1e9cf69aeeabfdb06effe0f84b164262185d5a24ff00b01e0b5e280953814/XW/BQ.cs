using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace XW;

public static class BQ
{
	[CompilerGenerated]
	private sealed class YW4<jWU>
	{
		public int Bah;

		internal static object iqz;

		public YW4()
		{
			G3.nJ(G3.By);
			base._002Ector();
		}

		internal int Sas(pL<int, jWU> x)
		{
			return x.XW() / Bah;
		}

		internal static bool Cfy()
		{
			return iqz == null;
		}

		internal static object Yfq()
		{
			return iqz;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class OWG<OWI>
	{
		public static readonly OWG<OWI> VaU;

		public static Func<OWI, int, pL<int, OWI>> AaG;

		public static Func<pL<int, OWI>, OWI> HaI;

		public static Func<IGrouping<int, pL<int, OWI>>, IEnumerable<OWI>> Ra1;

		private static object Lff;

		static OWG()
		{
			G3.nJ(G3.By);
			VaU = new OWG<OWI>();
		}

		public OWG()
		{
			G3.nJ(G3.By);
			base._002Ector();
		}

		internal pL<int, OWI> BaH(OWI x, int i)
		{
			return new pL<int, OWI>(i, x);
		}

		internal IEnumerable<OWI> Oav(IGrouping<int, pL<int, OWI>> x)
		{
			return x.Select((pL<int, OWI> v) => v.Value);
		}

		internal OWI Ja4(pL<int, OWI> v)
		{
			return v.Value;
		}

		internal static bool pfM()
		{
			return Lff == null;
		}

		internal static object rfd()
		{
			return Lff;
		}
	}

	public static IEnumerable<YN> xLK<YN>(this IEnumerable<YN> ienumerable_0)
	{
		int num = 0;
		if (_003COrderRandomly_003Ed__0<YN>.kq2() != null)
		{
			goto IL_0051;
		}
		goto IL_0055;
		IL_0055:
		Random random = default(Random);
		List<YN> copy = default(List<YN>);
		int index = default(int);
		do
		{
			switch (num)
			{
			case 2:
			{
				int num2;
				if (num2 != 1)
				{
					yield break;
				}
				goto IL_002c;
			}
			default:
				random = new Random();
				copy = ienumerable_0.ToList();
				goto case 1;
			case 1:
				if (copy.Count <= 0)
				{
					yield break;
				}
				index = KtX.nJ(random, copy.Count, KtX.Qtc);
				break;
			case 3:
				break;
			}
			yield return copy[index];
			goto IL_002c;
			IL_002c:
			copy.RemoveAt(index);
			num = 1;
		}
		while (_003COrderRandomly_003Ed__0<YN>.kq2() == null);
		goto IL_0051;
		IL_0051:
		int num3 = default(int);
		num = num3;
		goto IL_0055;
	}

	public static IEnumerable<IEnumerable<em>> ULT<em>(this IEnumerable<em> ienumerable_0, int int_0)
	{
		YW4<em> CS_0024_003C_003E8__locals0 = new YW4<em>();
		CS_0024_003C_003E8__locals0.Bah = int_0;
		return from x in ienumerable_0.Select((em x, int i) => new pL<int, em>(i, x))
			group x by x.XW() / CS_0024_003C_003E8__locals0.Bah into x
			select from v in x
				select v.Value;
	}
}
