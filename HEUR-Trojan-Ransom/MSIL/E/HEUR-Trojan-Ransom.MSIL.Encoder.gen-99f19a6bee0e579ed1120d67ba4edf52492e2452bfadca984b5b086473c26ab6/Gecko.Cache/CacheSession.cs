#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Gecko.Interop;

namespace Gecko.Cache;

public sealed class CacheSession
{
	private ComPtr<nsICacheSession> _cacheSession;

	public bool DoomEntriesIfExpired
	{
		get
		{
			return _cacheSession.Instance.GetDoomEntriesIfExpiredAttribute();
		}
		set
		{
			_cacheSession.Instance.SetDoomEntriesIfExpiredAttribute(value);
		}
	}

	public bool IsStorageEnabled => _cacheSession.Instance.IsStorageEnabled();

	internal CacheSession(nsICacheSession cacheSession)
	{
		_cacheSession = new ComPtr<nsICacheSession>(cacheSession);
	}

	public void EvictEntries()
	{
		_cacheSession.Instance.EvictEntries();
	}

	[Obsolete("This method is not working in latest (>29) Xulrunner versions. Use AsyncOpenCacheEntry", true)]
	public CacheEntryDescriptor OpenCacheEntry(string key, CacheAccessMode accessRequested, bool blockingMode)
	{
		nsICacheEntryDescriptor obj = null;
		try
		{
			obj = _cacheSession.Instance.OpenCacheEntry(new nsACString(key), new IntPtr((int)accessRequested), blockingMode);
		}
		catch (COMException ex)
		{
			Debug.WriteLine($"COM Exception CODE={ex.ErrorCode},Message={ex.Message}");
		}
		catch (Exception ex2)
		{
			Debug.WriteLine($"Exception Message={ex2.Message}");
		}
		return obj.Wrap(CacheEntryDescriptor.Create);
	}

	public void AsyncOpenCacheEntry(string key, CacheAccessMode accessRequested, Action<CacheEntryDescriptor, CacheAccessMode, CacheOpenEntryStatus> callback)
	{
		_cacheSession.Instance.AsyncOpenCacheEntry(new nsACString(key), new IntPtr((int)accessRequested), new CacheListener(callback), noWait: false);
	}
}
