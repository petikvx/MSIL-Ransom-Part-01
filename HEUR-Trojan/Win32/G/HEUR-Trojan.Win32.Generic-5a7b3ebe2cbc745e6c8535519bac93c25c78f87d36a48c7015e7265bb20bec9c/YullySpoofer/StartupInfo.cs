using System.Runtime.InteropServices;

namespace YullySpoofer;

[StructLayout(LayoutKind.Explicit)]
public struct StartupInfo
{
	[FieldOffset(0)]
	public uint cb;

	[FieldOffset(60)]
	public uint dwFlags;

	[FieldOffset(64)]
	public ushort wShowWindow;
}
