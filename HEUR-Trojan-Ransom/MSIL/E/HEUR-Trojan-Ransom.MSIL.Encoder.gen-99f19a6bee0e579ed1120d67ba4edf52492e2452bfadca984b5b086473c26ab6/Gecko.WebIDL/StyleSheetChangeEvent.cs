namespace Gecko.WebIDL;

public class StyleSheetChangeEvent : WebIDLBase
{
	public nsISupports Stylesheet => GetProperty<nsISupports>("stylesheet");

	public bool DocumentSheet => GetProperty<bool>("documentSheet");

	public StyleSheetChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
