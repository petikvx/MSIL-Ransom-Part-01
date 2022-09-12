namespace Gecko.WebIDL;

public class GamepadEvent : WebIDLBase
{
	public nsISupports Gamepad => GetProperty<nsISupports>("gamepad");

	public GamepadEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
