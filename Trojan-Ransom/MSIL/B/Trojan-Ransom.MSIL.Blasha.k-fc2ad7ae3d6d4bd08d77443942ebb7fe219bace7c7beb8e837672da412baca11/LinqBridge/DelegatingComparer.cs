using System;
using System.Collections.Generic;

namespace LinqBridge;

internal sealed class DelegatingComparer<T> : IComparer<T>
{
	private readonly Func<T, T, int> _comparer;

	public DelegatingComparer(Func<T, T, int> comparer)
	{
		if (comparer == null)
		{
			throw new ArgumentNullException("comparer");
		}
		_comparer = comparer;
	}

	public int Compare(T x, T y)
	{
		return _comparer(x, y);
	}
}
