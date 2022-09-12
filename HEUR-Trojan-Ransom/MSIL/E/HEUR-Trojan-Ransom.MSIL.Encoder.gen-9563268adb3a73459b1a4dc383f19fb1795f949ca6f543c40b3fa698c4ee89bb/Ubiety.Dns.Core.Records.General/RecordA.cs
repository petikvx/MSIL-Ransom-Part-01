using System;
using System.Net;

namespace Ubiety.Dns.Core.Records.General;

public class RecordA : Record
{
	public IPAddress Address { get; }

	public RecordA(RecordReader reader)
	{
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		Address = IPAddress.Parse($"{reader.ReadByte()}.{reader.ReadByte()}.{reader.ReadByte()}.{reader.ReadByte()}");
	}

	public override string ToString()
	{
		return Address.ToString();
	}
}
