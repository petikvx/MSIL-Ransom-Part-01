namespace Ubiety.Dns.Core.Records;

public class RecordKey : Record
{
	public ushort Flags { get; set; }

	public byte Protocol { get; set; }

	public byte Algorithm { get; set; }

	public string PublicKey { get; set; }

	public RecordKey(RecordReader rr)
	{
		Flags = rr.ReadUInt16();
		Protocol = rr.ReadByte();
		Algorithm = rr.ReadByte();
		PublicKey = rr.ReadString();
	}

	public override string ToString()
	{
		return $"{Flags} {Protocol} {Algorithm} \"{PublicKey}\"";
	}
}
