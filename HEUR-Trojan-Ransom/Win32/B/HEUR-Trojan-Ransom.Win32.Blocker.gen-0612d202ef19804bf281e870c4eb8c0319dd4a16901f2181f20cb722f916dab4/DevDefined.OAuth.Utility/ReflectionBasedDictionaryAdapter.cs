using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace DevDefined.OAuth.Utility;

public class ReflectionBasedDictionaryAdapter : IDictionary, IEnumerable, ICollection
{
	private class DictionaryEntryEnumeratorAdapter : IEnumerator, IDictionaryEnumerator
	{
		private readonly IDictionaryEnumerator _enumerator;

		private KeyValuePair<string, object> _current;

		public object Key => _current.Key;

		public object Value => _current.Value;

		public DictionaryEntry Entry => new DictionaryEntry(Key, Value);

		public object Current => new DictionaryEntry(Key, Value);

		public DictionaryEntryEnumeratorAdapter(IDictionaryEnumerator enumerator)
		{
			_enumerator = enumerator;
		}

		public bool MoveNext()
		{
			bool result;
			if (result = _enumerator.MoveNext())
			{
				_current = (KeyValuePair<string, object>)_enumerator.Current;
			}
			return result;
		}

		public void Reset()
		{
			_enumerator.Reset();
		}
	}

	private readonly Dictionary<string, object> _properties = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);

	public object this[object key]
	{
		get
		{
			_properties.TryGetValue(key.ToString(), out var value);
			return value;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public ICollection Keys => _properties.Keys;

	public ICollection Values => _properties.Values;

	public bool IsReadOnly => true;

	public bool IsFixedSize
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public int Count => _properties.Count;

	public object SyncRoot => _properties;

	public bool IsSynchronized => false;

	public ReflectionBasedDictionaryAdapter(object target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		Type type = target.GetType();
		PropertyInfo[] properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
		foreach (PropertyInfo propertyInfo in properties)
		{
			if (propertyInfo.CanRead)
			{
				object value = propertyInfo.GetValue(target, null);
				_properties[propertyInfo.Name] = value;
			}
		}
	}

	public bool Contains(object key)
	{
		return _properties.ContainsKey(key.ToString());
	}

	public void Add(object key, object value)
	{
		throw new NotImplementedException();
	}

	public void Clear()
	{
		throw new NotImplementedException();
	}

	IDictionaryEnumerator IDictionary.GetEnumerator()
	{
		return new DictionaryEntryEnumeratorAdapter(_properties.GetEnumerator());
	}

	public void Remove(object key)
	{
	}

	public void CopyTo(Array array, int index)
	{
		throw new NotImplementedException();
	}

	public IEnumerator GetEnumerator()
	{
		return new DictionaryEntryEnumeratorAdapter(_properties.GetEnumerator());
	}
}
