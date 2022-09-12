using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("f13b225d-473e-4372-b11f-b6dff9fe0c5b")]
public interface nsIPrintSettingsWin
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetDeviceNameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDeviceNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aDeviceName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetDriverNameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDriverNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aDriverName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetDevModeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDevModeAttribute(IntPtr aDevMode);
}
