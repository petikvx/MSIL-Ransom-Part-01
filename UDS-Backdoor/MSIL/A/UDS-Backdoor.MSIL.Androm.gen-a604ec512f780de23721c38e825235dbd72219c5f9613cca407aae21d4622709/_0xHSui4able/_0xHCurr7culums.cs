using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace _0xHSui4able;

internal static class _0xHCurr7culums
{
	public static void _0xHUrs5form<T>(this ObservableCollection<T> _0xHG6bernatorial, Func<T, bool> _0xHDiacri4ics)
	{
		foreach (T item in _0xHG6bernatorial.Where(_0xHDiacri4ics).ToList())
		{
			_0xHG6bernatorial.Remove(item);
		}
	}

	public static IEnumerable<T> _0xHA8erola<T>(this IEnumerable<T> _0xHReassem2ly)
	{
		if (_0xHReassem2ly == null)
		{
			return Enumerable.Empty<T>();
		}
		return _0xHReassem2ly;
	}

	public static bool _0xHDrec6y(this object _0xHOnychophoran4)
	{
		return _0xHOnychophoran4 != null;
	}
}
