namespace Gecko.WebIDL;

public class WheelEvent : WebIDLBase
{
	public double DeltaX => GetProperty<double>("deltaX");

	public double DeltaY => GetProperty<double>("deltaY");

	public double DeltaZ => GetProperty<double>("deltaZ");

	public uint DeltaMode => GetProperty<uint>("deltaMode");

	public WheelEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
