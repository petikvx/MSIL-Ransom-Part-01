using System;
using System.Collections.Generic;

namespace So22er;

internal static class Class0
{
	public static List<T> Late4cy<T>(this IEnumerable<T> Liq0e0r)
	{
		if (Liq0e0r is List<T> result)
		{
			return result;
		}
		return new List<T>(Liq0e0r);
	}

	public static HashSet<T> S6awall<T>(this ISet<T> Proxima8eness, IEqualityComparer<T> iequalityComparer_0 = null)
	{
		if (Proxima8eness == null)
		{
			return null;
		}
		if (Proxima8eness is HashSet<T> result)
		{
			return result;
		}
		if (iequalityComparer_0 == null)
		{
			iequalityComparer_0 = EqualityComparer<T>.Default;
		}
		return new HashSet<T>(Proxima8eness, iequalityComparer_0);
	}

	public static void B88h88ed<T>(this IEnumerable<T> K2ratitis2s, Action<T> Aim1)
	{
		foreach (T K2ratitis in K2ratitis2s)
		{
			Aim1(K2ratitis);
		}
	}
}
