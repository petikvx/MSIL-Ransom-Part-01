namespace Ubiety.Dns.Core.Records;

public class RecordDname : Record
{
	public string Target { get; }

	public RecordDname(RecordReader rr)
	{
		Target = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return Target;
	}
}
