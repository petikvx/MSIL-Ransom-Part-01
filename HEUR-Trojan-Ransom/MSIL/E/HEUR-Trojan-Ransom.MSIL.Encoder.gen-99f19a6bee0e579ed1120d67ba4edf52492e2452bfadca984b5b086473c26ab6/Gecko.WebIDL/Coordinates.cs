namespace Gecko.WebIDL;

public class Coordinates : WebIDLBase
{
	public double Latitude => GetProperty<double>("latitude");

	public double Longitude => GetProperty<double>("longitude");

	public double? Altitude => GetProperty<double?>("altitude");

	public double Accuracy => GetProperty<double>("accuracy");

	public double? AltitudeAccuracy => GetProperty<double?>("altitudeAccuracy");

	public double? Heading => GetProperty<double?>("heading");

	public double? Speed => GetProperty<double?>("speed");

	public Coordinates(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
