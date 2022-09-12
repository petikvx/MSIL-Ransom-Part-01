namespace Gecko.WebIDL;

public class InputEvent : WebIDLBase
{
	public bool IsComposing => GetProperty<bool>("isComposing");

	public InputEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
