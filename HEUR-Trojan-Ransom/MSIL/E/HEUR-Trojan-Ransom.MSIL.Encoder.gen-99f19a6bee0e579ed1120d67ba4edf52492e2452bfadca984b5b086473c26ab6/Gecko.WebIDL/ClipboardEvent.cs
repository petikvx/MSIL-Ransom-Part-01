namespace Gecko.WebIDL;

public class ClipboardEvent : WebIDLBase
{
	public nsISupports ClipboardData => GetProperty<nsISupports>("clipboardData");

	public ClipboardEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
