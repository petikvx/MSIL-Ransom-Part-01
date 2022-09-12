using System.Collections.Generic;
using System.Text;
using Ubiety.Dns.Core.Common;

namespace Ubiety.Dns.Core.Records.Obsolete;

public class RecordNxt : Record
{
	private readonly byte[] _bitmap;

	public string NextDomainName { get; }

	public List<byte> Bitmap => new List<byte>(_bitmap);

	public RecordNxt(RecordReader rr)
	{
		ushort num = rr.ReadUInt16(-2);
		NextDomainName = rr.ReadDomainName();
		num = (ushort)(num - (ushort)rr.Position);
		_bitmap = new byte[num];
		_bitmap = rr.ReadBytes(num);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 1; i < _bitmap.Length * 8; i++)
		{
			if (IsSet(i))
			{
				RecordType recordType = (RecordType)i;
				stringBuilder.Append(" " + recordType);
			}
		}
		return $"{NextDomainName}{stringBuilder}";
	}

	private bool IsSet(int bitNr)
	{
		int num = bitNr / 8;
		int num2 = bitNr % 8;
		byte b = _bitmap[num];
		int num3 = 1 << num2;
		return (b & num3) != 0;
	}
}
