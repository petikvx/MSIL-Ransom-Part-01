using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Target;

public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISerializable, IDeserializationCallback
{
	private readonly Dictionary<T, object> dict;

	public HashSet<T> NullSet => new HashSet<T>();

	public int Count => dict.Count;

	public bool IsReadOnly => false;

	public HashSet()
	{
		dict = new Dictionary<T, object>();
	}

	public HashSet(IEnumerable<T> items)
		: this()
	{
		if (items == null)
		{
			return;
		}
		foreach (T item in items)
		{
			Add(item);
		}
	}

	public void Add(T item)
	{
		if (item == null)
		{
			throw new ArgumentNullException("item");
		}
		dict[item] = null;
	}

	public void Clear()
	{
		dict.Clear();
	}

	public bool Contains(T item)
	{
		return dict.ContainsKey(item);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		if (array == null)
		{
			throw new ArgumentNullException("array");
		}
		if (arrayIndex < 0 || arrayIndex >= array.Length || arrayIndex >= Count)
		{
			throw new ArgumentOutOfRangeException("arrayIndex");
		}
		dict.Keys.CopyTo(array, arrayIndex);
	}

	public bool Remove(T item)
	{
		return dict.Remove(item);
	}

	public HashSet<T> Union(HashSet<T> set)
	{
		HashSet<T> hashSet = new HashSet<T>(this);
		if (set == null)
		{
			return hashSet;
		}
		foreach (T item in set)
		{
			if (!hashSet.Contains(item))
			{
				hashSet.Add(item);
			}
		}
		return hashSet;
	}

	public HashSet<T> Subtract(HashSet<T> set)
	{
		HashSet<T> hashSet = new HashSet<T>(this);
		if (set == null)
		{
			return hashSet;
		}
		foreach (T item in set)
		{
			if (hashSet.Contains(item))
			{
				hashSet.dict.Remove(item);
			}
		}
		return hashSet;
	}

	public bool IsSubsetOf(HashSet<T> set)
	{
		HashSet<T> hashSet = set ?? NullSet;
		using (IEnumerator<T> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				T current = enumerator.Current;
				if (!hashSet.Contains(current))
				{
					return false;
				}
			}
		}
		return true;
	}

	public HashSet<T> Intersection(HashSet<T> set)
	{
		HashSet<T> nullSet = NullSet;
		if (set == null)
		{
			return nullSet;
		}
		using (IEnumerator<T> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				T current = enumerator.Current;
				if (set.Contains(current))
				{
					nullSet.Add(current);
				}
			}
		}
		foreach (T item in set)
		{
			if (Contains(item) && !nullSet.Contains(item))
			{
				nullSet.Add(item);
			}
		}
		return nullSet;
	}

	public bool IsProperSubsetOf(HashSet<T> set)
	{
		HashSet<T> hashSet = set ?? NullSet;
		return IsSubsetOf(hashSet) && !hashSet.IsSubsetOf(this);
	}

	public bool IsSupersetOf(HashSet<T> set)
	{
		HashSet<T> hashSet = set ?? NullSet;
		foreach (T item in hashSet)
		{
			if (!Contains(item))
			{
				return false;
			}
		}
		return true;
	}

	public bool IsProperSupersetOf(HashSet<T> set)
	{
		HashSet<T> hashSet = set ?? NullSet;
		return IsSupersetOf(hashSet) && !hashSet.IsSupersetOf(this);
	}

	public List<T> ToList()
	{
		return new List<T>(this);
	}

	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		dict.GetObjectData(info, context);
	}

	public void OnDeserialization(object sender)
	{
		dict.OnDeserialization(sender);
	}

	public IEnumerator<T> GetEnumerator()
	{
		return dict.Keys.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}
}
