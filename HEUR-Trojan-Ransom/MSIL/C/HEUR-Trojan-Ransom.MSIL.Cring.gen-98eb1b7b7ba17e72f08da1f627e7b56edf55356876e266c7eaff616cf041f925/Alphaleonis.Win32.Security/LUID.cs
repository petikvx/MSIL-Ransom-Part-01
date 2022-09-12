using System.Runtime.InteropServices;

namespace Alphaleonis.Win32.Security;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal struct LUID
{
	[MarshalAs(UnmanagedType.U4)]
	public uint LowPart;

	[MarshalAs(UnmanagedType.U4)]
	public uint HighPart;
}
