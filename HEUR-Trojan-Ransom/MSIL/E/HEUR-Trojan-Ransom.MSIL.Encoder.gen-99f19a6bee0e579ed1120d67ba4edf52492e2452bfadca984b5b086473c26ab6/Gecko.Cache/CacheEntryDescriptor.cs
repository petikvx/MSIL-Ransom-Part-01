using System;
using System.Collections.Generic;
using Gecko.IO;

namespace Gecko.Cache;

public sealed class CacheEntryDescriptor : CacheEntryInfo
{
	private nsICacheEntryDescriptor _cacheEntryDescriptor;

	public IntPtr AccessGranted => _cacheEntryDescriptor.GetAccessGrantedAttribute();

	public nsISupports CacheElement
	{
		get
		{
			return _cacheEntryDescriptor.GetCacheElementAttribute();
		}
		set
		{
			_cacheEntryDescriptor.SetCacheElementAttribute(value);
		}
	}

	public new uint ExpirationTimeNative
	{
		get
		{
			return _cacheEntryDescriptor.GetExpirationTimeAttribute();
		}
		set
		{
			_cacheEntryDescriptor.SetExpirationTime(value);
		}
	}

	public new DateTime ExpirationTime
	{
		get
		{
			return Xpcom.Time.FromSecondsSinceEpoch(ExpirationTimeNative);
		}
		set
		{
			ExpirationTimeNative = Xpcom.Time.ToSecondsSinceEpoch(value);
		}
	}

	public long PredictedDataSize
	{
		get
		{
			return _cacheEntryDescriptor.GetPredictedDataSizeAttribute();
		}
		set
		{
			_cacheEntryDescriptor.SetPredictedDataSizeAttribute(value);
		}
	}

	public CacheStoragePolicy StoragePolicy
	{
		get
		{
			return (CacheStoragePolicy)(int)_cacheEntryDescriptor.GetStoragePolicyAttribute();
		}
		set
		{
			_cacheEntryDescriptor.SetStoragePolicyAttribute((IntPtr)(int)value);
		}
	}

	public nsIFile File => _cacheEntryDescriptor.GetFileAttribute();

	public nsISupports SecurityInfo
	{
		get
		{
			return _cacheEntryDescriptor.GetSecurityInfoAttribute();
		}
		set
		{
			_cacheEntryDescriptor.SetSecurityInfoAttribute(value);
		}
	}

	public new uint DataSize
	{
		get
		{
			return _cacheEntryDescriptor.GetDataSizeAttribute();
		}
		set
		{
			_cacheEntryDescriptor.SetDataSize(value);
		}
	}

	private CacheEntryDescriptor(nsICacheEntryDescriptor cacheEntryDescriptor)
		: base(cacheEntryDescriptor)
	{
		_cacheEntryDescriptor = cacheEntryDescriptor;
	}

	public static CacheEntryDescriptor Create(nsICacheEntryDescriptor cacheEntryDescriptor)
	{
		return new CacheEntryDescriptor(cacheEntryDescriptor);
	}

	public void Close()
	{
		_cacheEntryDescriptor.Close();
	}

	public void Doom()
	{
		_cacheEntryDescriptor.Doom();
	}

	public void DoomAndFailPendingRequests(int status)
	{
		_cacheEntryDescriptor.DoomAndFailPendingRequests(status);
	}

	public InputStream OpenInputStream(uint offset)
	{
		return InputStream.Create(_cacheEntryDescriptor.OpenInputStream(offset));
	}

	public OutputStream OpenOutputStream(uint offset)
	{
		return OutputStream.Create(_cacheEntryDescriptor.OpenOutputStream(offset));
	}

	public void MarkValid()
	{
		_cacheEntryDescriptor.MarkValid();
	}

	public string GetMetaDataElement(string key)
	{
		return _cacheEntryDescriptor.GetMetaDataElement(key);
	}

	public void SetMetaDataElement(string key, string value)
	{
		_cacheEntryDescriptor.SetMetaDataElement(key, value);
	}

	public KeyValuePair<string, string>[] GetAllMetadata()
	{
		KeyValuePair<string, string>[] result = null;
		using (CacheEntryMetadataSearcher cacheEntryMetadataSearcher = new CacheEntryMetadataSearcher((string x, string y) => true))
		{
			_cacheEntryDescriptor.VisitMetaData(cacheEntryMetadataSearcher);
			result = cacheEntryMetadataSearcher.GetResult();
		}
		return result;
	}

	public KeyValuePair<string, string>[] SearchInMetadata(Func<string, string, bool> predicate)
	{
		KeyValuePair<string, string>[] result = null;
		using (CacheEntryMetadataSearcher cacheEntryMetadataSearcher = new CacheEntryMetadataSearcher(predicate))
		{
			_cacheEntryDescriptor.VisitMetaData(cacheEntryMetadataSearcher);
			result = cacheEntryMetadataSearcher.GetResult();
		}
		return result;
	}
}
