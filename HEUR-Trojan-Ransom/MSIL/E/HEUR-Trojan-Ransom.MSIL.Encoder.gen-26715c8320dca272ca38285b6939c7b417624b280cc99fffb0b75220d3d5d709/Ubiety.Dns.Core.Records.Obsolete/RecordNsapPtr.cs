namespace Ubiety.Dns.Core.Records.Obsolete;

public class RecordNsapPtr : Record
{
	public string Owner { get; }

	public RecordNsapPtr(RecordReader rr)
	{
		Owner = rr.ReadString();
	}

	public override string ToString()
	{
		return Owner;
	}
}
