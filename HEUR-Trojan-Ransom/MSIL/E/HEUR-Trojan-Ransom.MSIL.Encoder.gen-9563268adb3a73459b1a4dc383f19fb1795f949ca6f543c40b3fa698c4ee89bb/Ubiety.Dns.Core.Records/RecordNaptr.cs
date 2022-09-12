namespace Ubiety.Dns.Core.Records;

public class RecordNaptr : Record
{
	public ushort Order { get; set; }

	public ushort Preference { get; set; }

	public string Flags { get; set; }

	public string Services { get; set; }

	public string Regexp { get; set; }

	public string Replacement { get; set; }

	public RecordNaptr(RecordReader rr)
	{
		Order = rr.ReadUInt16();
		Preference = rr.ReadUInt16();
		Flags = rr.ReadString();
		Services = rr.ReadString();
		Regexp = rr.ReadString();
		Replacement = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return $"{Order} {Preference} \"{Flags}\" \"{Services}\" \"{Regexp}\" {Replacement}";
	}
}
