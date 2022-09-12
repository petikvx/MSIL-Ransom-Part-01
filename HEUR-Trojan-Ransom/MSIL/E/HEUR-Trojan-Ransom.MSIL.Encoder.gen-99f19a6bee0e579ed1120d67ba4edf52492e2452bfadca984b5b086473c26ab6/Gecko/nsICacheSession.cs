using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1dd7708c-de48-4ffe-b5aa-cd218c762887")]
public interface nsICacheSession
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDoomEntriesIfExpiredAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDoomEntriesIfExpiredAttribute([MarshalAs(UnmanagedType.U1)] bool aDoomEntriesIfExpired);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetProfileDirectoryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetProfileDirectoryAttribute([MarshalAs(UnmanagedType.Interface)] nsIFile aProfileDirectory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICacheEntryDescriptor OpenCacheEntry([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key, IntPtr accessRequested, [MarshalAs(UnmanagedType.U1)] bool blockingMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncOpenCacheEntry([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key, IntPtr accessRequested, [MarshalAs(UnmanagedType.Interface)] nsICacheListener listener, [MarshalAs(UnmanagedType.U1)] bool noWait);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EvictEntries();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsStorageEnabled();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoomEntry([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase key, [MarshalAs(UnmanagedType.Interface)] nsICacheListener listener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsPrivateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsPrivateAttribute([MarshalAs(UnmanagedType.U1)] bool aIsPrivate);
}
