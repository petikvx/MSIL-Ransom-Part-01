using System.Runtime.InteropServices;

namespace Orcus.Native;

[StructLayout(LayoutKind.Explicit)]
internal struct SecretEntry
{
	[FieldOffset(0)]
	public uint dwOffset;

	[FieldOffset(4)]
	public byte SecretId;

	[FieldOffset(5)]
	public byte SecretId1;

	[FieldOffset(6)]
	public byte SecretId2;

	[FieldOffset(7)]
	public byte SecretId3;

	[FieldOffset(8)]
	public byte SecretId4;

	[FieldOffset(9)]
	public byte SecretId5;

	[FieldOffset(10)]
	public byte SecretId6;

	[FieldOffset(11)]
	public byte SecretId7;

	[FieldOffset(12)]
	public uint dwLength;
}
