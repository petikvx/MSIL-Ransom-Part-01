using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ubiety.Dns.Core.Records;

public class RecordTsig : Record
{
	private readonly byte[] _mac;

	private readonly byte[] _otherData;

	public string AlgorithmName { get; set; }

	public long TimeSigned { get; set; }

	public ushort Fudge { get; set; }

	public ushort MacSize { get; set; }

	public List<byte> Mac => new List<byte>(_mac);

	public ushort OriginalId { get; set; }

	public ushort Error { get; set; }

	public ushort OtherLength { get; set; }

	public List<byte> OtherData => new List<byte>(_otherData);

	public RecordTsig(RecordReader rr)
	{
		AlgorithmName = rr.ReadDomainName();
		TimeSigned = rr.ReadUInt32() | rr.ReadUInt32();
		Fudge = rr.ReadUInt16();
		MacSize = rr.ReadUInt16();
		_mac = rr.ReadBytes(MacSize);
		OriginalId = rr.ReadUInt16();
		Error = rr.ReadUInt16();
		OtherLength = rr.ReadUInt16();
		_otherData = rr.ReadBytes(OtherLength);
	}

	public override string ToString()
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(TimeSigned);
		string text = dateTime.ToShortDateString() + " " + dateTime.ToShortTimeString();
		return string.Format(CultureInfo.InvariantCulture, "{0} {1} {2} {3} {4}", AlgorithmName, text, Fudge, OriginalId, Error);
	}
}
