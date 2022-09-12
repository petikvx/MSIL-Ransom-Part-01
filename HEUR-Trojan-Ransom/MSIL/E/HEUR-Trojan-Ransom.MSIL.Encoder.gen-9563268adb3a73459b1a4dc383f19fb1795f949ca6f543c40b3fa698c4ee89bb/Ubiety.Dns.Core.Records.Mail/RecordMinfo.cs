namespace Ubiety.Dns.Core.Records.Mail;

public class RecordMinfo : Record
{
	public string ResponsibleMailbox { get; }

	public string ErrorMailbox { get; }

	public RecordMinfo(RecordReader rr)
	{
		ResponsibleMailbox = rr.ReadDomainName();
		ErrorMailbox = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return ResponsibleMailbox + " " + ErrorMailbox;
	}
}
