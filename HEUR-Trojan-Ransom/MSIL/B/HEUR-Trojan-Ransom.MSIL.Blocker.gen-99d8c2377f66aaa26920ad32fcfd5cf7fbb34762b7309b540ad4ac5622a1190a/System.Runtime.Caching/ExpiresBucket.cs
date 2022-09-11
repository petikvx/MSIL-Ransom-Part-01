namespace System.Runtime.Caching;

internal sealed class ExpiresBucket
{
	internal const int NUM_ENTRIES = 127;

	private const int LENGTH_ENTRIES = 128;

	private const int MIN_PAGES_INCREMENT = 10;

	private const int MAX_PAGES_INCREMENT = 340;

	private const double MIN_LOAD_FACTOR = 0.5;

	private const int COUNTS_LENGTH = 4;

	private static readonly TimeSpan COUNT_INTERVAL;

	private readonly CacheExpires _cacheExpires;

	private readonly byte _bucket;

	private ExpiresPage[] _pages;

	private int _cEntriesInUse;

	private int _cPagesInUse;

	private int _cEntriesInFlush;

	private int _minEntriesInUse;

	private ExpiresPageList _freePageList;

	private ExpiresPageList _freeEntryList;

	private bool _blockReduce;

	private DateTime _utcMinExpires;

	private int[] _counts;

	private DateTime _utcLastCountReset;

	internal ExpiresBucket(CacheExpires cacheExpires, byte bucket, DateTime utcNow)
	{
		_cacheExpires = cacheExpires;
		_bucket = bucket;
		_counts = new int[4];
		ResetCounts(utcNow);
		InitZeroPages();
	}

	private void InitZeroPages()
	{
		_pages = null;
		_minEntriesInUse = -1;
		_freePageList._head = -1;
		_freePageList._tail = -1;
		_freeEntryList._head = -1;
		_freeEntryList._tail = -1;
	}

	private void ResetCounts(DateTime utcNow)
	{
		_utcLastCountReset = utcNow;
		_utcMinExpires = DateTime.MaxValue;
		for (int i = 0; i < _counts.Length; i++)
		{
			_counts[i] = 0;
		}
	}

	private int GetCountIndex(DateTime utcExpires)
	{
		long ticks = (utcExpires - _utcLastCountReset).Ticks;
		TimeSpan cOUNT_INTERVAL = COUNT_INTERVAL;
		return Math.Max(0, (int)(ticks / cOUNT_INTERVAL.Ticks));
	}

	private void AddCount(DateTime utcExpires)
	{
		int countIndex = GetCountIndex(utcExpires);
		for (int num = _counts.Length - 1; num >= countIndex; num--)
		{
			_counts[num]++;
		}
		if (utcExpires < _utcMinExpires)
		{
			_utcMinExpires = utcExpires;
		}
	}

	private void RemoveCount(DateTime utcExpires)
	{
		int countIndex = GetCountIndex(utcExpires);
		for (int num = _counts.Length - 1; num >= countIndex; num--)
		{
			_counts[num]--;
		}
	}

	private int GetExpiresCount(DateTime utcExpires)
	{
		if (utcExpires < _utcMinExpires)
		{
			return 0;
		}
		int countIndex = GetCountIndex(utcExpires);
		if (countIndex >= _counts.Length)
		{
			return _cEntriesInUse;
		}
		return _counts[countIndex];
	}

	private void AddToListHead(int pageIndex, ref ExpiresPageList list)
	{
		_pages[pageIndex]._pagePrev = -1;
		_pages[pageIndex]._pageNext = list._head;
		if (list._head != -1)
		{
			_pages[list._head]._pagePrev = pageIndex;
		}
		else
		{
			list._tail = pageIndex;
		}
		list._head = pageIndex;
	}

	private void AddToListTail(int pageIndex, ref ExpiresPageList list)
	{
		_pages[pageIndex]._pageNext = -1;
		_pages[pageIndex]._pagePrev = list._tail;
		if (list._tail != -1)
		{
			_pages[list._tail]._pageNext = pageIndex;
		}
		else
		{
			list._head = pageIndex;
		}
		list._tail = pageIndex;
	}

	private int RemoveFromListHead(ref ExpiresPageList list)
	{
		int head = list._head;
		RemoveFromList(head, ref list);
		return head;
	}

	private void RemoveFromList(int pageIndex, ref ExpiresPageList list)
	{
		if (_pages[pageIndex]._pagePrev != -1)
		{
			_pages[_pages[pageIndex]._pagePrev]._pageNext = _pages[pageIndex]._pageNext;
		}
		else
		{
			list._head = _pages[pageIndex]._pageNext;
		}
		if (_pages[pageIndex]._pageNext != -1)
		{
			_pages[_pages[pageIndex]._pageNext]._pagePrev = _pages[pageIndex]._pagePrev;
		}
		else
		{
			list._tail = _pages[pageIndex]._pagePrev;
		}
		_pages[pageIndex]._pagePrev = -1;
		_pages[pageIndex]._pageNext = -1;
	}

	private void MoveToListHead(int pageIndex, ref ExpiresPageList list)
	{
		if (list._head != pageIndex)
		{
			RemoveFromList(pageIndex, ref list);
			AddToListHead(pageIndex, ref list);
		}
	}

	private void MoveToListTail(int pageIndex, ref ExpiresPageList list)
	{
		if (list._tail != pageIndex)
		{
			RemoveFromList(pageIndex, ref list);
			AddToListTail(pageIndex, ref list);
		}
	}

	private void UpdateMinEntries()
	{
		if (_cPagesInUse <= 1)
		{
			_minEntriesInUse = -1;
			return;
		}
		int num = _cPagesInUse * 127;
		_minEntriesInUse = (int)((double)num * 0.5);
		if (_minEntriesInUse - 1 > (_cPagesInUse - 1) * 127)
		{
			_minEntriesInUse = -1;
		}
	}

	private void RemovePage(int pageIndex)
	{
		RemoveFromList(pageIndex, ref _freeEntryList);
		AddToListHead(pageIndex, ref _freePageList);
		_pages[pageIndex]._entries = null;
		_cPagesInUse--;
		if (_cPagesInUse == 0)
		{
			InitZeroPages();
		}
		else
		{
			UpdateMinEntries();
		}
	}

	private ExpiresEntryRef GetFreeExpiresEntry()
	{
		int head = _freeEntryList._head;
		ExpiresEntry[] entries = _pages[head]._entries;
		int index = entries[0]._next.Index;
		entries[0]._next = entries[index]._next;
		entries[0]._cFree--;
		if (entries[0]._cFree == 0)
		{
			RemoveFromList(head, ref _freeEntryList);
		}
		return new ExpiresEntryRef(head, index);
	}

	private void AddExpiresEntryToFreeList(ExpiresEntryRef entryRef)
	{
		ExpiresEntry[] entries = _pages[entryRef.PageIndex]._entries;
		int index = entryRef.Index;
		entries[index]._cFree = 0;
		entries[index]._next = entries[0]._next;
		entries[0]._next = entryRef;
		_cEntriesInUse--;
		int pageIndex = entryRef.PageIndex;
		entries[0]._cFree++;
		if (entries[0]._cFree == 1)
		{
			AddToListHead(pageIndex, ref _freeEntryList);
		}
		else if (entries[0]._cFree == 127)
		{
			RemovePage(pageIndex);
		}
	}

	private void Expand()
	{
		if (_freePageList._head == -1)
		{
			int num = ((_pages != null) ? _pages.Length : 0);
			int val = num * 2;
			val = Math.Max(num + 10, val);
			val = Math.Min(val, num + 340);
			ExpiresPage[] array = new ExpiresPage[val];
			for (int i = 0; i < num; i++)
			{
				array[i] = _pages[i];
			}
			for (int j = num; j < array.Length; j++)
			{
				array[j]._pagePrev = j - 1;
				array[j]._pageNext = j + 1;
			}
			array[num]._pagePrev = -1;
			array[^1]._pageNext = -1;
			_freePageList._head = num;
			_freePageList._tail = array.Length - 1;
			_pages = array;
		}
		int num2 = RemoveFromListHead(ref _freePageList);
		AddToListHead(num2, ref _freeEntryList);
		ExpiresEntry[] array2 = new ExpiresEntry[128];
		array2[0]._cFree = 127;
		for (int k = 0; k < array2.Length - 1; k++)
		{
			array2[k]._next = new ExpiresEntryRef(num2, k + 1);
		}
		array2[^1]._next = ExpiresEntryRef.INVALID;
		_pages[num2]._entries = array2;
		_cPagesInUse++;
		UpdateMinEntries();
	}

	private void Reduce()
	{
		if (_cEntriesInUse >= _minEntriesInUse || _blockReduce)
		{
			return;
		}
		int num = 63;
		int tail = _freeEntryList._tail;
		int num2 = _freeEntryList._head;
		while (true)
		{
			int pageNext = _pages[num2]._pageNext;
			if (_pages[num2]._entries[0]._cFree <= num)
			{
				MoveToListHead(num2, ref _freeEntryList);
			}
			else
			{
				MoveToListTail(num2, ref _freeEntryList);
			}
			if (num2 == tail)
			{
				break;
			}
			num2 = pageNext;
		}
		while (_freeEntryList._tail != -1)
		{
			ExpiresEntry[] entries = _pages[_freeEntryList._tail]._entries;
			int num3 = _cPagesInUse * 127 - entries[0]._cFree - _cEntriesInUse;
			if (num3 < 127 - entries[0]._cFree)
			{
				break;
			}
			for (int i = 1; i < entries.Length; i++)
			{
				if (entries[i]._cacheEntry != null)
				{
					ExpiresEntryRef freeExpiresEntry = GetFreeExpiresEntry();
					MemoryCacheEntry cacheEntry = entries[i]._cacheEntry;
					cacheEntry.ExpiresEntryRef = freeExpiresEntry;
					ExpiresEntry[] entries2 = _pages[freeExpiresEntry.PageIndex]._entries;
					entries2[freeExpiresEntry.Index] = entries[i];
					entries[0]._cFree++;
				}
			}
			RemovePage(_freeEntryList._tail);
		}
	}

	internal void AddCacheEntry(MemoryCacheEntry cacheEntry)
	{
		lock (this)
		{
			if ((cacheEntry.State & (EntryState)3) == 0)
			{
				return;
			}
			ExpiresEntryRef expiresEntryRef = cacheEntry.ExpiresEntryRef;
			if (cacheEntry.ExpiresBucket == byte.MaxValue && expiresEntryRef.IsInvalid)
			{
				if (_freeEntryList._head == -1)
				{
					Expand();
				}
				ExpiresEntryRef freeExpiresEntry = GetFreeExpiresEntry();
				cacheEntry.ExpiresBucket = _bucket;
				cacheEntry.ExpiresEntryRef = freeExpiresEntry;
				ExpiresEntry[] entries = _pages[freeExpiresEntry.PageIndex]._entries;
				int index = freeExpiresEntry.Index;
				entries[index]._cacheEntry = cacheEntry;
				entries[index]._utcExpires = cacheEntry.UtcAbsExp;
				AddCount(cacheEntry.UtcAbsExp);
				_cEntriesInUse++;
				if ((cacheEntry.State & (EntryState)3) == 0)
				{
					RemoveCacheEntryNoLock(cacheEntry);
				}
			}
		}
	}

	private void RemoveCacheEntryNoLock(MemoryCacheEntry cacheEntry)
	{
		ExpiresEntryRef expiresEntryRef = cacheEntry.ExpiresEntryRef;
		if (cacheEntry.ExpiresBucket == _bucket && !expiresEntryRef.IsInvalid)
		{
			ExpiresEntry[] entries = _pages[expiresEntryRef.PageIndex]._entries;
			int index = expiresEntryRef.Index;
			RemoveCount(entries[index]._utcExpires);
			cacheEntry.ExpiresBucket = byte.MaxValue;
			cacheEntry.ExpiresEntryRef = ExpiresEntryRef.INVALID;
			entries[index]._cacheEntry = null;
			AddExpiresEntryToFreeList(expiresEntryRef);
			if (_cEntriesInUse == 0)
			{
				ResetCounts(DateTime.UtcNow);
			}
			Reduce();
		}
	}

	internal void RemoveCacheEntry(MemoryCacheEntry cacheEntry)
	{
		lock (this)
		{
			RemoveCacheEntryNoLock(cacheEntry);
		}
	}

	internal void UtcUpdateCacheEntry(MemoryCacheEntry cacheEntry, DateTime utcExpires)
	{
		lock (this)
		{
			ExpiresEntryRef expiresEntryRef = cacheEntry.ExpiresEntryRef;
			if (cacheEntry.ExpiresBucket == _bucket && !expiresEntryRef.IsInvalid)
			{
				ExpiresEntry[] entries = _pages[expiresEntryRef.PageIndex]._entries;
				int index = expiresEntryRef.Index;
				RemoveCount(entries[index]._utcExpires);
				AddCount(utcExpires);
				entries[index]._utcExpires = utcExpires;
				cacheEntry.UtcAbsExp = utcExpires;
			}
		}
	}

	internal int FlushExpiredItems(DateTime utcNow, bool useInsertBlock)
	{
		if (_cEntriesInUse != 0 && GetExpiresCount(utcNow) != 0)
		{
			ExpiresEntryRef expiresEntryRef = ExpiresEntryRef.INVALID;
			int num = 0;
			try
			{
				if (useInsertBlock)
				{
					_cacheExpires.MemoryCacheStore.BlockInsert();
				}
				lock (this)
				{
					if (_cEntriesInUse == 0 || GetExpiresCount(utcNow) == 0)
					{
						return 0;
					}
					ResetCounts(utcNow);
					int num2 = _cPagesInUse;
					for (int i = 0; i < _pages.Length; i++)
					{
						ExpiresEntry[] entries = _pages[i]._entries;
						if (entries == null)
						{
							continue;
						}
						int num3 = 127 - entries[0]._cFree;
						for (int j = 1; j < entries.Length; j++)
						{
							MemoryCacheEntry cacheEntry = entries[j]._cacheEntry;
							if (cacheEntry != null)
							{
								if (entries[j]._utcExpires > utcNow)
								{
									AddCount(entries[j]._utcExpires);
								}
								else
								{
									cacheEntry.ExpiresBucket = byte.MaxValue;
									cacheEntry.ExpiresEntryRef = ExpiresEntryRef.INVALID;
									entries[j]._cFree = 1;
									entries[j]._next = expiresEntryRef;
									expiresEntryRef = new ExpiresEntryRef(i, j);
									num++;
									_cEntriesInFlush++;
								}
								num3--;
								if (num3 == 0)
								{
									break;
								}
							}
						}
						num2--;
						if (num2 == 0)
						{
							break;
						}
					}
					if (num == 0)
					{
						return 0;
					}
					_blockReduce = true;
				}
			}
			finally
			{
				if (useInsertBlock)
				{
					_cacheExpires.MemoryCacheStore.UnblockInsert();
				}
			}
			MemoryCacheStore memoryCacheStore = _cacheExpires.MemoryCacheStore;
			ExpiresEntryRef expiresEntryRef2 = expiresEntryRef;
			while (!expiresEntryRef2.IsInvalid)
			{
				ExpiresEntry[] entries = _pages[expiresEntryRef2.PageIndex]._entries;
				int index = expiresEntryRef2.Index;
				ExpiresEntryRef next = entries[index]._next;
				MemoryCacheEntry cacheEntry = entries[index]._cacheEntry;
				entries[index]._cacheEntry = null;
				memoryCacheStore.Remove(cacheEntry, cacheEntry, CacheEntryRemovedReason.Expired);
				expiresEntryRef2 = next;
			}
			try
			{
				if (useInsertBlock)
				{
					_cacheExpires.MemoryCacheStore.BlockInsert();
				}
				lock (this)
				{
					expiresEntryRef2 = expiresEntryRef;
					while (!expiresEntryRef2.IsInvalid)
					{
						ExpiresEntry[] entries = _pages[expiresEntryRef2.PageIndex]._entries;
						int index = expiresEntryRef2.Index;
						ExpiresEntryRef next = entries[index]._next;
						_cEntriesInFlush--;
						AddExpiresEntryToFreeList(expiresEntryRef2);
						expiresEntryRef2 = next;
					}
					_blockReduce = false;
					Reduce();
					return num;
				}
			}
			finally
			{
				if (useInsertBlock)
				{
					_cacheExpires.MemoryCacheStore.UnblockInsert();
				}
			}
		}
		return 0;
	}

	static ExpiresBucket()
	{
		TimeSpan tsPerBucket = CacheExpires._tsPerBucket;
		COUNT_INTERVAL = new TimeSpan(tsPerBucket.Ticks / 4L);
	}
}
