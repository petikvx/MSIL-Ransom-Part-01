namespace Ubiety.Dns.Core.Records;

public class RecordSrv : Record
{
	public ushort Priority { get; set; }

	public ushort Weight { get; set; }

	public ushort Port { get; set; }

	public string Target { get; set; }

	public RecordSrv(RecordReader rr)
	{
		Priority = rr.ReadUInt16();
		Weight = rr.ReadUInt16();
		Port = rr.ReadUInt16();
		Target = rr.ReadDomainName();
	}

	public override string ToString()
	{
		return $"{Priority} {Weight} {Port} {Target}";
	}
}
