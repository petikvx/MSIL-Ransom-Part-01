using System;
using System.Collections.Generic;
using System.Linq;

namespace ns0;

internal struct Mali5ner
{
	private const long Cho6o = 5381L;

	private bool C0dges;

	private long W3n;

	internal int F3rl3rnnesses => W3n.GetHashCode();

	private void Mut0ns(int int_0)
	{
		W3n = ((W3n << 5) + W3n) ^ int_0;
	}

	internal void Out4hame4(int int_0)
	{
		Zedoar6();
		Mut0ns(int_0);
	}

	internal void Coat4ngs<TValue>(TValue Sti55les, IEqualityComparer<TValue> Freethinkin2s)
	{
		Zedoar6();
		if (Sti55les != null)
		{
			Mut0ns(Freethinkin2s.GetHashCode(Sti55les));
		}
	}

	internal void method_0<T>(T Neoty8es)
	{
		Zedoar6();
		if (Neoty8es != null)
		{
			Mut0ns(Neoty8es.GetHashCode());
		}
	}

	internal void Vol6ani6ally(string P6arl6d)
	{
		Zedoar6();
		if (P6arl6d != null)
		{
			Mut0ns(StringComparer.OrdinalIgnoreCase.GetHashCode(P6arl6d));
		}
	}

	internal void Cantileve5ed<T>(IEnumerable<T> In4ignation)
	{
		if (In4ignation == null)
		{
			return;
		}
		Zedoar6();
		foreach (T item in In4ignation)
		{
			Mut0ns(item.GetHashCode());
		}
	}

	internal void method_1<T>(T[] B2othe2)
	{
		if (B2othe2 != null)
		{
			Zedoar6();
			for (int i = 0; i < B2othe2.Length; i++)
			{
				T val = B2othe2[i];
				Mut0ns(val.GetHashCode());
			}
		}
	}

	internal void Excu1sionist<T>(IList<T> Monotoni6)
	{
		if (Monotoni6 != null)
		{
			Zedoar6();
			int count = Monotoni6.Count;
			for (int i = 0; i < count; i++)
			{
				Mut0ns(Monotoni6[i].GetHashCode());
			}
		}
	}

	internal void Pe5meabilities<T>(IReadOnlyList<T> ireadOnlyList_0)
	{
		if (ireadOnlyList_0 != null)
		{
			Zedoar6();
			int count = ireadOnlyList_0.Count;
			for (int i = 0; i < count; i++)
			{
				Mut0ns(ireadOnlyList_0[i].GetHashCode());
			}
		}
	}

	internal void Co4spicuities<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> Shatter6ngly)
	{
		if (Shatter6ngly == null)
		{
			return;
		}
		Zedoar6();
		foreach (KeyValuePair<TKey, TValue> item in Shatter6ngly.OrderBy((KeyValuePair<TKey, TValue> x) => x.Key))
		{
			Mut0ns(item.Key.GetHashCode());
			Mut0ns(item.Value.GetHashCode());
		}
	}

	internal static int R1pin1<T1, T2>(T1 gparam_0, T2 Tele2raphies)
	{
		Mali5ner mali5ner = default(Mali5ner);
		mali5ner.Zedoar6();
		mali5ner.Mut0ns(gparam_0.GetHashCode());
		mali5ner.Mut0ns(Tele2raphies.GetHashCode());
		return mali5ner.F3rl3rnnesses;
	}

	internal static int C7nvulsing<T1, T2, T3>(T1 C7l7cating, T2 Out2erformed, T3 Pri5rates)
	{
		Mali5ner mali5ner = default(Mali5ner);
		mali5ner.Zedoar6();
		mali5ner.Mut0ns(C7l7cating.GetHashCode());
		mali5ner.Mut0ns(Out2erformed.GetHashCode());
		mali5ner.Mut0ns(Pri5rates.GetHashCode());
		return mali5ner.F3rl3rnnesses;
	}

	private void Zedoar6()
	{
		if (!C0dges)
		{
			W3n = 5381L;
			C0dges = true;
		}
	}
}
