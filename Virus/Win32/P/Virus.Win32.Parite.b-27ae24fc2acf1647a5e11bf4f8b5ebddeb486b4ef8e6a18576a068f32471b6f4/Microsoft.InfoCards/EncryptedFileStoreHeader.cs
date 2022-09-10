using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

[StructLayout(LayoutKind.Explicit, Size = 608)]
internal struct EncryptedFileStoreHeader
{
	public const int StructSize = 608;

	public const int VersionOffset = 0;

	public const int SizeOffset = 4;

	public const int KeyBlockOffset = 8;

	public const int IndexOffset = 600;

	public const int DataSizeOffset = 604;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.U4)]
	public uint Version;

	[FieldOffset(4)]
	[MarshalAs(UnmanagedType.I4)]
	public int Size;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.Struct)]
	public KeyBlock KeyBlock;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.Struct)]
	public KeyBlockV2 KeyBlockV2;

	[FieldOffset(600)]
	[MarshalAs(UnmanagedType.I4)]
	public int IndexSize;

	[FieldOffset(604)]
	[MarshalAs(UnmanagedType.I4)]
	public int DataSize;
}
