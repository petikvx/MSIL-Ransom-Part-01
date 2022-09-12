namespace Ubiety.Dns.Core.Records;

public class RecordSoa : Record
{
	public string PrimaryNameserver { get; set; }

	public string ResponsibleDomain { get; set; }

	public uint Serial { get; set; }

	public uint Refresh { get; set; }

	public uint Retry { get; set; }

	public uint Expire { get; set; }

	public uint Minimum { get; set; }

	public RecordSoa(RecordReader rr)
	{
		PrimaryNameserver = rr.ReadDomainName();
		ResponsibleDomain = rr.ReadDomainName();
		Serial = rr.ReadUInt32();
		Refresh = rr.ReadUInt32();
		Retry = rr.ReadUInt32();
		Expire = rr.ReadUInt32();
		Minimum = rr.ReadUInt32();
	}

	public override string ToString()
	{
		return $"{PrimaryNameserver} {ResponsibleDomain} {Serial} {Refresh} {Retry} {Expire} {Minimum}";
	}
}
