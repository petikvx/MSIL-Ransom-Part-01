namespace Ubiety.Dns.Core.Records.Obsolete;

public class RecordGpos : Record
{
	public string Longitude { get; }

	public string Latitude { get; }

	public string Altitude { get; }

	public RecordGpos(RecordReader rr)
	{
		Longitude = rr.ReadString();
		Latitude = rr.ReadString();
		Altitude = rr.ReadString();
	}

	public override string ToString()
	{
		return Longitude + " " + Latitude + " " + Altitude;
	}
}
