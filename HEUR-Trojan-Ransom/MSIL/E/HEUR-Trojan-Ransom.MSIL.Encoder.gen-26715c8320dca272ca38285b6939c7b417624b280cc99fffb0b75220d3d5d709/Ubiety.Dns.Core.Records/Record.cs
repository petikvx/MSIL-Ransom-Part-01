using System.Collections.Generic;

namespace Ubiety.Dns.Core.Records;

public abstract class Record
{
	public List<byte> RecordData { get; }

	public ResourceRecord ResourceRecord { get; set; }

	protected Record()
	{
	}

	protected Record(RecordReader reader)
	{
		ushort length = reader.ReadUInt16(-2);
		RecordData = new List<byte>(reader.ReadBytes(length));
	}

	public override string ToString()
	{
		return GetType().Name + " is not-used";
	}
}
