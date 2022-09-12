using System;

namespace Gecko.Events;

public sealed class GeckoEventList
{
	internal sealed class HashTableEntry
	{
		internal int key;

		internal Delegate handler;

		public HashTableEntry(int key, Delegate handler)
		{
			this.key = key;
			this.handler = handler;
		}
	}

	private HashTableEntry[] _entries;

	private int _count = 0;

	public Delegate this[int key]
	{
		get
		{
			HashTableEntry hashTableEntry = null;
			return BinarySearch(key)?.handler;
		}
		set
		{
			HashTableEntry hashTableEntry = null;
			hashTableEntry = BinarySearch(key, out var nearest);
			if (hashTableEntry != null)
			{
				hashTableEntry.handler = value;
			}
			else
			{
				InsertDelegate(key, nearest, value);
			}
		}
	}

	public GeckoEventList()
	{
		_entries = new HashTableEntry[10];
	}

	public void AddHandler(int key, Delegate handler)
	{
		HashTableEntry hashTableEntry = null;
		hashTableEntry = BinarySearch(key, out var nearest);
		if (hashTableEntry != null)
		{
			hashTableEntry.handler = Delegate.Combine(hashTableEntry.handler, handler);
		}
		else
		{
			InsertDelegate(key, nearest, handler);
		}
	}

	public void RemoveHandler(int key, Delegate handler)
	{
		HashTableEntry hashTableEntry = null;
		hashTableEntry = BinarySearch(key);
		if (hashTableEntry != null)
		{
			hashTableEntry.handler = Delegate.Remove(hashTableEntry.handler, handler);
		}
	}

	private void InsertDelegate(int key, int afterPosition, Delegate handler)
	{
		if (_count + 1 == _entries.Length)
		{
			Array.Resize(ref _entries, _entries.Length * 2);
		}
		for (int num = _count - 1; num > afterPosition; num--)
		{
			_entries[num + 1] = _entries[num];
		}
		_entries[afterPosition + 1] = new HashTableEntry(key, handler);
	}

	private HashTableEntry BinarySearch(int key)
	{
		int num = 0;
		int num2 = _count - 1;
		HashTableEntry hashTableEntry = null;
		while (true)
		{
			if (num != num2)
			{
				int num3 = (num + num2) / 2;
				hashTableEntry = _entries[num3];
				int key2 = hashTableEntry.key;
				if (key2 == key)
				{
					break;
				}
				if (key2 > key)
				{
					num2 = num3 - 1;
				}
				else
				{
					num = num3 + 1;
				}
				continue;
			}
			hashTableEntry = _entries[num];
			return (hashTableEntry.key == key) ? hashTableEntry : null;
		}
		return hashTableEntry;
	}

	private HashTableEntry BinarySearch(int key, out int nearest)
	{
		int num = 0;
		int num2 = _count - 1;
		HashTableEntry hashTableEntry = null;
		int num3;
		while (true)
		{
			if (num != num2)
			{
				num3 = (num + num2) / 2;
				hashTableEntry = _entries[num3];
				int key2 = hashTableEntry.key;
				if (key2 == key)
				{
					break;
				}
				if (key2 > key)
				{
					num2 = num3 - 1;
				}
				else
				{
					num = num3 + 1;
				}
				continue;
			}
			hashTableEntry = _entries[num];
			nearest = num;
			return (hashTableEntry.key == key) ? hashTableEntry : null;
		}
		nearest = num3;
		return hashTableEntry;
	}

	internal void Initialize(int[] keys, Delegate[] handlers)
	{
		HashTableEntry[] array = new HashTableEntry[keys.Length];
		for (int i = 0; i < keys.Length; i++)
		{
			array[i] = new HashTableEntry(keys[i], handlers[i]);
		}
		Array.Sort(array, (HashTableEntry x, HashTableEntry y) => x.key.CompareTo(y.key));
		_entries = array;
		_count = _entries.Length;
	}
}
