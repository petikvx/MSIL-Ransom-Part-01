namespace Gecko.WebIDL;

public class PresentationAvailability : WebIDLBase
{
	public bool Value => GetProperty<bool>("value");

	public PresentationAvailability(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
