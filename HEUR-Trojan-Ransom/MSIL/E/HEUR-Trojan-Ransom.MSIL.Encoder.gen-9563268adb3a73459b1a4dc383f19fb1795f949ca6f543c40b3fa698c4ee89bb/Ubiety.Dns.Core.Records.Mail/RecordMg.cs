namespace Ubiety.Dns.Core.Records.Mail;

public class RecordMg : Record
{
	public string MgmName { get; }

	public RecordMg(RecordReader rr)
	{
		MgmName = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return MgmName;
	}
}
