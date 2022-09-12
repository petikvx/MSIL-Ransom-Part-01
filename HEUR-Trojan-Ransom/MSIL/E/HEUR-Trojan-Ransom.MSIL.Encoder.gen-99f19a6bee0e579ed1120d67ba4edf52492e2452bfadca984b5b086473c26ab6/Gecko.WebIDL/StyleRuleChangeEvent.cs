namespace Gecko.WebIDL;

public class StyleRuleChangeEvent : WebIDLBase
{
	public nsISupports Stylesheet => GetProperty<nsISupports>("stylesheet");

	public nsISupports Rule => GetProperty<nsISupports>("rule");

	public StyleRuleChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
