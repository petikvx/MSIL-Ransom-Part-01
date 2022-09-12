using System.Collections.Generic;

namespace MySql.Data.Common;

internal class Cache<TKeyType, TValueType>
{
	private readonly int _capacity;

	private readonly Queue<TKeyType> _keyQ;

	private readonly Dictionary<TKeyType, TValueType> _contents;

	public TValueType this[TKeyType key]
	{
		get
		{
			if (_contents.TryGetValue(key, out var value))
			{
				return value;
			}
			return default(TValueType);
		}
		set
		{
			InternalAdd(key, value);
		}
	}

	public Cache(int initialCapacity, int capacity)
	{
		_capacity = capacity;
		_contents = new Dictionary<TKeyType, TValueType>(initialCapacity);
		if (capacity > 0)
		{
			_keyQ = new Queue<TKeyType>(initialCapacity);
		}
	}

	public void Add(TKeyType key, TValueType value)
	{
		InternalAdd(key, value);
	}

	private void InternalAdd(TKeyType key, TValueType value)
	{
		if (!_contents.ContainsKey(key) && _capacity > 0)
		{
			_keyQ.Enqueue(key);
			if (_keyQ.Count > _capacity)
			{
				_contents.Remove(_keyQ.Dequeue());
			}
		}
		_contents[key] = value;
	}
}
