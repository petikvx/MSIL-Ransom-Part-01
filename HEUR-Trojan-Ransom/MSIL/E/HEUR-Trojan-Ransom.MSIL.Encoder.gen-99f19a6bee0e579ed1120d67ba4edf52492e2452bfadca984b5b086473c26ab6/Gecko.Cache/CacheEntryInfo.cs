using System;
using Gecko.Interop;

namespace Gecko.Cache;

public class CacheEntryInfo : IDisposable
{
	private ComPtr<nsICacheEntryInfo> _cacheEntryInfo;

	public nsICacheEntryInfo NativeCacheEntryInfo => _cacheEntryInfo.Instance;

	public string ClientID => _cacheEntryInfo.Instance.GetClientIDAttribute();

	public uint DataSize => _cacheEntryInfo.Instance.GetDataSizeAttribute();

	public string DeviceID => _cacheEntryInfo.Instance.GetDeviceIDAttribute();

	public uint ExpirationTimeNative => _cacheEntryInfo.Instance.GetExpirationTimeAttribute();

	public DateTime ExpirationTime => Xpcom.Time.FromSecondsSinceEpoch(ExpirationTimeNative);

	public int FetchCount => _cacheEntryInfo.Instance.GetFetchCountAttribute();

	public string Key => nsString.Get(_cacheEntryInfo.Instance.GetKeyAttribute);

	public uint LastFetched => _cacheEntryInfo.Instance.GetLastFetchedAttribute();

	public uint LastModified => _cacheEntryInfo.Instance.GetLastModifiedAttribute();

	public bool IsStreamBased => _cacheEntryInfo.Instance.IsStreamBased();

	protected CacheEntryInfo(nsICacheEntryInfo cacheEntryInfo)
	{
		_cacheEntryInfo = new ComPtr<nsICacheEntryInfo>(cacheEntryInfo);
	}

	public void Dispose()
	{
		_cacheEntryInfo.Dispose();
		GC.SuppressFinalize(this);
	}

	public static CacheEntryInfo Create(nsICacheEntryInfo info)
	{
		if (info is nsICacheEntryDescriptor)
		{
			return CacheEntryDescriptor.Create((nsICacheEntryDescriptor)info);
		}
		return new CacheEntryInfo(info);
	}
}
