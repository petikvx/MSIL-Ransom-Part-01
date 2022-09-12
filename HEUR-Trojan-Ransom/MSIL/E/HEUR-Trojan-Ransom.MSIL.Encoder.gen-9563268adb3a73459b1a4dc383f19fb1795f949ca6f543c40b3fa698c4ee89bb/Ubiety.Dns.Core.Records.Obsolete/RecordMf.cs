namespace Ubiety.Dns.Core.Records.Obsolete;

public class RecordMf : Record
{
	public string MadName { get; }

	public RecordMf(RecordReader rr)
	{
		MadName = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return MadName;
	}
}
