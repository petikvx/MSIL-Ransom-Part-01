using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

[StructLayout(LayoutKind.Explicit, Size = 72)]
internal struct EncryptedObjectHeader
{
	public const int StructSize = 72;

	public const int IVBlockSize = 32;

	public const int IVOffset = 0;

	public const int GlobalIdOffset = 32;

	public const int LastChangeOffset = 48;

	public const int DataSizeOffset = 56;

	public const int ObjectTypeOffset = 60;

	public const int LocalIdOffset = 64;

	public const int TailPaddingOffset = 68;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	public byte IV;

	[FieldOffset(32)]
	[MarshalAs(UnmanagedType.Struct)]
	public GlobalId GlobalId;

	[FieldOffset(48)]
	[MarshalAs(UnmanagedType.I8)]
	public long LastChange;

	[FieldOffset(56)]
	[MarshalAs(UnmanagedType.I4)]
	public int DataSize;

	[FieldOffset(60)]
	[MarshalAs(UnmanagedType.I4)]
	public int ObjectType;

	[FieldOffset(64)]
	[MarshalAs(UnmanagedType.I4)]
	public int LocalId;

	[FieldOffset(68)]
	[MarshalAs(UnmanagedType.I4)]
	private int TailPadding;
}
