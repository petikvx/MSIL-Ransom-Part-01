namespace Gecko.WebIDL;

public class MozClirModeEvent : WebIDLBase
{
	public uint Mode => GetProperty<uint>("mode");

	public MozClirModeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
