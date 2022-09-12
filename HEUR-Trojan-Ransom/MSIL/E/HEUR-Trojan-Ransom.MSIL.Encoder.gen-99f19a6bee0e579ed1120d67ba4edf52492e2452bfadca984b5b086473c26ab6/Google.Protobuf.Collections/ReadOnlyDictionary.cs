using System;
using System.Collections;
using System.Collections.Generic;

namespace Google.Protobuf.Collections;

internal sealed class ReadOnlyDictionary<TKey, TValue> : IEnumerable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>
{
	private readonly IDictionary<TKey, TValue> wrapped;

	public ICollection<TKey> Keys => wrapped.Keys;

	public ICollection<TValue> Values => wrapped.Values;

	public TValue this[TKey key]
	{
		get
		{
			return wrapped[key];
		}
		set
		{
			throw new InvalidOperationException();
		}
	}

	public int Count => wrapped.Count;

	public bool IsReadOnly => true;

	public ReadOnlyDictionary(IDictionary<TKey, TValue> wrapped)
	{
		this.wrapped = wrapped;
	}

	public void Add(TKey key, TValue value)
	{
		throw new InvalidOperationException();
	}

	public bool ContainsKey(TKey key)
	{
		return wrapped.ContainsKey(key);
	}

	public bool Remove(TKey key)
	{
		throw new InvalidOperationException();
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		return wrapped.TryGetValue(key, out value);
	}

	public void Add(KeyValuePair<TKey, TValue> item)
	{
		throw new InvalidOperationException();
	}

	public void Clear()
	{
		throw new InvalidOperationException();
	}

	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		return wrapped.Contains(item);
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
		wrapped.CopyTo(array, arrayIndex);
	}

	public bool Remove(KeyValuePair<TKey, TValue> item)
	{
		throw new InvalidOperationException();
	}

	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
	{
		return wrapped.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable)wrapped).GetEnumerator();
	}

	public override bool Equals(object obj)
	{
		return wrapped.Equals(obj);
	}

	public override int GetHashCode()
	{
		return wrapped.GetHashCode();
	}

	public override string ToString()
	{
		return wrapped.ToString();
	}
}
