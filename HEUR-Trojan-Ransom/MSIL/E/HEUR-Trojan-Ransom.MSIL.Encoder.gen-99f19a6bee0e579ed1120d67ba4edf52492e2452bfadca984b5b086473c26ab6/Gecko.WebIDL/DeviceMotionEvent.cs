namespace Gecko.WebIDL;

public class DeviceMotionEvent : WebIDLBase
{
	public nsISupports Acceleration => GetProperty<nsISupports>("acceleration");

	public nsISupports AccelerationIncludingGravity => GetProperty<nsISupports>("accelerationIncludingGravity");

	public nsISupports RotationRate => GetProperty<nsISupports>("rotationRate");

	public double? Interval => GetProperty<double?>("interval");

	public DeviceMotionEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitDeviceMotionEvent(string type, bool canBubble, bool cancelable, object acceleration, object accelerationIncludingGravity, object rotationRate, double? interval)
	{
		CallVoidMethod("initDeviceMotionEvent", type, canBubble, cancelable, acceleration, accelerationIncludingGravity, rotationRate, interval);
	}
}
