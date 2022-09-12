using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using ns10;
using ns14;
using ns9;

namespace ns17;

internal class Class47<T> : ICollection<T>, IEnumerable<T>, IList, IEnumerable, Interface2, ICollection
{
	private readonly IList? ilist_0;

	private readonly ICollection<T>? icollection_0;

	private object? object_0;

	virtual int ICollection<T>.Count
	{
		get
		{
			if (icollection_0 != null)
			{
				return icollection_0!.Count;
			}
			return ilist_0!.Count;
		}
	}

	virtual bool ICollection<T>.IsReadOnly
	{
		get
		{
			if (icollection_0 != null)
			{
				return icollection_0!.IsReadOnly;
			}
			return ilist_0!.IsReadOnly;
		}
	}

	bool IList.IsFixedSize
	{
		get
		{
			if (icollection_0 != null)
			{
				return icollection_0!.IsReadOnly;
			}
			return ilist_0!.IsFixedSize;
		}
	}

	object IList.this[int index]
	{
		get
		{
			if (icollection_0 != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
			}
			return ilist_0![index];
		}
		set
		{
			if (icollection_0 != null)
			{
				throw new InvalidOperationException("Wrapped ICollection<T> does not support indexer.");
			}
			smethod_0(value);
			ilist_0![index] = (T)value;
		}
	}

	bool ICollection.IsSynchronized => false;

	object ICollection.SyncRoot
	{
		get
		{
			if (object_0 == null)
			{
				Interlocked.CompareExchange(ref object_0, new object(), null);
			}
			return object_0;
		}
	}

	public object UnderlyingCollection => ((object)icollection_0) ?? ((object)ilist_0);

	public Class47(IList ilist_1)
	{
		Class113.smethod_0(ilist_1, "list");
		if (ilist_1 is ICollection<T> collection)
		{
			icollection_0 = collection;
		}
		else
		{
			ilist_0 = ilist_1;
		}
	}

	public Class47(ICollection<T> icollection_1)
	{
		Class113.smethod_0(icollection_1, "list");
		icollection_0 = icollection_1;
	}

	public virtual void Add(T item)
	{
		if (icollection_0 != null)
		{
			icollection_0!.Add(item);
		}
		else
		{
			ilist_0!.Add(item);
		}
	}

	virtual void ICollection<T>.Clear()
	{
		if (icollection_0 != null)
		{
			icollection_0!.Clear();
		}
		else
		{
			ilist_0!.Clear();
		}
	}

	virtual bool ICollection<T>.Contains(T item)
	{
		if (icollection_0 != null)
		{
			return icollection_0!.Contains(item);
		}
		return ilist_0!.Contains(item);
	}

	virtual void ICollection<T>.CopyTo(T[] array, int arrayIndex)
	{
		if (icollection_0 != null)
		{
			icollection_0!.CopyTo(array, arrayIndex);
		}
		else
		{
			ilist_0!.CopyTo(array, arrayIndex);
		}
	}

	virtual bool ICollection<T>.Remove(T item)
	{
		if (icollection_0 != null)
		{
			return icollection_0!.Remove(item);
		}
		bool num = ilist_0!.Contains(item);
		if (num)
		{
			ilist_0!.Remove(item);
		}
		return num;
	}

	virtual IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		IEnumerable<T> enumerable = icollection_0;
		return (enumerable ?? ilist_0.Cast<T>()).GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		IEnumerable enumerable = icollection_0;
		return (enumerable ?? ilist_0).GetEnumerator();
	}

	int IList.Add(object value)
	{
		smethod_0(value);
		Add((T)value);
		return System_002ECollections_002EGeneric_002EICollection_003CT_003E_002ECount - 1;
	}

	bool IList.Contains(object value)
	{
		if (smethod_1(value))
		{
			return System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EContains((T)value);
		}
		return false;
	}

	int IList.IndexOf(object value)
	{
		if (icollection_0 != null)
		{
			throw new InvalidOperationException("Wrapped ICollection<T> does not support IndexOf.");
		}
		if (smethod_1(value))
		{
			return ilist_0!.IndexOf((T)value);
		}
		return -1;
	}

	void IList.RemoveAt(int index)
	{
		if (icollection_0 != null)
		{
			throw new InvalidOperationException("Wrapped ICollection<T> does not support RemoveAt.");
		}
		ilist_0!.RemoveAt(index);
	}

	void IList.Insert(int index, object value)
	{
		if (icollection_0 != null)
		{
			throw new InvalidOperationException("Wrapped ICollection<T> does not support Insert.");
		}
		smethod_0(value);
		ilist_0!.Insert(index, (T)value);
	}

	void IList.Remove(object value)
	{
		if (smethod_1(value))
		{
			System_002ECollections_002EGeneric_002EICollection_003CT_003E_002ERemove((T)value);
		}
	}

	void ICollection.CopyTo(Array array, int index)
	{
		System_002ECollections_002EGeneric_002EICollection_003CT_003E_002ECopyTo((T[])array, index);
	}

	private static void smethod_0(object object_1)
	{
		if (!smethod_1(object_1))
		{
			throw new ArgumentException("The value '{0}' is not of type '{1}' and cannot be used in this generic collection.".smethod_2(CultureInfo.InvariantCulture, object_1, typeof(T)), "value");
		}
	}

	private static bool smethod_1(object object_1)
	{
		if (!(object_1 is T) && (object_1 != null || (typeof(T).smethod_13() && !Class7.smethod_157(typeof(T)))))
		{
			return false;
		}
		return true;
	}
}
