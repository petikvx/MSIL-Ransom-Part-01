namespace Ubiety.Dns.Core.Records;

public class RecordRp : Record
{
	public string MailboxDomain { get; set; }

	public string TxtDomain { get; set; }

	public RecordRp(RecordReader rr)
	{
		MailboxDomain = rr.ReadDomainName();
		TxtDomain = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return MailboxDomain + " " + TxtDomain;
	}
}
