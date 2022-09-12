namespace Gecko.WebIDL;

public class DeviceProximityEvent : WebIDLBase
{
	public double Value => GetProperty<double>("value");

	public double Min => GetProperty<double>("min");

	public double Max => GetProperty<double>("max");

	public DeviceProximityEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
