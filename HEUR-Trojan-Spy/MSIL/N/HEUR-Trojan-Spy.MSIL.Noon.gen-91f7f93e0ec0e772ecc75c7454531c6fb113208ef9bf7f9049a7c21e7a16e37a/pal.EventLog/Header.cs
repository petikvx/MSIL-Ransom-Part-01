using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace pal.EventLog;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct Header
{
	public uint HeaderLength;

	public uint Signature;

	public uint Unknown1;

	public uint Unknown2;

	public uint Unknown3;

	public uint FooterOffset;

	public uint NextIndex;

	public uint FileLength;

	public uint Unknown6;

	public uint Unknown7;

	public uint Unknown8;

	public uint EndHeaderLength;

	public static Header Fetch(BinaryReader reader)
	{
		reader.BaseStream.Seek(0L, SeekOrigin.Begin);
		byte[] value = reader.ReadBytes(Marshal.SizeOf(typeof(Header)));
		GCHandle gCHandle = GCHandle.Alloc(value, GCHandleType.Pinned);
		Header result = (Header)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(Header));
		gCHandle.Free();
		return result;
	}

	public void Verify()
	{
		if (Signature != 1699505740)
		{
			throw new Exception();
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("HeaderLength: ").Append(HeaderLength).Append("\n");
		stringBuilder.Append("Signature: ").Append(Signature).Append("\n");
		stringBuilder.Append("FooterOffset: ").Append(FooterOffset).Append("\n");
		stringBuilder.Append("NextIndex: ").Append(NextIndex).Append("\n");
		stringBuilder.Append("FileLength: ").Append(FileLength).Append("\n");
		stringBuilder.Append("EndHeaderLength: ").Append(EndHeaderLength).Append("\n");
		return stringBuilder.ToString();
	}
}
