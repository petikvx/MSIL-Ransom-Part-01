using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using pal.EventLogAnalyzer.IO;

namespace pal.EventLogAnalyzer.Utils;

public class EventList<T> : IList<T>, ICollection<T>, IEnumerable<T>, pal.EventLogAnalyzer.IO.IReadOnlyList<T>, IReadOnlyCollection<T>, IEnumerable, IDisposable
{
	public delegate void ItemEventHandler(T item, int index);

	public delegate void ItemSetEventHandler(T oldItem, T newItem, int index);

	public delegate void CollectionEventHandler(IEnumerable<T> items, IEnumerable<int> indexes);

	private object lockKey;

	private List<T> l;

	public int Count => l.Count;

	public bool IsReadOnly => ((ICollection<T>)l).IsReadOnly;

	public bool IsLocked => lockKey != null;

	public T this[int index]
	{
		get
		{
			return this[index, null];
		}
		set
		{
			this[index, null] = value;
		}
	}

	public T this[int index, object key]
	{
		get
		{
			return l[index];
		}
		set
		{
			checkLock(key);
			T val = l[index];
			if (!value.Equals(val))
			{
				l[index] = value;
				this.ListChanged?.Invoke();
				this.ItemSet?.Invoke(val, value, index);
			}
		}
	}

	public event ItemEventHandler ItemAdd;

	public event ItemEventHandler ItemRemove;

	public event ItemEventHandler ItemMove;

	public event ItemSetEventHandler ItemSet;

	public event CollectionEventHandler CollectionAdd;

	public event CollectionEventHandler CollectionRemove;

	public event Action ListClearing;

	public event Action ListCleared;

	public event Action ListReversing;

	public event Action ListReversed;

	public event Action ListSorting;

	public event Action ListSorted;

	public event Action ListChanged;

	public EventList()
	{
		l = new List<T>();
	}

	public EventList(List<T> list)
	{
		l = list;
	}

	public void ClearEvents()
	{
		this.ListChanged = null;
		this.ItemAdd = null;
		this.ItemSet = null;
		this.ItemRemove = null;
		this.ItemMove = null;
		this.CollectionAdd = null;
		this.CollectionRemove = null;
		this.ListClearing = null;
		this.ListCleared = null;
		this.ListReversing = null;
		this.ListReversed = null;
		this.ListSorting = null;
		this.ListSorted = null;
	}

	public void Dispose()
	{
		ClearEvents();
		Clear();
	}

	public void Add(T item, object key)
	{
		checkLock(key);
		int count = Count;
		l.Add(item);
		this.ItemAdd?.Invoke(item, count);
		this.ListChanged?.Invoke();
	}

	public void AddRange(IEnumerable<T> collection, object key = null)
	{
		checkLock(key);
		int count = Count;
		l.AddRange(collection);
		this.CollectionAdd?.Invoke(collection, Enumerable.Range(count, collection.Count()));
		this.ListChanged?.Invoke();
	}

	public void Insert(int index, T item, object key)
	{
		checkLock(key);
		int count = Count;
		l.Insert(index, item);
		this.ItemAdd?.Invoke(item, count);
		this.ListChanged?.Invoke();
	}

	public void InsertRange(int index, IEnumerable<T> collection, object key = null)
	{
		checkLock(key);
		l.InsertRange(index, collection);
		this.CollectionAdd?.Invoke(collection, Enumerable.Range(index, collection.Count()));
		this.ListChanged?.Invoke();
	}

	public bool Remove(T item, object key)
	{
		int num = IndexOf(item);
		if (num == -1)
		{
			return false;
		}
		RemoveAt(num, key);
		return true;
	}

	public int RemoveAll(Predicate<T> match, object key = null)
	{
		checkLock(key);
		List<T> list = l.FindAll(match);
		if (list.Count > 0)
		{
			int i = -1;
			IEnumerable<int> indexes = list.Select((T a) => i = l.IndexOf(a, i + 1));
			l.RemoveAll(match);
			this.CollectionRemove?.Invoke(list, indexes);
			this.ListChanged?.Invoke();
		}
		return list.Count;
	}

	public void RemoveAt(int index, object key)
	{
		checkLock(key);
		T item = l[index];
		l.RemoveAt(index);
		this.ItemRemove?.Invoke(item, index);
		this.ListChanged?.Invoke();
	}

	public void RemoveRange(int index, int count, object key = null)
	{
		checkLock(key);
		List<T> range = l.GetRange(index, count);
		l.RemoveRange(index, count);
		this.CollectionRemove?.Invoke(range, Enumerable.Range(index, count));
		this.ListChanged?.Invoke();
	}

	public void Clear(object key)
	{
		checkLock(key);
		this.ListClearing?.Invoke();
		l.Clear();
		this.ListCleared?.Invoke();
		this.ListChanged?.Invoke();
	}

	public void Reverse(object key = null)
	{
		checkLock(key);
		this.ListReversing?.Invoke();
		l.Reverse();
		this.ListReversed?.Invoke();
		this.ListChanged?.Invoke();
	}

	public void Reverse(int index, int count, object key = null)
	{
		checkLock(key);
		this.ListReversing?.Invoke();
		l.Reverse(index, count);
		this.ListReversed?.Invoke();
		this.ListChanged?.Invoke();
	}

	public void Sort(object key = null)
	{
		checkLock(key);
		this.ListSorting?.Invoke();
		l.Sort();
		this.ListSorted?.Invoke();
		this.ListChanged?.Invoke();
	}

	public void Sort(Comparison<T> comparison, object key = null)
	{
		checkLock(key);
		this.ListSorting?.Invoke();
		l.Sort(comparison);
		this.ListSorted?.Invoke();
		this.ListChanged?.Invoke();
	}

	public void Sort(IComparer<T> comparer, object key = null)
	{
		checkLock(key);
		this.ListSorting?.Invoke();
		l.Sort(comparer);
		this.ListSorted?.Invoke();
		this.ListChanged?.Invoke();
	}

	public void Sort(int index, int count, IComparer<T> comparer, object key = null)
	{
		checkLock(key);
		this.ListSorting?.Invoke();
		l.Sort(index, count, comparer);
		this.ListSorted?.Invoke();
		this.ListChanged?.Invoke();
	}

	public void Move(int fromIndex, int toIndex, object key = null)
	{
		checkLock(key);
		T item = l[fromIndex];
		l.RemoveAt(fromIndex);
		l.Insert(toIndex, item);
		this.ItemMove?.Invoke(item, toIndex);
		this.ListChanged?.Invoke();
	}

	public void Lock(object key)
	{
		if (IsLocked)
		{
			throw new InvalidOperationException("This object is already locked.");
		}
		lockKey = key ?? throw new ArgumentNullException("key");
	}

	public void Unlock(object key)
	{
		if (!IsLocked)
		{
			throw new InvalidOperationException("This object is not locked.");
		}
		checkLock(key);
		lockKey = null;
	}

	private void checkLock(object key)
	{
		if (IsLocked && lockKey != key)
		{
			throw new InvalidOperationException("Invalid key to use this object.");
		}
	}

	public void Add(T item)
	{
		Add(item, null);
	}

	public void Insert(int index, T item)
	{
		Insert(index, item, null);
	}

	public bool Remove(T item)
	{
		return Remove(item, null);
	}

	public void RemoveAt(int index)
	{
		RemoveAt(index, null);
	}

	public void Clear()
	{
		Clear(null);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		l.CopyTo(array, arrayIndex);
	}

	public bool Contains(T item)
	{
		return l.Contains(item);
	}

	public int IndexOf(T item)
	{
		return l.IndexOf(item);
	}

	public IEnumerator<T> GetEnumerator()
	{
		return l.AsReadOnly().GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return l.AsReadOnly().GetEnumerator();
	}

	public static implicit operator EventList<T>(List<T> a)
	{
		return new EventList<T>(a);
	}
}
