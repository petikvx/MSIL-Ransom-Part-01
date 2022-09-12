using System;
using System.Collections;
using System.Collections.Generic;

namespace Gecko;

public class GeckoSessionHistory : IList<GeckoHistoryEntry>, ICollection<GeckoHistoryEntry>, IEnumerable<GeckoHistoryEntry>, IEnumerable
{
	private class HistoryEntry : GeckoHistoryEntry
	{
		private nsISHEntry Entry;

		public override Uri Url
		{
			get
			{
				nsIURI uRIAttribute = Entry.GetURIAttribute();
				return (uRIAttribute == null) ? null : new Uri(nsString.Get(uRIAttribute.GetSpecAttribute));
			}
		}

		public override string Title
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public override bool IsSubFrame
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		internal HistoryEntry(nsISHEntry entry)
		{
			Entry = entry;
		}
	}

	private nsIWebNavigation WebNav;

	private nsISHistory History;

	public GeckoHistoryEntry this[int index]
	{
		get
		{
			return new HistoryEntry(History.GetEntryAtIndex(index, modifyIndex: false));
		}
		set
		{
			throw new InvalidOperationException();
		}
	}

	public int Count => History.GetCountAttribute();

	public int Index => History.GetIndexAttribute();

	public int MaxLength
	{
		get
		{
			return History.GetMaxLengthAttribute();
		}
		set
		{
			History.SetMaxLengthAttribute(value);
		}
	}

	public bool IsReadOnly => false;

	internal GeckoSessionHistory(nsIWebNavigation webNav)
	{
		WebNav = webNav;
		History = webNav.GetSessionHistoryAttribute();
	}

	public void GotoIndex(int index)
	{
		if (index < 0 || index >= Count)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		WebNav.GotoIndex(index);
	}

	int IList<GeckoHistoryEntry>.IndexOf(GeckoHistoryEntry item)
	{
		throw new NotSupportedException();
	}

	void IList<GeckoHistoryEntry>.Insert(int index, GeckoHistoryEntry item)
	{
		throw new NotSupportedException();
	}

	void IList<GeckoHistoryEntry>.RemoveAt(int index)
	{
		if (index != Count - 1)
		{
			throw new InvalidOperationException();
		}
		Purge(1);
	}

	public void Purge(int count)
	{
		History.PurgeHistory(count);
	}

	void ICollection<GeckoHistoryEntry>.Add(GeckoHistoryEntry item)
	{
		throw new InvalidOperationException();
	}

	public void Clear()
	{
		History.PurgeHistory(Count);
	}

	bool ICollection<GeckoHistoryEntry>.Contains(GeckoHistoryEntry item)
	{
		throw new InvalidOperationException();
	}

	public void CopyTo(GeckoHistoryEntry[] array, int arrayIndex)
	{
		for (int i = 0; i < Count; i++)
		{
			array[arrayIndex + i] = this[i];
		}
	}

	bool ICollection<GeckoHistoryEntry>.Remove(GeckoHistoryEntry item)
	{
		throw new InvalidOperationException();
	}

	public IEnumerator<GeckoHistoryEntry> GetEnumerator()
	{
		GeckoHistoryEntry[] entry = new GeckoHistoryEntry[Count];
		CopyTo(entry, 0);
		for (int i = 0; i < entry.Length; i++)
		{
			yield return entry[i];
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		using IEnumerator<GeckoHistoryEntry> enumerator = GetEnumerator();
		while (enumerator.MoveNext())
		{
			yield return enumerator.Current;
		}
	}
}
