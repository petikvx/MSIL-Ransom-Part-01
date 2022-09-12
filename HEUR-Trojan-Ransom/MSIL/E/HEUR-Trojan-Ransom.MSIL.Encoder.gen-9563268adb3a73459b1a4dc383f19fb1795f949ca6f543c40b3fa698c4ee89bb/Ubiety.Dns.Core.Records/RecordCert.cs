using System;
using System.Collections.Generic;

namespace Ubiety.Dns.Core.Records;

public class RecordCert : Record
{
	private readonly byte[] _rawKey;

	public ushort Type { get; }

	public ushort KeyTag { get; }

	public byte Algorithm { get; }

	public string PublicKey { get; }

	public List<byte> RawKey => new List<byte>(_rawKey);

	public RecordCert(RecordReader rr)
	{
		ushort num = rr.ReadUInt16(-2);
		Type = rr.ReadUInt16();
		KeyTag = rr.ReadUInt16();
		Algorithm = rr.ReadByte();
		int length = num - 5;
		_rawKey = rr.ReadBytes(length);
		PublicKey = Convert.ToBase64String(_rawKey);
	}

	public override string ToString()
	{
		return PublicKey;
	}
}
