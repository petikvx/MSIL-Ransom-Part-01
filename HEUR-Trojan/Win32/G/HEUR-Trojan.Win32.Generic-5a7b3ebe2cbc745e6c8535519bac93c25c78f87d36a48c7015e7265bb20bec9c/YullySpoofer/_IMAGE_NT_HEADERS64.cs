using System.Runtime.InteropServices;

namespace YullySpoofer;

[StructLayout(LayoutKind.Explicit)]
public struct _IMAGE_NT_HEADERS64
{
	[FieldOffset(0)]
	public uint Signature;

	[FieldOffset(4)]
	public _IMAGE_FILE_HEADER FileHeader;

	[FieldOffset(24)]
	public _IMAGE_OPTIONAL_HEADER64 OptionalHeader;
}
