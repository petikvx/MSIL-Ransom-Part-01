using System.Runtime.InteropServices;

namespace Orcus.Native.Display;

internal struct DISPLAY_DEVICE
{
	[MarshalAs(UnmanagedType.U4)]
	public int cb;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
	public string DeviceName;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
	public string DeviceString;

	[MarshalAs(UnmanagedType.U4)]
	public DisplayDeviceStateFlags StateFlags;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
	public string DeviceID;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
	public string DeviceKey;
}
