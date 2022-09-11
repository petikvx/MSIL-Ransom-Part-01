namespace System.Runtime.Caching;

public class CacheEntryUpdateArguments
{
	private string _key;

	private CacheEntryRemovedReason _reason;

	private string _regionName;

	private ObjectCache _source;

	private CacheItem _updatedCacheItem;

	private CacheItemPolicy _updatedCacheItemPolicy;

	public string Key => _key;

	public CacheEntryRemovedReason RemovedReason => _reason;

	public string RegionName => _regionName;

	public ObjectCache Source => _source;

	public CacheItem UpdatedCacheItem
	{
		get
		{
			return _updatedCacheItem;
		}
		set
		{
			_updatedCacheItem = value;
		}
	}

	public CacheItemPolicy UpdatedCacheItemPolicy
	{
		get
		{
			return _updatedCacheItemPolicy;
		}
		set
		{
			_updatedCacheItemPolicy = value;
		}
	}

	public CacheEntryUpdateArguments(ObjectCache source, CacheEntryRemovedReason reason, string key, string regionName)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		_source = source;
		_reason = reason;
		_key = key;
		_regionName = regionName;
	}
}
