namespace Ubiety.Dns.Core.Records;

public class RecordAfsdb : Record
{
	public ushort SubType { get; }

	public string Hostname { get; }

	public RecordAfsdb(RecordReader rr)
	{
		SubType = rr.ReadUInt16();
		Hostname = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return $"{SubType}{Hostname}";
	}
}
