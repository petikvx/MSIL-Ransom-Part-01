namespace Ubiety.Dns.Core.Records;

public class RecordPx : Record
{
	public ushort Preference { get; set; }

	public string Map822 { get; set; }

	public string MapX400 { get; set; }

	public RecordPx(RecordReader rr)
	{
		Preference = rr.ReadUInt16();
		Map822 = rr.ReadDomainName();
		MapX400 = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return $"{Preference} {Map822} {MapX400}";
	}
}
