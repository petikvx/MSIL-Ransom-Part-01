namespace Ubiety.Dns.Core.Records.General;

public class RecordCname : Record
{
	public string Cname { get; }

	public RecordCname(RecordReader rr)
	{
		Cname = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return Cname;
	}
}
