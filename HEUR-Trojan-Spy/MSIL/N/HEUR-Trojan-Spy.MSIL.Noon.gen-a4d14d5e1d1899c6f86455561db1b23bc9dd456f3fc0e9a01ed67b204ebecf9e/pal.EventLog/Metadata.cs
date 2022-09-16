using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace pal.EventLog;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct Metadata
{
	public uint Length;

	public uint Reserved;

	public uint RecordNumber;

	public uint TimeGenerated;

	public uint TimeWritten;

	public uint EventID;

	public ushort EventType;

	public ushort NumStrings;

	public ushort EventCategory;

	public ushort ReservedFlags;

	public uint ClosingRecordNumber;

	public uint StringOffset;

	public uint UserSidLength;

	public uint UserSidOffset;

	public uint DataLength;

	public uint DataOffset;

	public static Metadata Fetch(BinaryReader readerPositionedAtTheRightOffset)
	{
		return Fetch(readerPositionedAtTheRightOffset.ReadBytes(Globals.MetadataSize));
	}

	public static Metadata Fetch(byte[] metadataBytes)
	{
		byte[] array = new byte[Globals.MetadataSize];
		Array.Copy(metadataBytes, array, Globals.MetadataSize);
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		Metadata result = (Metadata)Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), typeof(Metadata));
		gCHandle.Free();
		return result;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("Length: ").Append(Length).Append("\n");
		stringBuilder.Append("Reserved: ").Append(Reserved).Append("\n");
		stringBuilder.Append("RecordNumber: ").Append(RecordNumber).Append("\n");
		stringBuilder.Append("TimeGenerated: ").Append(DateTime.FromBinary(TimeGenerated)).Append("\n");
		stringBuilder.Append("TimeWritten: ").Append(DateTime.FromBinary(TimeWritten)).Append("\n");
		stringBuilder.Append("EventID: ").Append(EventID).Append("\n");
		stringBuilder.Append("EventType: ").Append(EventType).Append("\n");
		stringBuilder.Append("NumStrings: ").Append(NumStrings).Append("\n");
		stringBuilder.Append("EventCategory: ").Append(EventCategory).Append("\n");
		stringBuilder.Append("ReservedFlags: ").Append(ReservedFlags).Append("\n");
		stringBuilder.Append("ClosingRecordNumber: ").Append(ClosingRecordNumber).Append("\n");
		stringBuilder.Append("StringOffset: ").Append(StringOffset).Append("\n");
		stringBuilder.Append("UserSidLength: ").Append(UserSidLength).Append("\n");
		stringBuilder.Append("UserSidOffset: ").Append(UserSidOffset).Append("\n");
		stringBuilder.Append("DataLength: ").Append(DataLength).Append("\n");
		stringBuilder.Append("DataOffset: ").Append(DataOffset).Append("\n");
		return stringBuilder.ToString();
	}
}
