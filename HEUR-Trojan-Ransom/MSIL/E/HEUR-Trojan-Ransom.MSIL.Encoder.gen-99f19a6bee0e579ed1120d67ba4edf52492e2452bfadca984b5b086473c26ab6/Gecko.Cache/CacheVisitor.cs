using System;

namespace Gecko.Cache;

internal sealed class CacheVisitor : nsICacheVisitor
{
	private string _deviceID;

	private Action<CacheEntryInfo> _entryProcessor;

	internal CacheVisitor(Action<CacheEntryInfo> entryProcessor)
		: this(null, entryProcessor)
	{
	}

	internal CacheVisitor(string deviceID, Action<CacheEntryInfo> entryProcessor)
	{
		_deviceID = deviceID;
		_entryProcessor = entryProcessor;
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
		using (CacheEntryInfo obj = CacheEntryInfo.Create(entryInfo))
		{
			_entryProcessor(obj);
		}
		return true;
	}
}
