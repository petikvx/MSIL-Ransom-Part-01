using System.Runtime.Caching.Hosting;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace System.Runtime.Caching;

internal sealed class CacheMemoryMonitor : MemoryMonitor, IDisposable
{
	private const long PRIVATE_BYTES_LIMIT_2GB = 838860800L;

	private const long PRIVATE_BYTES_LIMIT_3GB = 1887436800L;

	private const long PRIVATE_BYTES_LIMIT_64BIT = 1099511627776L;

	private const int SAMPLE_COUNT = 2;

	private static IMemoryCacheManager s_memoryCacheManager;

	private static long s_autoPrivateBytesLimit = -1L;

	private static long s_effectiveProcessMemoryLimit = -1L;

	private MemoryCache _memoryCache;

	private long[] _cacheSizeSamples;

	private DateTime[] _cacheSizeSampleTimes;

	private int _idx;

	private SRefMultiple _sizedRefMultiple;

	private int _gen2Count;

	private long _memoryLimit;

	internal long MemoryLimit => _memoryLimit;

	private static long AutoPrivateBytesLimit
	{
		get
		{
			long num = s_autoPrivateBytesLimit;
			if (num == -1L)
			{
				bool flag = IntPtr.Size == 8;
				long totalPhysical = MemoryMonitor.TotalPhysical;
				long totalVirtual = MemoryMonitor.TotalVirtual;
				if (totalPhysical != 0L)
				{
					long val = (flag ? 1099511627776L : ((totalVirtual <= 2147483648L) ? 838860800L : 1887436800L));
					long val2 = totalPhysical * 3L / 5L;
					num = Math.Min(val2, val);
				}
				else
				{
					num = (flag ? 1099511627776L : 838860800L);
				}
				Interlocked.Exchange(ref s_autoPrivateBytesLimit, num);
			}
			return num;
		}
	}

	internal static long EffectiveProcessMemoryLimit
	{
		get
		{
			long autoPrivateBytesLimit = s_effectiveProcessMemoryLimit;
			if (autoPrivateBytesLimit == -1L)
			{
				autoPrivateBytesLimit = AutoPrivateBytesLimit;
				Interlocked.Exchange(ref s_effectiveProcessMemoryLimit, autoPrivateBytesLimit);
			}
			return autoPrivateBytesLimit;
		}
	}

	private CacheMemoryMonitor()
	{
	}

	internal CacheMemoryMonitor(MemoryCache memoryCache, int cacheMemoryLimitMegabytes)
	{
		_memoryCache = memoryCache;
		_gen2Count = GC.CollectionCount(2);
		_cacheSizeSamples = new long[2];
		_cacheSizeSampleTimes = new DateTime[2];
		if (memoryCache.UseMemoryCacheManager)
		{
			InitMemoryCacheManager();
		}
		InitDisposableMembers(cacheMemoryLimitMegabytes);
	}

	private void InitDisposableMembers(int cacheMemoryLimitMegabytes)
	{
		bool flag = true;
		try
		{
			_sizedRefMultiple = new SRefMultiple(_memoryCache.AllSRefTargets);
			SetLimit(cacheMemoryLimitMegabytes);
			InitHistory();
			flag = false;
		}
		finally
		{
			if (flag)
			{
				Dispose();
			}
		}
	}

	public void Dispose()
	{
		SRefMultiple sizedRefMultiple = _sizedRefMultiple;
		if (sizedRefMultiple != null && Interlocked.CompareExchange(ref _sizedRefMultiple, null, sizedRefMultiple) == sizedRefMultiple)
		{
			sizedRefMultiple.Dispose();
		}
		s_memoryCacheManager?.ReleaseCache(_memoryCache);
	}

	protected override int GetCurrentPressure()
	{
		int num = GC.CollectionCount(2);
		SRefMultiple sizedRefMultiple = _sizedRefMultiple;
		if (num != _gen2Count && sizedRefMultiple != null)
		{
			_gen2Count = num;
			_idx ^= 1;
			_cacheSizeSampleTimes[_idx] = DateTime.UtcNow;
			_cacheSizeSamples[_idx] = sizedRefMultiple.ApproximateSize;
			s_memoryCacheManager?.UpdateCacheSize(_cacheSizeSamples[_idx], _memoryCache);
		}
		if (_memoryLimit <= 0L)
		{
			return 0;
		}
		long num2 = _cacheSizeSamples[_idx];
		if (num2 > _memoryLimit)
		{
			num2 = _memoryLimit;
		}
		return (int)(num2 * 100L / _memoryLimit);
	}

	internal override int GetPercentToTrim(DateTime lastTrimTime, int lastTrimPercent)
	{
		int result = 0;
		if (IsAboveHighPressure())
		{
			long num = _cacheSizeSamples[_idx];
			if (num > _memoryLimit)
			{
				result = Math.Min(100, (int)((num - _memoryLimit) * 100L / num));
			}
		}
		return result;
	}

	internal void SetLimit(int cacheMemoryLimitMegabytes)
	{
		long num = cacheMemoryLimitMegabytes;
		num <<= 20;
		_memoryLimit = 0L;
		if (num == 0L && _memoryLimit == 0L)
		{
			_memoryLimit = EffectiveProcessMemoryLimit;
		}
		else if (num != 0L && _memoryLimit != 0L)
		{
			_memoryLimit = Math.Min(_memoryLimit, num);
		}
		else if (num != 0L)
		{
			_memoryLimit = num;
		}
		if (_memoryLimit > 0L)
		{
			_pressureHigh = 100;
			_pressureLow = 80;
		}
		else
		{
			_pressureHigh = 99;
			_pressureLow = 97;
		}
	}

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	private static void InitMemoryCacheManager()
	{
		if (s_memoryCacheManager == null)
		{
			IMemoryCacheManager memoryCacheManager = null;
			IServiceProvider host = ObjectCache.Host;
			if (host != null)
			{
				memoryCacheManager = host.GetService(typeof(IMemoryCacheManager)) as IMemoryCacheManager;
			}
			if (memoryCacheManager != null)
			{
				Interlocked.CompareExchange(ref s_memoryCacheManager, memoryCacheManager, null);
			}
		}
	}
}
