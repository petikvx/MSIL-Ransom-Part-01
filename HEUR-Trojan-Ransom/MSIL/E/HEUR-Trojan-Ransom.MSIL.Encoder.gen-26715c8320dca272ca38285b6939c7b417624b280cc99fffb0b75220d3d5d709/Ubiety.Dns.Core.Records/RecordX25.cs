namespace Ubiety.Dns.Core.Records;

public class RecordX25 : Record
{
	public string PSDNAdress { get; set; }

	public RecordX25(RecordReader rr)
	{
		PSDNAdress = rr.ReadString();
	}

	public override string ToString()
	{
		return PSDNAdress;
	}
}
