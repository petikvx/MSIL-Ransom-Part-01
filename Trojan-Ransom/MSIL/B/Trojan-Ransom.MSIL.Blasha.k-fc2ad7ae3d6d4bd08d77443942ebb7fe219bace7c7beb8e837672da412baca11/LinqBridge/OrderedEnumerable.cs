using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqBridge;

internal sealed class OrderedEnumerable<T, K> : IEnumerable<T>, IEnumerable, IOrderedEnumerable<T>
{
	private readonly IEnumerable<T> _source;

	private readonly Func<T[], IComparer<int>, IComparer<int>> _comparerComposer;

	public OrderedEnumerable(IEnumerable<T> source, Func<T, K> keySelector, IComparer<K> comparer, bool descending)
		: this(source, (Func<T[], IComparer<int>, IComparer<int>>)((T[] _, IComparer<int> next) => next), keySelector, comparer, descending)
	{
	}

	private OrderedEnumerable(IEnumerable<T> source, Func<T[], IComparer<int>, IComparer<int>> parent, Func<T, K> keySelector, IComparer<K> comparer, bool descending)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (keySelector == null)
		{
			throw new ArgumentNullException("keySelector");
		}
		_source = source;
		comparer = comparer ?? Comparer<K>.Default;
		int direction = ((!descending) ? 1 : (-1));
		_comparerComposer = delegate(T[] items, IComparer<int> next)
		{
			K[] keys = new K[items.Length];
			for (int k = 0; k < items.Length; k++)
			{
				keys[k] = keySelector(items[k]);
			}
			return parent(items, new DelegatingComparer<int>(delegate(int i, int j)
			{
				int num = direction * comparer.Compare(keys[i], keys[j]);
				return (num == 0) ? next.Compare(i, j) : num;
			}));
		};
	}

	public IOrderedEnumerable<T> CreateOrderedEnumerable<KK>(Func<T, KK> keySelector, IComparer<KK> comparer, bool descending)
	{
		return new OrderedEnumerable<T, KK>(_source, _comparerComposer, keySelector, comparer, descending);
	}

	public IEnumerator<T> GetEnumerator()
	{
		T[] array = _source.ToArray();
		DelegatingComparer<int> arg = new DelegatingComparer<int>((int i, int j) => i.CompareTo(j));
		IComparer<int> comparer = _comparerComposer(array, arg);
		int[] array2 = new int[array.Length];
		for (int k = 0; k < array2.Length; k++)
		{
			array2[k] = k;
		}
		Array.Sort(array2, array, comparer);
		return ((IEnumerable<T>)array).GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
