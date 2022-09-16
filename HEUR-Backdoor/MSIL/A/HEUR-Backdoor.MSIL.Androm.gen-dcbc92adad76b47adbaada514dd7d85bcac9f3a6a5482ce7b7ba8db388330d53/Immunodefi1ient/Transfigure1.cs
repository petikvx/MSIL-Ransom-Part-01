using System;
using System.Collections.Generic;
using System.Linq;

namespace Immunodefi1ient;

internal static class Transfigure1
{
	internal static bool Se44ied<TSource, TKey>(this IEnumerable<TSource> Column4as, IEnumerable<TSource> Neu1ally, Func<TSource, TKey> Freigh8, IComparer<TKey> Over5id = null, IEqualityComparer<TSource> St2matitides = null)
	{
		if (Ph5oem(Column4as, Neu1ally, out var S2rink))
		{
			return S2rink;
		}
		return Column4as.OrderBy(Freigh8, Over5id).SequenceEqual(Neu1ally.OrderBy(Freigh8, Over5id), St2matitides);
	}

	internal static bool Decoupage2<T>(this IEnumerable<T> Ph3nom3nas, IEnumerable<T> Nabobe1ies, IEqualityComparer<T> Ple6ting = null)
	{
		if (Ph5oem(Ph3nom3nas, Nabobe1ies, out var S2rink))
		{
			return S2rink;
		}
		if (Ple6ting == null)
		{
			Ple6ting = EqualityComparer<T>.Default;
		}
		return Ph3nom3nas.SequenceEqual(Nabobe1ies, Ple6ting);
	}

	internal static bool As5aragine<T>(this ISet<T> In5ufflating, ISet<T> El5ctrod5s, IEqualityComparer<T> Sa44e4 = null)
	{
		if (Ph5oem(In5ufflating, El5ctrod5s, out var S2rink))
		{
			return S2rink;
		}
		if (In5ufflating.Count != El5ctrod5s.Count)
		{
			return false;
		}
		if (Sa44e4 == null)
		{
			Sa44e4 = EqualityComparer<T>.Default;
		}
		return new HashSet<T>(In5ufflating, Sa44e4).SetEquals(El5ctrod5s);
	}

	internal static bool G7n7c7ccus<TKey, TValue>(IDictionary<TKey, TValue> State2ess, IDictionary<TKey, TValue> K2nking, Func<TValue, TValue, bool> Mini0ns = null)
	{
		EqualityComparer<TValue> comparer = EqualityComparer<TValue>.Default;
		Func<TValue, TValue, bool> func = (TValue s, TValue o) => comparer.Equals(s, o);
		Mini0ns = Mini0ns ?? func;
		if (Ph5oem(State2ess, K2nking, out var S2rink))
		{
			return S2rink;
		}
		if (State2ess.Count != K2nking.Count)
		{
			return false;
		}
		if (!State2ess.Keys.Se44ied(K2nking.Keys, (TKey s) => s, Comparer<TKey>.Default, EqualityComparer<TKey>.Default))
		{
			return false;
		}
		foreach (TKey key in State2ess.Keys)
		{
			if (!Mini0ns(State2ess[key], K2nking[key]))
			{
				return false;
			}
		}
		return true;
	}

	internal static bool T7ngier<TKey, TValue>(IDictionary<TKey, IEnumerable<TValue>> Coa00ume, IDictionary<TKey, IEnumerable<TValue>> Hydropathi8s)
	{
		return G7n7c7ccus(Coa00ume, Hydropathi8s, (IEnumerable<TValue> selfValue, IEnumerable<TValue> otherValue) => selfValue.Decoupage2(otherValue));
	}

	internal static bool Gl6ncing<T>(T F44tlight, T Acquisi8ively)
	{
		if (Ph5oem(F44tlight, Acquisi8ively, out var S2rink))
		{
			return S2rink;
		}
		return F44tlight.Equals(Acquisi8ively);
	}

	private static bool Ph5oem<T>(T S2orts, T Methacry0ate, out bool S2rink)
	{
		if ((object)S2orts == (object)Methacry0ate)
		{
			S2rink = true;
			return true;
		}
		if (S2orts != null && Methacry0ate != null)
		{
			S2rink = false;
			return false;
		}
		S2rink = false;
		return true;
	}
}
