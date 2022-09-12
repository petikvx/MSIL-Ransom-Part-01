namespace Ubiety.Dns.Core.Records;

public class RecordRt : Record
{
	public ushort Preference { get; set; }

	public string IntermediateHost { get; set; }

	public RecordRt(RecordReader rr)
	{
		Preference = rr.ReadUInt16();
		IntermediateHost = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return $"{Preference} {IntermediateHost}";
	}
}
