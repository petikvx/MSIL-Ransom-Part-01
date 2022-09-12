namespace Ubiety.Dns.Core.Records;

public class RecordNs : Record
{
	public string NameserverDomain { get; set; }

	public RecordNs(RecordReader rr)
	{
		NameserverDomain = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return NameserverDomain;
	}
}
