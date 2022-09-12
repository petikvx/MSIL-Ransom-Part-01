using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("e8a96e60-6b61-4a14-bacc-53891604b502")]
public interface nsIScreenManager
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIScreen ScreenForRect(int left, int top, int width, int height);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIScreen ScreenForId(uint id);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIScreen GetPrimaryScreenAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetNumberOfScreensAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	float GetSystemDefaultScaleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIScreen ScreenForNativeWidget(IntPtr nativeWidget);
}
