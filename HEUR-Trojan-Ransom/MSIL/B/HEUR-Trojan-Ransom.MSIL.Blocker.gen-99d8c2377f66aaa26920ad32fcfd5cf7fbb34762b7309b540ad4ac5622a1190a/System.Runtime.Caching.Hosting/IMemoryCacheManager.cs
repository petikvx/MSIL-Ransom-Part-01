namespace System.Runtime.Caching.Hosting;

public interface IMemoryCacheManager
{
	void UpdateCacheSize(long size, MemoryCache cache);

	void ReleaseCache(MemoryCache cache);
}
