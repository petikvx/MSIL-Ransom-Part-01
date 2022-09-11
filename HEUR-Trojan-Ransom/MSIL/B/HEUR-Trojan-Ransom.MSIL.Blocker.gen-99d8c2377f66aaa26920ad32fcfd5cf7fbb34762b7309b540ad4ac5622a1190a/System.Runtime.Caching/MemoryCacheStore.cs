using System.Collections;
using System.Threading;

namespace System.Runtime.Caching;

internal sealed class MemoryCacheStore : IDisposable
{
	private const int INSERT_BLOCK_WAIT = 10000;

	private const int MAX_COUNT = 1073741823;

	private Hashtable _entries;

	private object _entriesLock;

	private CacheExpires _expires;

	private CacheUsage _usage;

	private int _disposed;

	private ManualResetEvent _insertBlock;

	private volatile bool _useInsertBlock;

	private MemoryCache _cache;

	private PerfCounters _perfCounters;

	internal CacheUsage Usage => _usage;

	internal int Count => _entries.Count;

	internal MemoryCacheStore(MemoryCache cache, PerfCounters perfCounters)
	{
		_cache = cache;
		_perfCounters = perfCounters;
		_entries = new Hashtable(new MemoryCacheEqualityComparer());
		_entriesLock = new object();
		_expires = new CacheExpires(this);
		_usage = new CacheUsage(this);
		InitDisposableMembers();
	}

	private void AddToCache(MemoryCacheEntry entry)
	{
		if (entry == null)
		{
			return;
		}
		if (entry.HasExpiration())
		{
			_expires.Add(entry);
		}
		if (entry.HasUsage() && (!entry.HasExpiration() || entry.UtcAbsExp - DateTime.UtcNow >= CacheUsage.MIN_LIFETIME_FOR_USAGE))
		{
			_usage.Add(entry);
		}
		if (!entry.CompareExchangeState(EntryState.AddedToCache, EntryState.AddingToCache))
		{
			if (entry.InExpires())
			{
				_expires.Remove(entry);
			}
			if (entry.InUsage())
			{
				_usage.Remove(entry);
			}
		}
		entry.CallNotifyOnChanged();
		if (_perfCounters != null)
		{
			_perfCounters.Increment(PerfCounterName.Entries);
			_perfCounters.Increment(PerfCounterName.Turnover);
		}
	}

	private void InitDisposableMembers()
	{
		_insertBlock = new ManualResetEvent(initialState: true);
		_expires.EnableExpirationTimer(enable: true);
	}

	private void RemoveFromCache(MemoryCacheEntry entry, CacheEntryRemovedReason reason, bool delayRelease = false)
	{
		if (entry != null)
		{
			if (entry.InExpires())
			{
				_expires.Remove(entry);
			}
			if (entry.InUsage())
			{
				_usage.Remove(entry);
			}
			entry.State = EntryState.RemovedFromCache;
			if (!delayRelease)
			{
				entry.Release(_cache, reason);
			}
			if (_perfCounters != null)
			{
				_perfCounters.Decrement(PerfCounterName.Entries);
				_perfCounters.Increment(PerfCounterName.Turnover);
			}
		}
	}

	internal void UpdateExpAndUsage(MemoryCacheEntry entry, bool updatePerfCounters = true)
	{
		if (entry != null)
		{
			if (entry.InUsage() || entry.SlidingExp > TimeSpan.Zero)
			{
				DateTime utcNow = DateTime.UtcNow;
				entry.UpdateSlidingExp(utcNow, _expires);
				entry.UpdateUsage(utcNow, _usage);
			}
			entry.UpdateSlidingExpForUpdateSentinel();
			if (updatePerfCounters && _perfCounters != null)
			{
				_perfCounters.Increment(PerfCounterName.Hits);
				_perfCounters.Increment(PerfCounterName.HitRatio);
				_perfCounters.Increment(PerfCounterName.HitRatioBase);
			}
		}
		else if (updatePerfCounters && _perfCounters != null)
		{
			_perfCounters.Increment(PerfCounterName.Misses);
			_perfCounters.Increment(PerfCounterName.HitRatioBase);
		}
	}

	private void WaitInsertBlock()
	{
		_insertBlock.WaitOne(10000, exitContext: false);
	}

	internal MemoryCacheEntry AddOrGetExisting(MemoryCacheKey key, MemoryCacheEntry entry)
	{
		if (_useInsertBlock && entry.HasUsage())
		{
			WaitInsertBlock();
		}
		MemoryCacheEntry memoryCacheEntry = null;
		MemoryCacheEntry memoryCacheEntry2 = null;
		bool flag = false;
		lock (_entriesLock)
		{
			if (_disposed == 0)
			{
				memoryCacheEntry = _entries[key] as MemoryCacheEntry;
				if (memoryCacheEntry != null && memoryCacheEntry.UtcAbsExp <= DateTime.UtcNow)
				{
					memoryCacheEntry2 = memoryCacheEntry;
					memoryCacheEntry2.State = EntryState.RemovingFromCache;
					memoryCacheEntry = null;
				}
				if (memoryCacheEntry == null)
				{
					entry.State = EntryState.AddingToCache;
					flag = true;
					_entries[key] = entry;
				}
			}
		}
		RemoveFromCache(memoryCacheEntry2, CacheEntryRemovedReason.Expired, delayRelease: true);
		if (flag)
		{
			AddToCache(entry);
		}
		UpdateExpAndUsage(memoryCacheEntry);
		memoryCacheEntry2?.Release(_cache, CacheEntryRemovedReason.Expired);
		return memoryCacheEntry;
	}

	internal void BlockInsert()
	{
		_insertBlock.Reset();
		_useInsertBlock = true;
	}

	internal void CopyTo(IDictionary h)
	{
		lock (_entriesLock)
		{
			if (_disposed != 0)
			{
				return;
			}
			foreach (DictionaryEntry entry in _entries)
			{
				MemoryCacheKey memoryCacheKey = entry.Key as MemoryCacheKey;
				MemoryCacheEntry memoryCacheEntry = entry.Value as MemoryCacheEntry;
				if (memoryCacheEntry.UtcAbsExp > DateTime.UtcNow)
				{
					h[memoryCacheKey.Key] = memoryCacheEntry.Value;
				}
			}
		}
	}

	public void Dispose()
	{
		if (Interlocked.Exchange(ref _disposed, 1) != 0)
		{
			return;
		}
		_expires.EnableExpirationTimer(enable: false);
		ArrayList arrayList = new ArrayList(_entries.Count);
		lock (_entriesLock)
		{
			foreach (DictionaryEntry entry2 in _entries)
			{
				MemoryCacheEntry value = entry2.Value as MemoryCacheEntry;
				arrayList.Add(value);
			}
			foreach (MemoryCacheEntry item in arrayList)
			{
				MemoryCacheKey key = item;
				item.State = EntryState.RemovingFromCache;
				_entries.Remove(key);
			}
		}
		foreach (MemoryCacheEntry item2 in arrayList)
		{
			RemoveFromCache(item2, CacheEntryRemovedReason.CacheSpecificEviction);
		}
		_insertBlock.Close();
	}

	internal MemoryCacheEntry Get(MemoryCacheKey key)
	{
		MemoryCacheEntry memoryCacheEntry = _entries[key] as MemoryCacheEntry;
		if (memoryCacheEntry != null && memoryCacheEntry.UtcAbsExp <= DateTime.UtcNow)
		{
			Remove(key, memoryCacheEntry, CacheEntryRemovedReason.Expired);
			memoryCacheEntry = null;
		}
		UpdateExpAndUsage(memoryCacheEntry);
		return memoryCacheEntry;
	}

	internal MemoryCacheEntry Remove(MemoryCacheKey key, MemoryCacheEntry entryToRemove, CacheEntryRemovedReason reason)
	{
		MemoryCacheEntry memoryCacheEntry = null;
		lock (_entriesLock)
		{
			if (_disposed == 0)
			{
				memoryCacheEntry = _entries[key] as MemoryCacheEntry;
				if (entryToRemove != null && memoryCacheEntry != entryToRemove)
				{
					memoryCacheEntry = null;
				}
				else if (memoryCacheEntry != null)
				{
					memoryCacheEntry.State = EntryState.RemovingFromCache;
					_entries.Remove(key);
				}
			}
		}
		RemoveFromCache(memoryCacheEntry, reason);
		return memoryCacheEntry;
	}

	internal void Set(MemoryCacheKey key, MemoryCacheEntry entry)
	{
		if (_useInsertBlock && entry.HasUsage())
		{
			WaitInsertBlock();
		}
		MemoryCacheEntry memoryCacheEntry = null;
		bool flag = false;
		lock (_entriesLock)
		{
			if (_disposed == 0)
			{
				memoryCacheEntry = _entries[key] as MemoryCacheEntry;
				if (memoryCacheEntry != null)
				{
					memoryCacheEntry.State = EntryState.RemovingFromCache;
				}
				entry.State = EntryState.AddingToCache;
				flag = true;
				_entries[key] = entry;
			}
		}
		CacheEntryRemovedReason reason = CacheEntryRemovedReason.Removed;
		if (memoryCacheEntry != null)
		{
			if (memoryCacheEntry.UtcAbsExp <= DateTime.UtcNow)
			{
				reason = CacheEntryRemovedReason.Expired;
			}
			RemoveFromCache(memoryCacheEntry, reason, delayRelease: true);
		}
		if (flag)
		{
			AddToCache(entry);
		}
		memoryCacheEntry?.Release(_cache, reason);
	}

	internal long TrimInternal(int percent)
	{
		int count = Count;
		int num = 0;
		if (percent > 0)
		{
			num = (int)Math.Ceiling((double)((long)count * (long)percent) / 100.0);
			int num2 = count - 1073741823;
			if (num < num2)
			{
				num = num2;
			}
		}
		if (num > 0 && _disposed != 1)
		{
			int num3 = 0;
			int num4 = 0;
			num4 = _expires.FlushExpiredItems(useInsertBlock: true);
			if (num4 < num)
			{
				num3 = _usage.FlushUnderUsedItems(num - num4);
				num4 += num3;
			}
			if (num3 > 0 && _perfCounters != null)
			{
				_perfCounters.IncrementBy(PerfCounterName.Trims, num3);
			}
			return num4;
		}
		return 0L;
	}

	internal void UnblockInsert()
	{
		_useInsertBlock = false;
		_insertBlock.Set();
	}
}
