using System;
using System.Runtime.InteropServices;

namespace Kzzdehomtdt;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct CopyData
{
	public IntPtr dwData;

	public int cbData;

	[MarshalAs(UnmanagedType.LPWStr)]
	public string lpData;
}
