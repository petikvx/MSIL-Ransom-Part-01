using System.Runtime.InteropServices;

namespace Microsoft.InfoCards;

[StructLayout(LayoutKind.Explicit, Size = 64)]
internal struct SecondaryIndexItem
{
	public const int StructSize = 64;

	public const int HashValueSize = 60;

	public const int LocalIdSize = 4;

	public const int HashValueOffset = 0;

	public const int LocalIdOffset = 60;

	[FieldOffset(0)]
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
	public byte HashValue;

	[FieldOffset(60)]
	[MarshalAs(UnmanagedType.I4)]
	public int LocalId;
}
