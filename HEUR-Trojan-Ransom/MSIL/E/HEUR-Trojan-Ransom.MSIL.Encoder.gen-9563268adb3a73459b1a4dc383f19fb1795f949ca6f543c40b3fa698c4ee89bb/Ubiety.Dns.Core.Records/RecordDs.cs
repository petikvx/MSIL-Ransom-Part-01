using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Ubiety.Dns.Core.Records;

public class RecordDs : Record
{
	private readonly byte[] _digest;

	public ushort KeyTag { get; }

	public byte Algorithm { get; }

	public byte DigestType { get; }

	public List<byte> Digest => new List<byte>(_digest);

	public RecordDs(RecordReader rr)
	{
		ushort num = rr.ReadUInt16(-2);
		KeyTag = rr.ReadUInt16();
		Algorithm = rr.ReadByte();
		DigestType = rr.ReadByte();
		num = (ushort)(num - 4);
		_digest = new byte[num];
		_digest = rr.ReadBytes(num);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		byte[] digest = _digest;
		foreach (byte b in digest)
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0:x2}", new object[1] { b });
		}
		return $"{KeyTag} {Algorithm} {DigestType} {stringBuilder}";
	}
}
