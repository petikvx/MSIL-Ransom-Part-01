using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("9142ab45-0ab5-418c-9bab-338a6d271d4f")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMGeoGeolocation
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int WatchPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionCallback callback, [MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionErrorCallback errorCallback, IntPtr options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCurrentPosition([MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionCallback callback, [MarshalAs(UnmanagedType.Interface)] nsIDOMGeoPositionErrorCallback errorCallback, IntPtr options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearWatch(int watchId);
}
