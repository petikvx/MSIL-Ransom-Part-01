using System;
using System.Net;

namespace Ubiety.Dns.Core.Records.General;

public class RecordAaaa : Record
{
	public IPAddress Address { get; }

	public RecordAaaa(RecordReader reader)
	{
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		Address = IPAddress.Parse($"{reader.ReadUInt16():x4}:{reader.ReadUInt16():x4}:{reader.ReadUInt16():x4}:{reader.ReadUInt16():x4}:{reader.ReadUInt16():x4}:{reader.ReadUInt16():x4}:{reader.ReadUInt16():x4}:{reader.ReadUInt16():x4}");
	}

	public override string ToString()
	{
		return Address.ToString();
	}
}
