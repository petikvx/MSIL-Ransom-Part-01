using System;
using System.Collections;
using System.Collections.Generic;

internal class Class26<T> : ICollection<T>, IEnumerable<T>, IEnumerable
{
	private readonly List<T> list_0 = new List<T>();

	public T this[int index]
	{
		get
		{
			return list_0[index];
		}
		set
		{
			throw smethod_0();
		}
	}

	public int Count => list_0.Count;

	public bool IsReadOnly => true;

	public void method_0(T gparam_0)
	{
		list_0.Add(gparam_0);
	}

	public void method_1()
	{
		list_0.RemoveAt(0);
	}

	public void Add(T item)
	{
		throw smethod_0();
	}

	public void Clear()
	{
		throw smethod_0();
	}

	public bool Contains(T item)
	{
		return list_0.Contains(item);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		list_0.CopyTo(array, arrayIndex);
	}

	public bool Remove(T item)
	{
		throw smethod_0();
	}

	public IEnumerator<T> GetEnumerator()
	{
		return list_0.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return list_0.GetEnumerator();
	}

	private static Exception smethod_0()
	{
		return new InvalidOperationException("Collection is read-only.");
	}
}
