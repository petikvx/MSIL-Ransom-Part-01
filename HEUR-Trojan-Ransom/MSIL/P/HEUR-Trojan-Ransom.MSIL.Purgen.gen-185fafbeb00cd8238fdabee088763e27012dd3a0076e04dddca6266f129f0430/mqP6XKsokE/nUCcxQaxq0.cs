using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace mqP6XKsokE;

internal static class nUCcxQaxq0
{
	[CompilerGenerated]
	private sealed class IrDb3IXnxd<TKey, TValue>
	{
		public EqualityComparer<TValue> Sfcfx9JTGJ;

		internal bool zcEh3ILucR(TValue ulcz2tJZPj, TValue IZccZvudSc)
		{
			return this.comparer.Equals(ulcz2tJZPj, IZccZvudSc);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class aRHKYmtNty<TKey, TValue>
	{
		public static readonly aRHKYmtNty<TKey, TValue> mzUGreWNcG;

		public static Func<TKey, TKey> DvqnkKJkcO;

		static aRHKYmtNty()
		{
			aRHKYmtNty<TKey, TValue>._003C_003E9 = new aRHKYmtNty<TKey, TValue>();
		}

		internal TKey U1dl0O8y0x(TKey Eahm9ScUlq)
		{
			return Eahm9ScUlq;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class M6mKsoE0Up<TKey, TValue>
	{
		public static readonly M6mKsoE0Up<TKey, TValue> k4BUDt2hIO;

		public static Func<IEnumerable<TValue>, IEnumerable<TValue>, bool> msvurPnwC1;

		static M6mKsoE0Up()
		{
			M6mKsoE0Up<TKey, TValue>._003C_003E9 = new M6mKsoE0Up<TKey, TValue>();
		}

		internal bool H4cNahVitH(IEnumerable<TValue> IOzBUPBIYt, IEnumerable<TValue> T3TzGhMh9X)
		{
			return IOzBUPBIYt.zs2G3OwvOJ(T3TzGhMh9X);
		}
	}

	internal static bool iztWaFQYjU<TSource, TKey>(this IEnumerable<TSource> TR9u40Hh80, IEnumerable<TSource> aSJnZCn9nQ, Func<TSource, TKey> TnTeELRpKV, IComparer<TKey> XXP3wwGNjF = null, IEqualityComparer<TSource> AZLpqgD8I3 = null)
	{
		if (CIc2oLaEyb(TR9u40Hh80, aSJnZCn9nQ, out var kET3xLFrN))
		{
			return kET3xLFrN;
		}
		return TR9u40Hh80.OrderBy(TnTeELRpKV, XXP3wwGNjF).SequenceEqual(aSJnZCn9nQ.OrderBy(TnTeELRpKV, XXP3wwGNjF), AZLpqgD8I3);
	}

	internal static bool zs2G3OwvOJ<T>(this IEnumerable<T> c7uoZarw89, IEnumerable<T> _9AeIadIOso, IEqualityComparer<T> _8P71h5YEhB = null)
	{
		if (CIc2oLaEyb(c7uoZarw89, _9AeIadIOso, out var kET3xLFrN))
		{
			return kET3xLFrN;
		}
		if (_8P71h5YEhB == null)
		{
			_8P71h5YEhB = EqualityComparer<T>.Default;
		}
		return c7uoZarw89.SequenceEqual(_9AeIadIOso, _8P71h5YEhB);
	}

	internal static bool sFhfxcesDP<T>(this ISet<T> _2TNCar3uKn, ISet<T> _1p3Y500fiY, IEqualityComparer<T> s0WJl1yiKd = null)
	{
		if (CIc2oLaEyb(_2TNCar3uKn, _1p3Y500fiY, out var kET3xLFrN))
		{
			return kET3xLFrN;
		}
		if (_2TNCar3uKn.Count != _1p3Y500fiY.Count)
		{
			return false;
		}
		if (s0WJl1yiKd == null)
		{
			s0WJl1yiKd = EqualityComparer<T>.Default;
		}
		return new HashSet<T>(_2TNCar3uKn, s0WJl1yiKd).SetEquals(_1p3Y500fiY);
	}

	internal static bool _163YzAvgIc<TKey, TValue>(IDictionary<TKey, TValue> GCXhShtGNe, IDictionary<TKey, TValue> xJ1IGY70Eo, Func<TValue, TValue, bool> bvPd9uba9S = null)
	{
		IrDb3IXnxd<TKey, TValue> irDb3IXnxd = new IrDb3IXnxd<TKey, TValue>();
		irDb3IXnxd.comparer = EqualityComparer<TValue>.Default;
		Func<TValue, TValue, bool> func = irDb3IXnxd._003CDictionaryEquals_003Eb__0;
		bvPd9uba9S = bvPd9uba9S ?? func;
		if (CIc2oLaEyb(GCXhShtGNe, xJ1IGY70Eo, out var kET3xLFrN))
		{
			return kET3xLFrN;
		}
		if (GCXhShtGNe.Count != xJ1IGY70Eo.Count)
		{
			return false;
		}
		if (!GCXhShtGNe.Keys.iztWaFQYjU(xJ1IGY70Eo.Keys, aRHKYmtNty<TKey, TValue>._003C_003E9__3_1 ?? (aRHKYmtNty<TKey, TValue>._003C_003E9__3_1 = aRHKYmtNty<TKey, TValue>._003C_003E9._003CDictionaryEquals_003Eb__3_1), Comparer<TKey>.Default, EqualityComparer<TKey>.Default))
		{
			return false;
		}
		foreach (TKey key in GCXhShtGNe.Keys)
		{
			if (!bvPd9uba9S(GCXhShtGNe[key], xJ1IGY70Eo[key]))
			{
				return false;
			}
		}
		return true;
	}

	internal static bool gVWE1aCD4D<TKey, TValue>(IDictionary<TKey, IEnumerable<TValue>> AQtDzaKPgn, IDictionary<TKey, IEnumerable<TValue>> GVU5HROkCK)
	{
		return _163YzAvgIc(AQtDzaKPgn, GVU5HROkCK, M6mKsoE0Up<TKey, TValue>._003C_003E9__4_0 ?? (M6mKsoE0Up<TKey, TValue>._003C_003E9__4_0 = M6mKsoE0Up<TKey, TValue>._003C_003E9._003CDictionaryOfSequenceEquals_003Eb__4_0));
	}

	internal static bool mxnSy6PJAM<T>(T _3h0rKf2OlB, T jZ9M9eSBcx)
	{
		if (CIc2oLaEyb(_3h0rKf2OlB, jZ9M9eSBcx, out var kET3xLFrN))
		{
			return kET3xLFrN;
		}
		return _3h0rKf2OlB.Equals(jZ9M9eSBcx);
	}

	private static bool CIc2oLaEyb<T>(T UDYu3IEbK6, T QGwUK2ggaU, out bool kET3xLFrN1)
	{
		if ((object)UDYu3IEbK6 == (object)QGwUK2ggaU)
		{
			kET3xLFrN1 = true;
			return true;
		}
		if (UDYu3IEbK6 == null || QGwUK2ggaU == null)
		{
			kET3xLFrN1 = false;
			return true;
		}
		kET3xLFrN1 = false;
		return false;
	}
}
