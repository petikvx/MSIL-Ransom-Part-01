using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NuGet.Shared;

internal struct wj6yOz7pmk
{
	[Serializable]
	[CompilerGenerated]
	private sealed class vCKkxlVJyr<TKey, TValue>
	{
		public static readonly vCKkxlVJyr<TKey, TValue> Xukggfxw6N;

		public static Func<KeyValuePair<TKey, TValue>, TKey> drLULPVKeb;

		static vCKkxlVJyr()
		{
			vCKkxlVJyr<TKey, TValue>._003C_003E9 = new vCKkxlVJyr<TKey, TValue>();
		}

		internal TKey _9RgsVtzfEj(KeyValuePair<TKey, TValue> cHjtcGfjGp)
		{
			return cHjtcGfjGp.Key;
		}
	}

	private const long _83actlJZa2 = 5381L;

	private bool zpuTOzsVqS;

	private long UHPT4TK01V;

	internal int ngDVI44bot => UHPT4TK01V.GetHashCode();

	private void LyolHRQQho(int oRB0QTXvpH)
	{
		UHPT4TK01V = ((UHPT4TK01V << 5) + UHPT4TK01V) ^ oRB0QTXvpH;
	}

	internal void levgqUrzR6(int S7NazUimjn)
	{
		_9OCPY5gZV5();
		LyolHRQQho(S7NazUimjn);
	}

	internal void FeTBNKQx3y<TValue>(TValue _5vejCf0tZE, IEqualityComparer<TValue> Jo8wU4o2Z3)
	{
		_9OCPY5gZV5();
		if (_5vejCf0tZE != null)
		{
			LyolHRQQho(Jo8wU4o2Z3.GetHashCode(_5vejCf0tZE));
		}
	}

	internal void pf4NdInyy9<T>(T csewXsuDYA)
	{
		_9OCPY5gZV5();
		if (csewXsuDYA != null)
		{
			LyolHRQQho(csewXsuDYA.GetHashCode());
		}
	}

	internal void d9W5NNkgCh(string NSusQCnxZa)
	{
		_9OCPY5gZV5();
		if (NSusQCnxZa != null)
		{
			LyolHRQQho(StringComparer.OrdinalIgnoreCase.GetHashCode(NSusQCnxZa));
		}
	}

	internal void zhol1GFNZz<T>(IEnumerable<T> YBL1CuRCD7)
	{
		if (YBL1CuRCD7 == null)
		{
			return;
		}
		_9OCPY5gZV5();
		foreach (T item in YBL1CuRCD7)
		{
			LyolHRQQho(item.GetHashCode());
		}
	}

	internal void x52eWiAyGE<T>(T[] _0Vf81oMMUv)
	{
		if (_0Vf81oMMUv != null)
		{
			_9OCPY5gZV5();
			for (int i = 0; i < _0Vf81oMMUv.Length; i++)
			{
				T val = _0Vf81oMMUv[i];
				LyolHRQQho(val.GetHashCode());
			}
		}
	}

	internal void emxRA7qFqq<T>(IList<T> oOpoThCVEb)
	{
		if (oOpoThCVEb != null)
		{
			_9OCPY5gZV5();
			int count = oOpoThCVEb.Count;
			for (int i = 0; i < count; i++)
			{
				LyolHRQQho(oOpoThCVEb[i].GetHashCode());
			}
		}
	}

	internal void _5pfMS0UWuv<T>(IReadOnlyList<T> _39fyj260wf)
	{
		if (_39fyj260wf != null)
		{
			_9OCPY5gZV5();
			int count = _39fyj260wf.Count;
			for (int i = 0; i < count; i++)
			{
				LyolHRQQho(_39fyj260wf[i].GetHashCode());
			}
		}
	}

	internal void Qp2PzAilDj<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> BhtN8OzSjl)
	{
		if (BhtN8OzSjl == null)
		{
			return;
		}
		_9OCPY5gZV5();
		foreach (KeyValuePair<TKey, TValue> item in BhtN8OzSjl.OrderBy(vCKkxlVJyr<TKey, TValue>._003C_003E9__14_0 ?? (vCKkxlVJyr<TKey, TValue>._003C_003E9__14_0 = vCKkxlVJyr<TKey, TValue>._003C_003E9._003CAddDictionary_003Eb__14_0)))
		{
			LyolHRQQho(item.Key.GetHashCode());
			LyolHRQQho(item.Value.GetHashCode());
		}
	}

	internal static int rQrOviVnhC<T1, T2>(T1 _1CI2YM302i, T2 zFJZOBB62D)
	{
		wj6yOz7pmk wj6yOz7pmk2 = default(wj6yOz7pmk);
		wj6yOz7pmk2._9OCPY5gZV5();
		wj6yOz7pmk2.LyolHRQQho(_1CI2YM302i.GetHashCode());
		wj6yOz7pmk2.LyolHRQQho(zFJZOBB62D.GetHashCode());
		return wj6yOz7pmk2.ngDVI44bot;
	}

	internal static int mNc9pvfi4Y<T1, T2, T3>(T1 X7XskBgREO, T2 SNZoCfiLdU, T3 uzxupG7y0L)
	{
		wj6yOz7pmk wj6yOz7pmk2 = default(wj6yOz7pmk);
		wj6yOz7pmk2._9OCPY5gZV5();
		wj6yOz7pmk2.LyolHRQQho(X7XskBgREO.GetHashCode());
		wj6yOz7pmk2.LyolHRQQho(SNZoCfiLdU.GetHashCode());
		wj6yOz7pmk2.LyolHRQQho(uzxupG7y0L.GetHashCode());
		return wj6yOz7pmk2.ngDVI44bot;
	}

	private void _9OCPY5gZV5()
	{
		if (!zpuTOzsVqS)
		{
			UHPT4TK01V = 5381L;
			zpuTOzsVqS = true;
		}
	}
}
