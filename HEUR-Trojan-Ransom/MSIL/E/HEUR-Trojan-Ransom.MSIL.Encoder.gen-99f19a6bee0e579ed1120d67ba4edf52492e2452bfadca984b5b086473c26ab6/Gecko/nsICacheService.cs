using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("14dbe1e9-f3bc-45af-92f4-2c574fcd4e39")]
public interface nsICacheService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICacheSession CreateSession([MarshalAs(UnmanagedType.LPStr)] string clientID, IntPtr storagePolicy, [MarshalAs(UnmanagedType.U1)] bool streamBased);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void VisitEntries([MarshalAs(UnmanagedType.Interface)] nsICacheVisitor visitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EvictEntries(IntPtr storagePolicy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIEventTarget GetCacheIOTargetAttribute();
}
