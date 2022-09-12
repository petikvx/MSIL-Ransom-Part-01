namespace Gecko.WebIDL;

public class FocusEvent : WebIDLBase
{
	public nsISupports RelatedTarget => GetProperty<nsISupports>("relatedTarget");

	public FocusEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
