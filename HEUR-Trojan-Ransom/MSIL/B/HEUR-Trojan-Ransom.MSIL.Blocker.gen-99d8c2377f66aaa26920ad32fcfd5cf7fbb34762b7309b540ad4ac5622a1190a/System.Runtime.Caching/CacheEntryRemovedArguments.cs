namespace System.Runtime.Caching;

public class CacheEntryRemovedArguments
{
	private CacheItem _cacheItem;

	private ObjectCache _source;

	private CacheEntryRemovedReason _reason;

	public CacheItem CacheItem => _cacheItem;

	public CacheEntryRemovedReason RemovedReason => _reason;

	public ObjectCache Source => _source;

	public CacheEntryRemovedArguments(ObjectCache source, CacheEntryRemovedReason reason, CacheItem cacheItem)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (cacheItem == null)
		{
			throw new ArgumentNullException("cacheItem");
		}
		_source = source;
		_reason = reason;
		_cacheItem = cacheItem;
	}
}
