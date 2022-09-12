using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("d0fc8d38-db80-4928-bf1c-b0085ddfa9dc")]
public interface nsICacheServiceInternal : nsICacheService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsICacheSession CreateSession([MarshalAs(UnmanagedType.LPStr)] string clientID, IntPtr storagePolicy, [MarshalAs(UnmanagedType.U1)] bool streamBased);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void VisitEntries([MarshalAs(UnmanagedType.Interface)] nsICacheVisitor visitor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void EvictEntries(IntPtr storagePolicy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIEventTarget GetCacheIOTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetLockHeldTimeAttribute();
}
