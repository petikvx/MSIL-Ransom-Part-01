using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NuGet.Common;

public static class sdmik2HK4m
{
	[Serializable]
	[CompilerGenerated]
	private sealed class dmzjurqFOS
	{
		public static readonly dmzjurqFOS _8ZXtWfLapS = new dmzjurqFOS();

		public static Func<string, string> _9uBovhiTsU;

		public static Func<string, bool> UzgE3uDzah;

		public static Func<string, string> SkG7ZRmx56;

		public static Func<string, bool> k1iyjrWA0i;

		internal string xcZKE5PCqq(string MbckHGhxCW)
		{
			return MbckHGhxCW.Trim();
		}

		internal bool _4owgaaPcfq(string wE7jkX1q02)
		{
			return wE7jkX1q02.Length != 0;
		}

		internal string Ky70bOlfHi(string UyhD7rndUz)
		{
			return fqchqeAaZL(UyhD7rndUz);
		}

		internal bool Ol97gewGun(string QMF77WYZ8o)
		{
			return QMF77WYZ8o != null;
		}
	}

	public static string[] hodggMkJNG(string _3KbSR0597j)
	{
		return aiapJp7Z5i(_3KbSR0597j, ';');
	}

	public static string[] aiapJp7Z5i(string hC0z79ZSR1, params char[] _3TGQQI6iiM)
	{
		if (!string.IsNullOrEmpty(hC0z79ZSR1))
		{
			return (from MbckHGhxCW in hC0z79ZSR1.Split(_3TGQQI6iiM)
				select MbckHGhxCW.Trim() into wE7jkX1q02
				where wE7jkX1q02.Length != 0
				select wE7jkX1q02).ToArray();
		}
		return Array.Empty<string>();
	}

	public static string fqchqeAaZL(string _7Pg0zLPMPq)
	{
		if (_7Pg0zLPMPq == null)
		{
			return null;
		}
		_7Pg0zLPMPq = _7Pg0zLPMPq.Trim();
		if (_7Pg0zLPMPq.Length != 0)
		{
			return _7Pg0zLPMPq;
		}
		return null;
	}

	public static string[] dXNtbf30lh(string[] _9bPUncBlJe)
	{
		if (_9bPUncBlJe == null)
		{
			return Array.Empty<string>();
		}
		return (from UyhD7rndUz in _9bPUncBlJe
			select fqchqeAaZL(UyhD7rndUz) into QMF77WYZ8o
			where QMF77WYZ8o != null
			select QMF77WYZ8o).ToArray();
	}

	public static bool VtVessvzic(string AydUeYjnmB)
	{
		return bool.TrueString.Equals(fqchqeAaZL(AydUeYjnmB), StringComparison.OrdinalIgnoreCase);
	}

	public static bool vEmx5wKVp9(string CSYSAaaG9b)
	{
		if (fqchqeAaZL(CSYSAaaG9b) != null)
		{
			return VtVessvzic(CSYSAaaG9b);
		}
		return true;
	}

	[IteratorStateMachine(typeof(_003CGetNuGetLogCodes_003Ed__6))]
	public static IEnumerable<VMQYogJRDb> Sz6asavxzk(string jZ3zysg3Ik)
	{
		//yield-return decompiler failed: Method not found
		return new YxSmllZWvI(-2)
		{
			_3j4wjruWiT = jZ3zysg3Ik
		};
	}

	public static string dVfdcItXTg(string AfDVecIxpQ)
	{
		return AfDVecIxpQ?.Replace(',', ';');
	}

	public static IEnumerable<VMQYogJRDb> mMKOuGhalt(IEnumerable<IEnumerable<VMQYogJRDb>> _8F5JWd3fMI)
	{
		if (_8F5JWd3fMI.Count() > 0)
		{
			IEnumerable<VMQYogJRDb> enumerable = Enumerable.Empty<VMQYogJRDb>();
			bool flag = true;
			foreach (IEnumerable<VMQYogJRDb> item in _8F5JWd3fMI)
			{
				if (flag)
				{
					enumerable = item;
					flag = false;
				}
				else if (enumerable == null || item == null || enumerable.Count() != item.Count() || !enumerable.All((Func<VMQYogJRDb, bool>)item.Contains))
				{
					return Enumerable.Empty<VMQYogJRDb>();
				}
			}
			return enumerable ?? Enumerable.Empty<VMQYogJRDb>();
		}
		return Enumerable.Empty<VMQYogJRDb>();
	}
}
