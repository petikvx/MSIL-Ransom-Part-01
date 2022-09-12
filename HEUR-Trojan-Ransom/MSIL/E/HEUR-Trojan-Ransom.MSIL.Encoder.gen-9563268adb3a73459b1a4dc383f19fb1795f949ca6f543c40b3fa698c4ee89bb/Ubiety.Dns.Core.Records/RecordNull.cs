using System.Collections.Generic;

namespace Ubiety.Dns.Core.Records;

public class RecordNull : Record
{
	private readonly byte[] _data;

	public List<byte> Data => new List<byte>(_data);

	public RecordNull(RecordReader rr)
	{
		rr.Position -= 2;
		ushort num = rr.ReadUInt16();
		_data = new byte[num];
		_data = rr.ReadBytes(num);
	}

	public override string ToString()
	{
		return $"...binary data... ({_data.Length}) bytes";
	}
}
