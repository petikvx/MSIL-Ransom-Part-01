using System.Runtime.InteropServices;

namespace Alphaleonis.Win32.Security;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal struct TOKEN_PRIVILEGES
{
	[MarshalAs(UnmanagedType.U4)]
	public uint PrivilegeCount;

	public LUID Luid;

	[MarshalAs(UnmanagedType.U4)]
	public uint Attributes;
}
