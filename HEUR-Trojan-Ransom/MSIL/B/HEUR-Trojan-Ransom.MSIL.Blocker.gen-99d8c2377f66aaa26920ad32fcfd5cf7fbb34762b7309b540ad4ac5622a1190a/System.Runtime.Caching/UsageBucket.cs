namespace System.Runtime.Caching;

internal sealed class UsageBucket
{
	internal const int NUM_ENTRIES = 127;

	private const int LENGTH_ENTRIES = 128;

	private const int MIN_PAGES_INCREMENT = 10;

	private const int MAX_PAGES_INCREMENT = 340;

	private const double MIN_LOAD_FACTOR = 0.5;

	private CacheUsage _cacheUsage;

	private byte _bucket;

	private UsagePage[] _pages;

	private int _cEntriesInUse;

	private int _cPagesInUse;

	private int _cEntriesInFlush;

	private int _minEntriesInUse;

	private UsagePageList _freePageList;

	private UsagePageList _freeEntryList;

	private UsageEntryRef _lastRefHead;

	private UsageEntryRef _lastRefTail;

	private UsageEntryRef _addRef2Head;

	private bool _blockReduce;

	internal UsageBucket(CacheUsage cacheUsage, byte bucket)
	{
		_cacheUsage = cacheUsage;
		_bucket = bucket;
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

	private void AddToListHead(int pageIndex, ref UsagePageList list)
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

	private void AddToListTail(int pageIndex, ref UsagePageList list)
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

	private int RemoveFromListHead(ref UsagePageList list)
	{
		int head = list._head;
		RemoveFromList(head, ref list);
		return head;
	}

	private void RemoveFromList(int pageIndex, ref UsagePageList list)
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

	private void MoveToListHead(int pageIndex, ref UsagePageList list)
	{
		if (list._head != pageIndex)
		{
			RemoveFromList(pageIndex, ref list);
			AddToListHead(pageIndex, ref list);
		}
	}

	private void MoveToListTail(int pageIndex, ref UsagePageList list)
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

	private UsageEntryRef GetFreeUsageEntry()
	{
		int head = _freeEntryList._head;
		UsageEntry[] entries = _pages[head]._entries;
		int ref1Index = entries[0]._ref1._next.Ref1Index;
		entries[0]._ref1._next = entries[ref1Index]._ref1._next;
		entries[0]._cFree--;
		if (entries[0]._cFree == 0)
		{
			RemoveFromList(head, ref _freeEntryList);
		}
		return new UsageEntryRef(head, ref1Index);
	}

	private void AddUsageEntryToFreeList(UsageEntryRef entryRef)
	{
		UsageEntry[] entries = _pages[entryRef.PageIndex]._entries;
		int ref1Index = entryRef.Ref1Index;
		entries[ref1Index]._utcDate = DateTime.MinValue;
		entries[ref1Index]._ref1._prev = UsageEntryRef.INVALID;
		entries[ref1Index]._ref2._next = UsageEntryRef.INVALID;
		entries[ref1Index]._ref2._prev = UsageEntryRef.INVALID;
		entries[ref1Index]._ref1._next = entries[0]._ref1._next;
		entries[0]._ref1._next = entryRef;
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
			UsagePage[] array = new UsagePage[val];
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
		UsageEntry[] array2 = new UsageEntry[128];
		array2[0]._cFree = 127;
		for (int k = 0; k < array2.Length - 1; k++)
		{
			array2[k]._ref1._next = new UsageEntryRef(num2, k + 1);
		}
		array2[^1]._ref1._next = UsageEntryRef.INVALID;
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
			UsageEntry[] entries = _pages[_freeEntryList._tail]._entries;
			int num3 = _cPagesInUse * 127 - entries[0]._cFree - _cEntriesInUse;
			if (num3 < 127 - entries[0]._cFree)
			{
				break;
			}
			for (int i = 1; i < entries.Length; i++)
			{
				if (entries[i]._cacheEntry != null)
				{
					UsageEntryRef freeUsageEntry = GetFreeUsageEntry();
					UsageEntryRef usageEntryRef = new UsageEntryRef(freeUsageEntry.PageIndex, -freeUsageEntry.Ref1Index);
					UsageEntryRef usageEntryRef2 = new UsageEntryRef(_freeEntryList._tail, i);
					UsageEntryRef usageEntryRef3 = new UsageEntryRef(usageEntryRef2.PageIndex, -usageEntryRef2.Ref1Index);
					MemoryCacheEntry cacheEntry = entries[i]._cacheEntry;
					cacheEntry.UsageEntryRef = freeUsageEntry;
					UsageEntry[] entries2 = _pages[freeUsageEntry.PageIndex]._entries;
					entries2[freeUsageEntry.Ref1Index] = entries[i];
					entries[0]._cFree++;
					UsageEntryRef prev = entries2[freeUsageEntry.Ref1Index]._ref1._prev;
					UsageEntryRef usageEntryRef4 = entries2[freeUsageEntry.Ref1Index]._ref1._next;
					if (usageEntryRef4 == usageEntryRef3)
					{
						usageEntryRef4 = usageEntryRef;
					}
					if (prev.IsRef1)
					{
						_pages[prev.PageIndex]._entries[prev.Ref1Index]._ref1._next = freeUsageEntry;
					}
					else if (prev.IsRef2)
					{
						_pages[prev.PageIndex]._entries[prev.Ref2Index]._ref2._next = freeUsageEntry;
					}
					else
					{
						_lastRefHead = freeUsageEntry;
					}
					if (usageEntryRef4.IsRef1)
					{
						_pages[usageEntryRef4.PageIndex]._entries[usageEntryRef4.Ref1Index]._ref1._prev = freeUsageEntry;
					}
					else if (usageEntryRef4.IsRef2)
					{
						_pages[usageEntryRef4.PageIndex]._entries[usageEntryRef4.Ref2Index]._ref2._prev = freeUsageEntry;
					}
					else
					{
						_lastRefTail = freeUsageEntry;
					}
					prev = entries2[freeUsageEntry.Ref1Index]._ref2._prev;
					if (prev == usageEntryRef2)
					{
						prev = freeUsageEntry;
					}
					usageEntryRef4 = entries2[freeUsageEntry.Ref1Index]._ref2._next;
					if (prev.IsRef1)
					{
						_pages[prev.PageIndex]._entries[prev.Ref1Index]._ref1._next = usageEntryRef;
					}
					else if (prev.IsRef2)
					{
						_pages[prev.PageIndex]._entries[prev.Ref2Index]._ref2._next = usageEntryRef;
					}
					else
					{
						_lastRefHead = usageEntryRef;
					}
					if (usageEntryRef4.IsRef1)
					{
						_pages[usageEntryRef4.PageIndex]._entries[usageEntryRef4.Ref1Index]._ref1._prev = usageEntryRef;
					}
					else if (usageEntryRef4.IsRef2)
					{
						_pages[usageEntryRef4.PageIndex]._entries[usageEntryRef4.Ref2Index]._ref2._prev = usageEntryRef;
					}
					else
					{
						_lastRefTail = usageEntryRef;
					}
					if (_addRef2Head == usageEntryRef3)
					{
						_addRef2Head = usageEntryRef;
					}
				}
			}
			RemovePage(_freeEntryList._tail);
		}
	}

	internal void AddCacheEntry(MemoryCacheEntry cacheEntry)
	{
		lock (this)
		{
			if (_freeEntryList._head == -1)
			{
				Expand();
			}
			UsageEntryRef freeUsageEntry = GetFreeUsageEntry();
			UsageEntryRef usageEntryRef = new UsageEntryRef(freeUsageEntry.PageIndex, -freeUsageEntry.Ref1Index);
			cacheEntry.UsageEntryRef = freeUsageEntry;
			UsageEntry[] entries = _pages[freeUsageEntry.PageIndex]._entries;
			int ref1Index = freeUsageEntry.Ref1Index;
			entries[ref1Index]._cacheEntry = cacheEntry;
			entries[ref1Index]._utcDate = DateTime.UtcNow;
			entries[ref1Index]._ref1._prev = UsageEntryRef.INVALID;
			entries[ref1Index]._ref2._next = _addRef2Head;
			if (_lastRefHead.IsInvalid)
			{
				entries[ref1Index]._ref1._next = usageEntryRef;
				entries[ref1Index]._ref2._prev = freeUsageEntry;
				_lastRefTail = usageEntryRef;
			}
			else
			{
				entries[ref1Index]._ref1._next = _lastRefHead;
				if (_lastRefHead.IsRef1)
				{
					_pages[_lastRefHead.PageIndex]._entries[_lastRefHead.Ref1Index]._ref1._prev = freeUsageEntry;
				}
				else if (_lastRefHead.IsRef2)
				{
					_pages[_lastRefHead.PageIndex]._entries[_lastRefHead.Ref2Index]._ref2._prev = freeUsageEntry;
				}
				else
				{
					_lastRefTail = freeUsageEntry;
				}
				UsageEntryRef prev;
				UsageEntryRef usageEntryRef2;
				if (_addRef2Head.IsInvalid)
				{
					prev = _lastRefTail;
					usageEntryRef2 = UsageEntryRef.INVALID;
				}
				else
				{
					prev = _pages[_addRef2Head.PageIndex]._entries[_addRef2Head.Ref2Index]._ref2._prev;
					usageEntryRef2 = _addRef2Head;
				}
				entries[ref1Index]._ref2._prev = prev;
				if (prev.IsRef1)
				{
					_pages[prev.PageIndex]._entries[prev.Ref1Index]._ref1._next = usageEntryRef;
				}
				else if (prev.IsRef2)
				{
					_pages[prev.PageIndex]._entries[prev.Ref2Index]._ref2._next = usageEntryRef;
				}
				else
				{
					_lastRefHead = usageEntryRef;
				}
				if (usageEntryRef2.IsRef1)
				{
					_pages[usageEntryRef2.PageIndex]._entries[usageEntryRef2.Ref1Index]._ref1._prev = usageEntryRef;
				}
				else if (usageEntryRef2.IsRef2)
				{
					_pages[usageEntryRef2.PageIndex]._entries[usageEntryRef2.Ref2Index]._ref2._prev = usageEntryRef;
				}
				else
				{
					_lastRefTail = usageEntryRef;
				}
			}
			_lastRefHead = freeUsageEntry;
			_addRef2Head = usageEntryRef;
			_cEntriesInUse++;
		}
	}

	private void RemoveEntryFromLastRefList(UsageEntryRef entryRef)
	{
		UsageEntry[] entries = _pages[entryRef.PageIndex]._entries;
		int ref1Index = entryRef.Ref1Index;
		UsageEntryRef prev = entries[ref1Index]._ref1._prev;
		UsageEntryRef next = entries[ref1Index]._ref1._next;
		if (prev.IsRef1)
		{
			_pages[prev.PageIndex]._entries[prev.Ref1Index]._ref1._next = next;
		}
		else if (prev.IsRef2)
		{
			_pages[prev.PageIndex]._entries[prev.Ref2Index]._ref2._next = next;
		}
		else
		{
			_lastRefHead = next;
		}
		if (next.IsRef1)
		{
			_pages[next.PageIndex]._entries[next.Ref1Index]._ref1._prev = prev;
		}
		else if (next.IsRef2)
		{
			_pages[next.PageIndex]._entries[next.Ref2Index]._ref2._prev = prev;
		}
		else
		{
			_lastRefTail = prev;
		}
		prev = entries[ref1Index]._ref2._prev;
		next = entries[ref1Index]._ref2._next;
		UsageEntryRef usageEntryRef = new UsageEntryRef(entryRef.PageIndex, -entryRef.Ref1Index);
		if (prev.IsRef1)
		{
			_pages[prev.PageIndex]._entries[prev.Ref1Index]._ref1._next = next;
		}
		else if (prev.IsRef2)
		{
			_pages[prev.PageIndex]._entries[prev.Ref2Index]._ref2._next = next;
		}
		else
		{
			_lastRefHead = next;
		}
		if (next.IsRef1)
		{
			_pages[next.PageIndex]._entries[next.Ref1Index]._ref1._prev = prev;
		}
		else if (next.IsRef2)
		{
			_pages[next.PageIndex]._entries[next.Ref2Index]._ref2._prev = prev;
		}
		else
		{
			_lastRefTail = prev;
		}
		if (_addRef2Head == usageEntryRef)
		{
			_addRef2Head = next;
		}
	}

	internal void RemoveCacheEntry(MemoryCacheEntry cacheEntry)
	{
		lock (this)
		{
			UsageEntryRef usageEntryRef = cacheEntry.UsageEntryRef;
			if (!usageEntryRef.IsInvalid)
			{
				UsageEntry[] entries = _pages[usageEntryRef.PageIndex]._entries;
				int ref1Index = usageEntryRef.Ref1Index;
				cacheEntry.UsageEntryRef = UsageEntryRef.INVALID;
				entries[ref1Index]._cacheEntry = null;
				RemoveEntryFromLastRefList(usageEntryRef);
				AddUsageEntryToFreeList(usageEntryRef);
				Reduce();
			}
		}
	}

	internal void UpdateCacheEntry(MemoryCacheEntry cacheEntry)
	{
		lock (this)
		{
			UsageEntryRef usageEntryRef = cacheEntry.UsageEntryRef;
			if (!usageEntryRef.IsInvalid)
			{
				UsageEntry[] entries = _pages[usageEntryRef.PageIndex]._entries;
				int ref1Index = usageEntryRef.Ref1Index;
				UsageEntryRef usageEntryRef2 = new UsageEntryRef(usageEntryRef.PageIndex, -usageEntryRef.Ref1Index);
				UsageEntryRef prev = entries[ref1Index]._ref2._prev;
				UsageEntryRef next = entries[ref1Index]._ref2._next;
				if (prev.IsRef1)
				{
					_pages[prev.PageIndex]._entries[prev.Ref1Index]._ref1._next = next;
				}
				else if (prev.IsRef2)
				{
					_pages[prev.PageIndex]._entries[prev.Ref2Index]._ref2._next = next;
				}
				else
				{
					_lastRefHead = next;
				}
				if (next.IsRef1)
				{
					_pages[next.PageIndex]._entries[next.Ref1Index]._ref1._prev = prev;
				}
				else if (next.IsRef2)
				{
					_pages[next.PageIndex]._entries[next.Ref2Index]._ref2._prev = prev;
				}
				else
				{
					_lastRefTail = prev;
				}
				if (_addRef2Head == usageEntryRef2)
				{
					_addRef2Head = next;
				}
				entries[ref1Index]._ref2 = entries[ref1Index]._ref1;
				prev = entries[ref1Index]._ref2._prev;
				next = entries[ref1Index]._ref2._next;
				if (prev.IsRef1)
				{
					_pages[prev.PageIndex]._entries[prev.Ref1Index]._ref1._next = usageEntryRef2;
				}
				else if (prev.IsRef2)
				{
					_pages[prev.PageIndex]._entries[prev.Ref2Index]._ref2._next = usageEntryRef2;
				}
				else
				{
					_lastRefHead = usageEntryRef2;
				}
				if (next.IsRef1)
				{
					_pages[next.PageIndex]._entries[next.Ref1Index]._ref1._prev = usageEntryRef2;
				}
				else if (next.IsRef2)
				{
					_pages[next.PageIndex]._entries[next.Ref2Index]._ref2._prev = usageEntryRef2;
				}
				else
				{
					_lastRefTail = usageEntryRef2;
				}
				entries[ref1Index]._ref1._prev = UsageEntryRef.INVALID;
				entries[ref1Index]._ref1._next = _lastRefHead;
				if (_lastRefHead.IsRef1)
				{
					_pages[_lastRefHead.PageIndex]._entries[_lastRefHead.Ref1Index]._ref1._prev = usageEntryRef;
				}
				else if (_lastRefHead.IsRef2)
				{
					_pages[_lastRefHead.PageIndex]._entries[_lastRefHead.Ref2Index]._ref2._prev = usageEntryRef;
				}
				else
				{
					_lastRefTail = usageEntryRef;
				}
				_lastRefHead = usageEntryRef;
			}
		}
	}

	internal int FlushUnderUsedItems(int maxFlush, bool force)
	{
		if (_cEntriesInUse == 0)
		{
			return 0;
		}
		UsageEntryRef usageEntryRef = UsageEntryRef.INVALID;
		int num = 0;
		try
		{
			_cacheUsage.MemoryCacheStore.BlockInsert();
			lock (this)
			{
				if (_cEntriesInUse == 0)
				{
					return 0;
				}
				DateTime utcNow = DateTime.UtcNow;
				UsageEntryRef prev;
				for (UsageEntryRef usageEntryRef2 = _lastRefTail; _cEntriesInFlush < maxFlush && !usageEntryRef2.IsInvalid; usageEntryRef2 = prev)
				{
					prev = _pages[usageEntryRef2.PageIndex]._entries[usageEntryRef2.Ref2Index]._ref2._prev;
					while (prev.IsRef1)
					{
						prev = _pages[prev.PageIndex]._entries[prev.Ref1Index]._ref1._prev;
					}
					UsageEntry[] entries = _pages[usageEntryRef2.PageIndex]._entries;
					int ref2Index = usageEntryRef2.Ref2Index;
					if (!force)
					{
						DateTime utcDate = entries[ref2Index]._utcDate;
						if (utcNow - utcDate <= CacheUsage.NEWADD_INTERVAL && utcNow >= utcDate)
						{
							continue;
						}
					}
					UsageEntryRef usageEntryRef3 = new UsageEntryRef(usageEntryRef2.PageIndex, usageEntryRef2.Ref2Index);
					MemoryCacheEntry cacheEntry = entries[ref2Index]._cacheEntry;
					cacheEntry.UsageEntryRef = UsageEntryRef.INVALID;
					RemoveEntryFromLastRefList(usageEntryRef3);
					entries[ref2Index]._ref1._next = usageEntryRef;
					usageEntryRef = usageEntryRef3;
					num++;
					_cEntriesInFlush++;
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
			_cacheUsage.MemoryCacheStore.UnblockInsert();
		}
		MemoryCacheStore memoryCacheStore = _cacheUsage.MemoryCacheStore;
		UsageEntryRef usageEntryRef4 = usageEntryRef;
		while (!usageEntryRef4.IsInvalid)
		{
			UsageEntry[] entries = _pages[usageEntryRef4.PageIndex]._entries;
			int ref2Index = usageEntryRef4.Ref1Index;
			UsageEntryRef next = entries[ref2Index]._ref1._next;
			MemoryCacheEntry cacheEntry = entries[ref2Index]._cacheEntry;
			entries[ref2Index]._cacheEntry = null;
			memoryCacheStore.Remove(cacheEntry, cacheEntry, CacheEntryRemovedReason.Evicted);
			usageEntryRef4 = next;
		}
		try
		{
			_cacheUsage.MemoryCacheStore.BlockInsert();
			lock (this)
			{
				usageEntryRef4 = usageEntryRef;
				while (!usageEntryRef4.IsInvalid)
				{
					UsageEntry[] entries = _pages[usageEntryRef4.PageIndex]._entries;
					int ref2Index = usageEntryRef4.Ref1Index;
					UsageEntryRef next = entries[ref2Index]._ref1._next;
					_cEntriesInFlush--;
					AddUsageEntryToFreeList(usageEntryRef4);
					usageEntryRef4 = next;
				}
				_blockReduce = false;
				Reduce();
				return num;
			}
		}
		finally
		{
			_cacheUsage.MemoryCacheStore.UnblockInsert();
		}
	}
}
