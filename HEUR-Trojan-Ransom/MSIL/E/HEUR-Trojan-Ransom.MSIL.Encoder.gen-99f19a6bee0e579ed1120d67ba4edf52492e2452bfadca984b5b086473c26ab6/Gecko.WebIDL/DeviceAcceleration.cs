namespace Gecko.WebIDL;

public class DeviceAcceleration : WebIDLBase
{
	public double? X => GetProperty<double?>("x");

	public double? Y => GetProperty<double?>("y");

	public double? Z => GetProperty<double?>("z");

	public DeviceAcceleration(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
