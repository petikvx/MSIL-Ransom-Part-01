namespace Ubiety.Dns.Core.Records.Mail;

public class RecordMr : Record
{
	public string NewName { get; }

	public RecordMr(RecordReader rr)
	{
		NewName = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return NewName;
	}
}
