namespace Gecko.WebIDL;

public class GamepadButton : WebIDLBase
{
	public bool Pressed => GetProperty<bool>("pressed");

	public double Value => GetProperty<double>("value");

	public GamepadButton(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
