using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

[StructLayout(LayoutKind.Explicit, Size = 8)]
internal struct KeyBlockV2
{
	public const int StructSize = 8;

	public const int keySizeOffset = 0;

	public const int keyDataOffset = 4;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.I4)]
	public int KeyDataSize;

	[FieldOffset(4)]
	[MarshalAs(UnmanagedType.I4)]
	public int KeyDataOffset;
}
