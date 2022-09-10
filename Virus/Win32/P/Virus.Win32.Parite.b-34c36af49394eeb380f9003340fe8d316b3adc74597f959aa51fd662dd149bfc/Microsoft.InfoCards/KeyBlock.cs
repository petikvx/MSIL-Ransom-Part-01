using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

[StructLayout(LayoutKind.Explicit, Size = 592)]
internal struct KeyBlock
{
	public const int StructSize = 592;

	public const int EncryptedKeyBlockSize = 512;

	public const int Pkcs5IVBlockSize = 32;

	public const int SaltBlockSize = 32;

	public const int IVOffset = 0;

	public const int SaltOffset = 32;

	public const int IterationCountOffset = 64;

	public const int EncryptedKeySizeOffset = 68;

	public const int EncryptedKeyOffset = 72;

	public const int ReservedPaddingOffset = 584;

	public const int KeyTypeOffset = 588;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	public byte IV;

	[FieldOffset(32)]
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
	public byte Salt;

	[FieldOffset(64)]
	[MarshalAs(UnmanagedType.I4)]
	public int IterationCount;

	[FieldOffset(68)]
	[MarshalAs(UnmanagedType.I4)]
	public int EncryptedKeySize;

	[FieldOffset(72)]
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
	public byte EncryptedKey;

	[FieldOffset(584)]
	[MarshalAs(UnmanagedType.I4)]
	private int ReservedPadding;

	[FieldOffset(588)]
	[MarshalAs(UnmanagedType.I4)]
	public int KeyType;
}
