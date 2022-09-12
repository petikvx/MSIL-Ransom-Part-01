namespace Ubiety.Dns.Core.Records.Mail;

public class RecordMb : Record
{
	public string MadName { get; }

	public RecordMb(RecordReader rr)
	{
		MadName = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return MadName;
	}
}
