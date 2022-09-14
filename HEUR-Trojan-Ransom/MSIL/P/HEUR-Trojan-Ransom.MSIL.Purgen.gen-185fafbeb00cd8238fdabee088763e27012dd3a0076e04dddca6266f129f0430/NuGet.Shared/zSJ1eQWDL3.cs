using System;
using System.Collections.Generic;

namespace NuGet.Shared;

internal static class zSJ1eQWDL3
{
	public static List<T> zbSwhi6pRC<T>(this IEnumerable<T> N2pcOXBmA9)
	{
		if (N2pcOXBmA9 is List<T> result)
		{
			return result;
		}
		return new List<T>(N2pcOXBmA9);
	}

	public static HashSet<T> Qlssj5J51w<T>(this ISet<T> wCOXy3aoJi, IEqualityComparer<T> OuTLylGNnk = null)
	{
		if (wCOXy3aoJi == null)
		{
			return null;
		}
		if (wCOXy3aoJi is HashSet<T> result)
		{
			return result;
		}
		if (OuTLylGNnk == null)
		{
			OuTLylGNnk = EqualityComparer<T>.Default;
		}
		return new HashSet<T>(wCOXy3aoJi, OuTLylGNnk);
	}

	public static void _2iZ8Y3iwmf<T>(this IEnumerable<T> zNtOTk9T3c, Action<T> N6Xr1Tv851)
	{
		foreach (T item in zNtOTk9T3c)
		{
			N6Xr1Tv851(item);
		}
	}
}
