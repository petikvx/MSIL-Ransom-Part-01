namespace Gecko.WebIDL;

public class DeviceRotationRate : WebIDLBase
{
	public double? Alpha => GetProperty<double?>("alpha");

	public double? Beta => GetProperty<double?>("beta");

	public double? Gamma => GetProperty<double?>("gamma");

	public DeviceRotationRate(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
