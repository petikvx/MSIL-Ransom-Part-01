namespace Gecko.WebIDL;

public class StyleSheetApplicableStateChangeEvent : WebIDLBase
{
	public nsISupports Stylesheet => GetProperty<nsISupports>("stylesheet");

	public bool Applicable => GetProperty<bool>("applicable");

	public StyleSheetApplicableStateChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
