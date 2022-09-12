namespace Gecko.WebIDL;

public class HTMLTemplateElement : WebIDLBase
{
	public nsISupports Content => GetProperty<nsISupports>("content");

	public HTMLTemplateElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
