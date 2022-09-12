namespace Ubiety.Dns.Core.Records;

public class RecordHinfo : Record
{
	public string Cpu { get; }

	public string Os { get; }

	public RecordHinfo(RecordReader rr)
	{
		Cpu = rr.ReadString();
		Os = rr.ReadString();
	}

	public override string ToString()
	{
		return "CPU=" + Cpu + " OS=" + Os;
	}
}
