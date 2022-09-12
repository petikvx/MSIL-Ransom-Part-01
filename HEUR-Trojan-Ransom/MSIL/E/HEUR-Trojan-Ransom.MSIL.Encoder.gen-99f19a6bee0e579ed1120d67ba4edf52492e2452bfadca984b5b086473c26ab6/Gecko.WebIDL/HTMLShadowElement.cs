namespace Gecko.WebIDL;

public class HTMLShadowElement : WebIDLBase
{
	public nsISupports OlderShadowRoot => GetProperty<nsISupports>("olderShadowRoot");

	public HTMLShadowElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
