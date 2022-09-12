using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ae29c44b-fbc3-4552-afaf-0a157ce771e7")]
public interface nsICacheStorageService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICacheStorage MemoryCacheStorage([MarshalAs(UnmanagedType.Interface)] nsILoadContextInfo aLoadContextInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICacheStorage DiskCacheStorage([MarshalAs(UnmanagedType.Interface)] nsILoadContextInfo aLoadContextInfo, [MarshalAs(UnmanagedType.U1)] bool aLookupAppCache);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICacheStorage PinningCacheStorage([MarshalAs(UnmanagedType.Interface)] nsILoadContextInfo aLoadContextInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICacheStorage AppCacheStorage([MarshalAs(UnmanagedType.Interface)] nsILoadContextInfo aLoadContextInfo, [MarshalAs(UnmanagedType.Interface)] nsIApplicationCache aApplicationCache);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsICacheStorage SynthesizedCacheStorage([MarshalAs(UnmanagedType.Interface)] nsILoadContextInfo aLoadContextInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Clear();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PurgeFromMemory(uint aWhat);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIEventTarget GetIoTargetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AsyncGetDiskConsumption([MarshalAs(UnmanagedType.Interface)] nsICacheStorageConsumptionObserver aObserver);
}
