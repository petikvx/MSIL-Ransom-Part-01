using System.Collections.Generic;
using System.Globalization;

namespace Ubiety.Dns.Core.Records;

public class RecordTkey : Record
{
	private readonly byte[] _keyData;

	private readonly byte[] _otherData;

	public string Algorithm { get; }

	public uint Inception { get; }

	public uint Expiration { get; }

	public ushort Mode { get; }

	public ushort Error { get; }

	public ushort KeySize { get; }

	public List<byte> KeyData => new List<byte>(_keyData);

	public ushort OtherSize { get; }

	public List<byte> OtherData => new List<byte>(_otherData);

	public RecordTkey(RecordReader rr)
	{
		Algorithm = rr.ReadDomainName();
		Inception = rr.ReadUInt32();
		Expiration = rr.ReadUInt32();
		Mode = rr.ReadUInt16();
		Error = rr.ReadUInt16();
		KeySize = rr.ReadUInt16();
		_keyData = rr.ReadBytes(KeySize);
		OtherSize = rr.ReadUInt16();
		_otherData = rr.ReadBytes(OtherSize);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, "{0} {1} {2} {3} {4}", Algorithm, Inception, Expiration, Mode, Error);
	}
}
