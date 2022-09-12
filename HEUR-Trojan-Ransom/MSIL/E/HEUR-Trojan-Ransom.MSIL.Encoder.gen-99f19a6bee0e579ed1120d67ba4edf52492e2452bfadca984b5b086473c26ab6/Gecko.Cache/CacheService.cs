using System;
using Gecko.Interop;

namespace Gecko.Cache;

public static class CacheService
{
	private static ComPtr<nsICacheService> _cacheService;

	public static readonly string MemoryCacheDevice;

	public static readonly string DiskCacheDevice;

	static CacheService()
	{
		MemoryCacheDevice = "memory";
		DiskCacheDevice = "disk";
		_cacheService = Xpcom.GetService2<nsICacheService>("@mozilla.org/network/cache-service;1");
	}

	public static CacheSession CreateSession(string clientID, CacheStoragePolicy storagePolicy, bool streamBased)
	{
		return new CacheSession(_cacheService.Instance.CreateSession(clientID, new IntPtr((int)storagePolicy), streamBased));
	}

	public static string[] Search(string deviceID, Predicate<CacheEntryInfo> predicate)
	{
		string[] result = null;
		using (CacheSearcher cacheSearcher = new CacheSearcher(deviceID, predicate))
		{
			_cacheService.Instance.VisitEntries(cacheSearcher);
			result = cacheSearcher.GetResult();
		}
		return result;
	}

	public static string[] Search(Predicate<CacheEntryInfo> predicate)
	{
		string[] result = null;
		using (CacheSearcher cacheSearcher = new CacheSearcher(predicate))
		{
			_cacheService.Instance.VisitEntries(cacheSearcher);
			result = cacheSearcher.GetResult();
		}
		return result;
	}

	public static void ProcessEntries(Action<CacheEntryInfo> entryProcessor)
	{
		CacheVisitor visitor = new CacheVisitor(entryProcessor);
		_cacheService.Instance.VisitEntries(visitor);
	}

	public static void Clear(CacheStoragePolicy storagePolicy)
	{
		_cacheService.Instance.EvictEntries(new IntPtr((int)storagePolicy));
	}
}
