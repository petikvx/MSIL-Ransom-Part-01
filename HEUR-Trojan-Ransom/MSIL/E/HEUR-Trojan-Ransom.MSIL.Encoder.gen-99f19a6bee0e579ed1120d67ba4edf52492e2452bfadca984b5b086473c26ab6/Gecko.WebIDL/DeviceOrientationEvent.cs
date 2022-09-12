namespace Gecko.WebIDL;

public class DeviceOrientationEvent : WebIDLBase
{
	public double? Alpha => GetProperty<double?>("alpha");

	public double? Beta => GetProperty<double?>("beta");

	public double? Gamma => GetProperty<double?>("gamma");

	public bool Absolute => GetProperty<bool>("absolute");

	public DeviceOrientationEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitDeviceOrientationEvent(string type, bool canBubble, bool cancelable, double? alpha, double? beta, double? gamma, bool absolute)
	{
		CallVoidMethod("initDeviceOrientationEvent", type, canBubble, cancelable, alpha, beta, gamma, absolute);
	}
}
