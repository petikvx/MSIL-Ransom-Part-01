using System.Runtime.InteropServices;

namespace Lexplorer;

public struct POINTL
{
	[MarshalAs(UnmanagedType.I4)]
	public int x;

	[MarshalAs(UnmanagedType.I4)]
	public int y;
}
