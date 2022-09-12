using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("47360d57-8ef4-4a5d-8865-1a27a739ad1a")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIOfflineCacheUpdateObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void UpdateStateChanged([MarshalAs(UnmanagedType.Interface)] nsIOfflineCacheUpdate aUpdate, uint state);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ApplicationCacheAvailable([MarshalAs(UnmanagedType.Interface)] nsIApplicationCache applicationCache);
}
