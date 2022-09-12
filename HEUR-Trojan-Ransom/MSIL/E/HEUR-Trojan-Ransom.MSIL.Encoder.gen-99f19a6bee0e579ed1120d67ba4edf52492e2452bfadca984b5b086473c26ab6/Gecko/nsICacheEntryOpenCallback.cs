using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1fc9fe11-c6ac-4748-94bd-8555a5a12b94")]
public interface nsICacheEntryOpenCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint OnCacheEntryCheck([MarshalAs(UnmanagedType.Interface)] nsICacheEntry aEntry, [MarshalAs(UnmanagedType.Interface)] nsIApplicationCache aApplicationCache);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnCacheEntryAvailable([MarshalAs(UnmanagedType.Interface)] nsICacheEntry aEntry, [MarshalAs(UnmanagedType.U1)] bool aNew, [MarshalAs(UnmanagedType.Interface)] nsIApplicationCache aApplicationCache, int aResult);
}
