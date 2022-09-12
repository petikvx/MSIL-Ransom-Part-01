namespace Gecko.WebIDL;

public class VRPositionState : WebIDLBase
{
	public double TimeStamp => GetProperty<double>("timeStamp");

	public bool HasPosition => GetProperty<bool>("hasPosition");

	public nsISupports Position => GetProperty<nsISupports>("position");

	public nsISupports LinearVelocity => GetProperty<nsISupports>("linearVelocity");

	public nsISupports LinearAcceleration => GetProperty<nsISupports>("linearAcceleration");

	public bool HasOrientation => GetProperty<bool>("hasOrientation");

	public nsISupports Orientation => GetProperty<nsISupports>("orientation");

	public nsISupports AngularVelocity => GetProperty<nsISupports>("angularVelocity");

	public nsISupports AngularAcceleration => GetProperty<nsISupports>("angularAcceleration");

	public VRPositionState(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
