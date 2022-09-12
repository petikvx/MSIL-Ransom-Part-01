using System;
using System.Collections;
using System.Collections.Generic;

namespace ns17;

internal static class Class45
{
	private static class Class46<T>
	{
		public static readonly T[] gparam_0 = new T[0];
	}

	public static bool smethod_0<T>(ICollection<T> icollection_0)
	{
		if (icollection_0 != null)
		{
			return icollection_0.Count == 0;
		}
		return true;
	}

	public static void smethod_1<T>(this IList<T> ilist_0, IEnumerable<T> ienumerable_0)
	{
		if (ilist_0 == null)
		{
			throw new ArgumentNullException("initial");
		}
		if (ienumerable_0 == null)
		{
			return;
		}
		foreach (T item in ienumerable_0)
		{
			ilist_0.Add(item);
		}
	}

	public static bool smethod_2<T>(this IList<T> ilist_0, T gparam_0)
	{
		return ilist_0.smethod_3(gparam_0, EqualityComparer<T>.Default);
	}

	public static bool smethod_3<T>(this IList<T> ilist_0, T gparam_0, IEqualityComparer<T> iequalityComparer_0)
	{
		if (ilist_0.smethod_4(gparam_0, iequalityComparer_0))
		{
			return false;
		}
		ilist_0.Add(gparam_0);
		return true;
	}

	public static bool smethod_4<T>(this IEnumerable<T> ienumerable_0, T gparam_0, IEqualityComparer<T> iequalityComparer_0)
	{
		if (iequalityComparer_0 == null)
		{
			iequalityComparer_0 = EqualityComparer<T>.Default;
		}
		if (ienumerable_0 == null)
		{
			throw new ArgumentNullException("source");
		}
		foreach (T item in ienumerable_0)
		{
			if (iequalityComparer_0.Equals(item, gparam_0))
			{
				return true;
			}
		}
		return false;
	}

	public static bool smethod_5<T>(this IList<T> ilist_0, IEnumerable<T> ienumerable_0, IEqualityComparer<T> iequalityComparer_0)
	{
		bool result = true;
		foreach (T item in ienumerable_0)
		{
			if (!ilist_0.smethod_3(item, iequalityComparer_0))
			{
				result = false;
			}
		}
		return result;
	}

	public static int smethod_6<T>(this IEnumerable<T> ienumerable_0, Func<T, bool> func_0)
	{
		int num = 0;
		foreach (T item in ienumerable_0)
		{
			if (!func_0(item))
			{
				num++;
				continue;
			}
			return num;
		}
		return -1;
	}

	public static bool smethod_7<T>(this List<T> list_0, T gparam_0, IEqualityComparer iequalityComparer_0)
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if (iequalityComparer_0.Equals(gparam_0, list_0[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static int smethod_8<T>(this List<T> list_0, T gparam_0)
	{
		int num = 0;
		while (true)
		{
			if (num < list_0.Count)
			{
				if ((object)gparam_0 == (object)list_0[num])
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public static void smethod_9<T>(this List<T> list_0)
	{
		int num = 0;
		int num2 = list_0.Count - 1;
		while (num < num2)
		{
			T value = list_0[num];
			list_0[num] = list_0[num2];
			list_0[num2] = value;
			num++;
			num2--;
		}
	}

	public static T[] smethod_10<T>()
	{
		return Class46<T>.gparam_0;
	}
}
