namespace Gecko.WebIDL;

public class GamepadAxisMoveEvent : WebIDLBase
{
	public uint Axis => GetProperty<uint>("axis");

	public double Value => GetProperty<double>("value");

	public GamepadAxisMoveEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
