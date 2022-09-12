namespace Gecko.WebIDL;

public class GamepadButtonEvent : WebIDLBase
{
	public uint Button => GetProperty<uint>("button");

	public GamepadButtonEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
