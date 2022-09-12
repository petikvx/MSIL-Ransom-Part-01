using System;
using System.Collections.Generic;

namespace Gecko.Cache;

internal sealed class CacheSearcher : IDisposable, nsICacheVisitor
{
	private Predicate<CacheEntryInfo> _predicate;

	private string _deviceID;

	private List<string> _foundEntries = new List<string>();

	internal CacheSearcher(Predicate<CacheEntryInfo> predicate)
		: this(null, predicate)
	{
	}

	internal CacheSearcher(string deviceID, Predicate<CacheEntryInfo> predicate)
	{
		_deviceID = deviceID;
		_predicate = predicate;
	}

	~CacheSearcher()
	{
		_foundEntries.Clear();
	}

	public void Dispose()
	{
		_foundEntries.Clear();
		GC.SuppressFinalize(this);
	}

	public bool VisitDevice(string deviceID, nsICacheDeviceInfo deviceInfo)
	{
		if (string.IsNullOrEmpty(_deviceID))
		{
			return true;
		}
		return string.Equals(_deviceID, deviceID);
	}

	public bool VisitEntry(string deviceID, nsICacheEntryInfo entryInfo)
	{
		if (entryInfo == null)
		{
			return true;
		}
		using (CacheEntryInfo cacheEntryInfo = CacheEntryInfo.Create(entryInfo))
		{
			if (_predicate(cacheEntryInfo))
			{
				string key = cacheEntryInfo.Key;
				_foundEntries.Add(key);
			}
		}
		return true;
	}

	public string[] GetResult()
	{
		return _foundEntries.ToArray();
	}
}
