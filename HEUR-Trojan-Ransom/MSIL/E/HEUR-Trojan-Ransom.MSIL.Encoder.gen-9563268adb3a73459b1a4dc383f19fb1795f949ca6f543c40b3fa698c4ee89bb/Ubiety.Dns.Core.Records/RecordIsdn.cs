namespace Ubiety.Dns.Core.Records;

public class RecordIsdn : Record
{
	public string IsdnAddress { get; set; }

	public string SA { get; set; }

	public RecordIsdn(RecordReader rr)
	{
		IsdnAddress = rr.ReadString();
		SA = rr.ReadString();
	}

	public override string ToString()
	{
		return IsdnAddress + " " + SA;
	}
}
