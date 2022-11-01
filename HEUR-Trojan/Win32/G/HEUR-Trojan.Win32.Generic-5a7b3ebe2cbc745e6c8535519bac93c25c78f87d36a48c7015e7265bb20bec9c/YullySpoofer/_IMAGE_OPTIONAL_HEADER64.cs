using System.Runtime.InteropServices;

namespace YullySpoofer;

[StructLayout(LayoutKind.Explicit)]
public struct _IMAGE_OPTIONAL_HEADER64
{
	[FieldOffset(0)]
	public ushort Magic;

	[FieldOffset(16)]
	public uint AddressOfEntryPoint;

	[FieldOffset(24)]
	public ulong ImageBase;

	[FieldOffset(56)]
	public uint SizeOfImage;

	[FieldOffset(60)]
	public uint SizeOfHeaders;
}
