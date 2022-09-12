using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8eadf2ed-8cac-4961-8025-6da6d5827e74")]
public interface nsICacheListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnCacheEntryAvailable([MarshalAs(UnmanagedType.Interface)] nsICacheEntryDescriptor descriptor, IntPtr accessGranted, int status);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnCacheEntryDoomed(int status);
}
