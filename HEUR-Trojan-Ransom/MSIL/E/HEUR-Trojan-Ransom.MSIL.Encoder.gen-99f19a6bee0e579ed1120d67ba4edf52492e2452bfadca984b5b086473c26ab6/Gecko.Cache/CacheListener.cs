using System;
using Gecko.Interop;

namespace Gecko.Cache;

internal sealed class CacheListener : nsICacheListener
{
	private Action<CacheEntryDescriptor, CacheAccessMode, CacheOpenEntryStatus> _callback;

	public CacheListener(Action<CacheEntryDescriptor, CacheAccessMode, CacheOpenEntryStatus> callback)
	{
		_callback = callback;
	}

	public void OnCacheEntryAvailable(nsICacheEntryDescriptor descriptor, IntPtr accessGranted, int status)
	{
		_callback(descriptor.Wrap(CacheEntryDescriptor.Create), (CacheAccessMode)accessGranted.ToInt32(), (CacheOpenEntryStatus)status);
	}

	public void OnCacheEntryDoomed(int status)
	{
	}
}
