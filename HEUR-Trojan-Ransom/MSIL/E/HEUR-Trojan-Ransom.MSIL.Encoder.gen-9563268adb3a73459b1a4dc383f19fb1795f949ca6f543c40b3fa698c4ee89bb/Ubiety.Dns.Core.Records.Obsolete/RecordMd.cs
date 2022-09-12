namespace Ubiety.Dns.Core.Records.Obsolete;

public class RecordMd : Record
{
	public string MadName { get; }

	public RecordMd(RecordReader rr)
	{
		MadName = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return MadName;
	}
}
