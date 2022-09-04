using System.Runtime.InteropServices;

namespace Lexplorer;

public struct DEVMODE
{
	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
	public string dmDeviceName;

	[MarshalAs(UnmanagedType.U2)]
	public ushort dmSpecVersion;

	[MarshalAs(UnmanagedType.U2)]
	public ushort dmDriverVersion;

	[MarshalAs(UnmanagedType.U2)]
	public ushort dmSize;

	[MarshalAs(UnmanagedType.U2)]
	public ushort dmDriverExtra;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmFields;

	public POINTL dmPosition;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmDisplayOrientation;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmDisplayFixedOutput;

	[MarshalAs(UnmanagedType.I2)]
	public short dmColor;

	[MarshalAs(UnmanagedType.I2)]
	public short dmDuplex;

	[MarshalAs(UnmanagedType.I2)]
	public short dmYResolution;

	[MarshalAs(UnmanagedType.I2)]
	public short dmTTOption;

	[MarshalAs(UnmanagedType.I2)]
	public short dmCollate;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
	public string dmFormName;

	[MarshalAs(UnmanagedType.U2)]
	public ushort dmLogPixels;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmBitsPerPel;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmPelsWidth;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmPelsHeight;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmDisplayFlags;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmDisplayFrequency;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmICMMethod;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmICMIntent;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmMediaType;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmDitherType;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmReserved1;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmReserved2;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmPanningWidth;

	[MarshalAs(UnmanagedType.U4)]
	public uint dmPanningHeight;
}
