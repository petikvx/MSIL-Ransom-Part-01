namespace Gecko.WebIDL;

public class DeviceLightEvent : WebIDLBase
{
	public double Value => GetProperty<double>("value");

	public DeviceLightEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
