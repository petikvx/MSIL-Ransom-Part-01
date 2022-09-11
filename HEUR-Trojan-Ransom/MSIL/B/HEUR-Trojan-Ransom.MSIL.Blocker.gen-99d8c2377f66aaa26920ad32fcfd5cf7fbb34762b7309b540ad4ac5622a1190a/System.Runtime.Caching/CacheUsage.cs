using System.Threading;

namespace System.Runtime.Caching;

internal class CacheUsage
{
	internal static readonly TimeSpan NEWADD_INTERVAL = new TimeSpan(0, 0, 10);

	internal static readonly TimeSpan CORRELATED_REQUEST_TIMEOUT = new TimeSpan(0, 0, 1);

	internal static readonly TimeSpan MIN_LIFETIME_FOR_USAGE = NEWADD_INTERVAL;

	private const byte NUMBUCKETS = 1;

	private const int MAX_REMOVE = 1024;

	private readonly MemoryCacheStore _cacheStore;

	internal readonly UsageBucket[] _buckets;

	private int _inFlush;

	internal MemoryCacheStore MemoryCacheStore => _cacheStore;

	internal CacheUsage(MemoryCacheStore cacheStore)
	{
		_cacheStore = cacheStore;
		_buckets = new UsageBucket[1];
		for (byte b = 0; b < _buckets.Length; b = (byte)(b + 1))
		{
			_buckets[b] = new UsageBucket(this, b);
		}
	}

	internal void Add(MemoryCacheEntry cacheEntry)
	{
		byte usageBucket = cacheEntry.UsageBucket;
		_buckets[usageBucket].AddCacheEntry(cacheEntry);
	}

	internal void Remove(MemoryCacheEntry cacheEntry)
	{
		byte usageBucket = cacheEntry.UsageBucket;
		if (usageBucket != byte.MaxValue)
		{
			_buckets[usageBucket].RemoveCacheEntry(cacheEntry);
		}
	}

	internal void Update(MemoryCacheEntry cacheEntry)
	{
		byte usageBucket = cacheEntry.UsageBucket;
		if (usageBucket != byte.MaxValue)
		{
			_buckets[usageBucket].UpdateCacheEntry(cacheEntry);
		}
	}

	internal int FlushUnderUsedItems(int toFlush)
	{
		int num = 0;
		if (Interlocked.Exchange(ref _inFlush, 1) == 0)
		{
			try
			{
				UsageBucket[] buckets = _buckets;
				foreach (UsageBucket usageBucket in buckets)
				{
					int num2 = usageBucket.FlushUnderUsedItems(toFlush - num, force: false);
					num += num2;
					if (num >= toFlush)
					{
						break;
					}
				}
				if (num >= toFlush)
				{
					return num;
				}
				UsageBucket[] buckets2 = _buckets;
				int num3 = 0;
				while (true)
				{
					if (num3 >= buckets2.Length)
					{
						return num;
					}
					UsageBucket usageBucket2 = buckets2[num3];
					int num4 = usageBucket2.FlushUnderUsedItems(toFlush - num, force: true);
					num += num4;
					if (num >= toFlush)
					{
						break;
					}
					num3++;
				}
				return num;
			}
			finally
			{
				Interlocked.Exchange(ref _inFlush, 0);
			}
		}
		return num;
	}
}
