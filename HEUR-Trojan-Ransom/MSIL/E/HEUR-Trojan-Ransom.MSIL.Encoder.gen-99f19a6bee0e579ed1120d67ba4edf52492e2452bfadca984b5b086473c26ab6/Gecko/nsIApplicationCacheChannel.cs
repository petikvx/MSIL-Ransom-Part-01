using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6FA816B1-6D5F-4380-9704-054D0908CFA3")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIApplicationCacheChannel : nsIApplicationCacheContainer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIApplicationCache GetApplicationCacheAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetApplicationCacheAttribute([MarshalAs(UnmanagedType.Interface)] nsIApplicationCache aApplicationCache);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetLoadedFromApplicationCacheAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInheritApplicationCacheAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInheritApplicationCacheAttribute([MarshalAs(UnmanagedType.U1)] bool aInheritApplicationCache);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetChooseApplicationCacheAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetChooseApplicationCacheAttribute([MarshalAs(UnmanagedType.U1)] bool aChooseApplicationCache);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MarkOfflineCacheEntryAsForeign();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIApplicationCache GetApplicationCacheForWriteAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetApplicationCacheForWriteAttribute([MarshalAs(UnmanagedType.Interface)] nsIApplicationCache aApplicationCacheForWrite);
}
