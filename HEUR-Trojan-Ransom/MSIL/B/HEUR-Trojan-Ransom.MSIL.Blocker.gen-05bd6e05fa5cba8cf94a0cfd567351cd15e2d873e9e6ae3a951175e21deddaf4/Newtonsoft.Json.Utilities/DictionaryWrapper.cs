using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using ns12;
using ns5;

namespace Newtonsoft.Json.Utilities;

[DefaultMember("Item")]
internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, Interface3
{
	private readonly struct Struct2<V, W> : IEnumerator, IDictionaryEnumerator
	{
		private readonly IEnumerator<KeyValuePair<V, W>> ienumerator_0;

		DictionaryEntry IDictionaryEnumerator.Entry => (DictionaryEntry)System_002ECollections_002EIEnumerator_002ECurrent;

		object IDictionaryEnumerator.Key => System_002ECollections_002EIDictionaryEnumerator_002EEntry.Key;

		object IDictionaryEnumerator.Value => System_002ECollections_002EIDictionaryEnumerator_002EEntry.Value;

		object IEnumerator.Current => new DictionaryEntry(ienumerator_0.Current.Key, ienumerator_0.Current.Value);

		public Struct2(IEnumerator<KeyValuePair<V, W>> ienumerator_1)
		{
			Class113.smethod_0(ienumerator_1, "e");
			ienumerator_0 = ienumerator_1;
		}

		bool IEnumerator.MoveNext()
		{
			return ienumerator_0.MoveNext();
		}

		void IEnumerator.Reset()
		{
			ienumerator_0.Reset();
		}
	}

	private readonly IDictionary? idictionary_0;

	private readonly IDictionary<TKey, TValue>? idictionary_1;

	private object? object_0;

	internal IDictionary<TKey, TValue> GenericDictionary => idictionary_1;

	ICollection<TKey> IDictionary<TKey, TValue>.Keys
	{
		get
		{
			if (idictionary_0 != null)
			{
				return idictionary_0!.Keys.Cast<TKey>().ToList();
			}
			return GenericDictionary.Keys;
		}
	}

	ICollection<TValue> IDictionary<TKey, TValue>.Values
	{
		get
		{
			if (idictionary_0 != null)
			{
				return idictionary_0!.Values.Cast<TValue>().ToList();
			}
			return GenericDictionary.Values;
		}
	}

	TValue IDictionary<TKey, TValue>.this[TKey key]
	{
		get
		{
			if (idictionary_0 != null)
			{
				return (TValue)idictionary_0![key];
			}
			return GenericDictionary[key];
		}
		set
		{
			if (idictionary_0 != null)
			{
				idictionary_0![key] = value;
			}
			else
			{
				GenericDictionary[key] = value;
			}
		}
	}

	int ICollection<KeyValuePair<TKey, TValue>>.Count
	{
		get
		{
			if (idictionary_0 != null)
			{
				return idictionary_0!.Count;
			}
			return GenericDictionary.Count;
		}
	}

	bool IDictionary.IsReadOnly
	{
		get
		{
			if (idictionary_0 != null)
			{
				return idictionary_0!.IsReadOnly;
			}
			return GenericDictionary.IsReadOnly;
		}
	}

	object? IDictionary.this[object key]
	{
		get
		{
			if (idictionary_0 != null)
			{
				return idictionary_0![key];
			}
			return GenericDictionary[(TKey)key];
		}
		set
		{
			if (idictionary_0 != null)
			{
				idictionary_0![key] = value;
			}
			else
			{
				GenericDictionary[(TKey)key] = (TValue)value;
			}
		}
	}

	bool IDictionary.IsFixedSize
	{
		get
		{
			if (idictionary_1 != null)
			{
				return false;
			}
			return idictionary_0!.IsFixedSize;
		}
	}

	ICollection IDictionary.Keys
	{
		get
		{
			if (idictionary_1 != null)
			{
				return idictionary_1!.Keys.ToList();
			}
			return idictionary_0!.Keys;
		}
	}

	ICollection IDictionary.Values
	{
		get
		{
			if (idictionary_1 != null)
			{
				return idictionary_1!.Values.ToList();
			}
			return idictionary_0!.Values;
		}
	}

	bool ICollection.IsSynchronized
	{
		get
		{
			if (idictionary_0 != null)
			{
				return idictionary_0!.IsSynchronized;
			}
			return false;
		}
	}

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

	public object UnderlyingDictionary
	{
		get
		{
			if (idictionary_0 != null)
			{
				return idictionary_0;
			}
			return GenericDictionary;
		}
	}

	public DictionaryWrapper(IDictionary dictionary)
	{
		Class113.smethod_0(dictionary, "dictionary");
		idictionary_0 = dictionary;
	}

	public DictionaryWrapper(IDictionary<TKey, TValue> dictionary)
	{
		Class113.smethod_0(dictionary, "dictionary");
		idictionary_1 = dictionary;
	}

	void IDictionary<TKey, TValue>.Add(TKey key, TValue value)
	{
		if (idictionary_0 != null)
		{
			idictionary_0!.Add(key, value);
			return;
		}
		if (idictionary_1 == null)
		{
			throw new NotSupportedException();
		}
		idictionary_1!.Add(key, value);
	}

	bool IDictionary<TKey, TValue>.ContainsKey(TKey key)
	{
		if (idictionary_0 != null)
		{
			return idictionary_0!.Contains(key);
		}
		return GenericDictionary.ContainsKey(key);
	}

	bool IDictionary<TKey, TValue>.Remove(TKey key)
	{
		if (idictionary_0 != null)
		{
			if (idictionary_0!.Contains(key))
			{
				idictionary_0!.Remove(key);
				return true;
			}
			return false;
		}
		return GenericDictionary.Remove(key);
	}

	bool IDictionary<TKey, TValue>.TryGetValue(TKey key, out TValue? value)
	{
		if (idictionary_0 != null)
		{
			if (!idictionary_0!.Contains(key))
			{
				value = default(TValue);
				return false;
			}
			value = (TValue)idictionary_0![key];
			return true;
		}
		return GenericDictionary.TryGetValue(key, out value);
	}

	public void Add(KeyValuePair<TKey, TValue> item)
	{
		if (idictionary_0 != null)
		{
			((IList)idictionary_0).Add(item);
		}
		else
		{
			idictionary_1?.Add(item);
		}
	}

	void ICollection<KeyValuePair<TKey, TValue>>.Clear()
	{
		if (idictionary_0 != null)
		{
			idictionary_0!.Clear();
		}
		else
		{
			GenericDictionary.Clear();
		}
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
	{
		if (idictionary_0 != null)
		{
			return ((IList)idictionary_0).Contains(item);
		}
		return GenericDictionary.Contains(item);
	}

	void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
	{
		if (idictionary_0 != null)
		{
			foreach (DictionaryEntry item in idictionary_0!)
			{
				array[arrayIndex++] = new KeyValuePair<TKey, TValue>((TKey)item.Key, (TValue)item.Value);
			}
			return;
		}
		GenericDictionary.CopyTo(array, arrayIndex);
	}

	bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
	{
		if (idictionary_0 != null)
		{
			if (idictionary_0!.Contains(item.Key))
			{
				if (object.Equals(idictionary_0![item.Key], item.Value))
				{
					idictionary_0!.Remove(item.Key);
					return true;
				}
				return false;
			}
			return true;
		}
		return GenericDictionary.Remove(item);
	}

	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		if (idictionary_0 != null)
		{
			return (from DictionaryEntry dictionaryEntry_0 in idictionary_0
				select new KeyValuePair<TKey, TValue>((TKey)dictionaryEntry_0.Key, (TValue)dictionaryEntry_0.Value)).GetEnumerator();
		}
		return GenericDictionary.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EGetEnumerator();
	}

	void IDictionary.Add(object key, object value)
	{
		if (idictionary_0 != null)
		{
			idictionary_0!.Add(key, value);
		}
		else
		{
			GenericDictionary.Add((TKey)key, (TValue)value);
		}
	}

	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		if (idictionary_0 != null)
		{
			return idictionary_0!.GetEnumerator();
		}
		return new Struct2<TKey, TValue>(GenericDictionary.GetEnumerator());
	}

	bool IDictionary.Contains(object key)
	{
		if (idictionary_1 != null)
		{
			return idictionary_1!.ContainsKey((TKey)key);
		}
		return idictionary_0!.Contains(key);
	}

	void IDictionary.Remove(object key)
	{
		if (idictionary_0 != null)
		{
			idictionary_0!.Remove(key);
		}
		else
		{
			GenericDictionary.Remove((TKey)key);
		}
	}

	void ICollection.CopyTo(Array array, int index)
	{
		if (idictionary_0 != null)
		{
			idictionary_0!.CopyTo(array, index);
		}
		else
		{
			GenericDictionary.CopyTo((KeyValuePair<TKey, TValue>[])array, index);
		}
	}
}
