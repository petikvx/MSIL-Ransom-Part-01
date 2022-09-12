namespace Gecko.WebIDL;

public class BeforeAfterKeyboardEvent : WebIDLBase
{
	public bool? EmbeddedCancelled => GetProperty<bool?>("embeddedCancelled");

	public BeforeAfterKeyboardEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
