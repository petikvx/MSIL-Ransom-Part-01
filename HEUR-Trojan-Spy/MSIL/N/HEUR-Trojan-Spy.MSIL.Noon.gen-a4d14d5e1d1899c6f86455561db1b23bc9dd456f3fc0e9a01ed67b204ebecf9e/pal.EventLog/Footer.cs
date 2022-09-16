using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace pal.EventLog;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
internal struct Footer
{
	public uint FooterLength;

	public uint Unknown0;

	public uint Unknown1;

	public uint Unknown2;

	public uint Unknown3;

	public uint Unknown4;

	public uint FooterOffset;

	public uint NextIndex;

	public uint Unknown7;

	public uint EndFooterLength;

	public static Footer Fetch(BinaryReader reader)
	{
		reader.BaseStream.Seek(-40L, SeekOrigin.End);
		byte[] value = reader.ReadBytes(Marshal.SizeOf(typeof(Footer)));
		GCHandle gCHandle = GCHandle.Alloc(value, GCHandleType.Pinned);
		Footer result = (Footer)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(Footer));
		gCHandle.Free();
		return result;
	}

	public void Verify()
	{
		if (Unknown0 != 286331153 || Unknown1 != 572662306 || Unknown2 != 858993459 || Unknown3 != 1145324612)
		{
			throw new Exception();
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("FooterLength: ").Append(FooterLength).Append("\n");
		stringBuilder.Append("Unknown0: ").Append(Unknown0).Append("\n");
		stringBuilder.Append("Unknown1: ").Append(Unknown1).Append("\n");
		stringBuilder.Append("Unknown2: ").Append(Unknown2).Append("\n");
		stringBuilder.Append("Unknown3: ").Append(Unknown3).Append("\n");
		stringBuilder.Append("Unknown4: ").Append(Unknown4).Append("\n");
		stringBuilder.Append("FooterOffset: ").Append(FooterOffset).Append("\n");
		stringBuilder.Append("NextIndex: ").Append(NextIndex).Append("\n");
		stringBuilder.Append("Unknown7: ").Append(Unknown7).Append("\n");
		stringBuilder.Append("EndFooterLength: ").Append(EndFooterLength).Append("\n");
		return stringBuilder.ToString();
	}
}
