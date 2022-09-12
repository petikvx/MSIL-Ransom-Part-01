namespace Ubiety.Dns.Core.Records;

public class RecordPtr : Record
{
	public string PointerDomain { get; set; }

	public RecordPtr(RecordReader rr)
	{
		PointerDomain = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return PointerDomain;
	}
}
