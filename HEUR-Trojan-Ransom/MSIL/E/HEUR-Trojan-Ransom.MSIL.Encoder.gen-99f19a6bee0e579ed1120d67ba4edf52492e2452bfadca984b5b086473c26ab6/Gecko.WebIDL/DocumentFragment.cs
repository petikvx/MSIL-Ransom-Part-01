namespace Gecko.WebIDL;

public class DocumentFragment : WebIDLBase
{
	public DocumentFragment(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsIDOMElement GetElementById(string elementId)
	{
		return CallMethod<nsIDOMElement>("getElementById", new object[1] { elementId });
	}

	public nsIDOMElement QuerySelector(string selectors)
	{
		return CallMethod<nsIDOMElement>("querySelector", new object[1] { selectors });
	}

	public nsISupports QuerySelectorAll(string selectors)
	{
		return CallMethod<nsISupports>("querySelectorAll", new object[1] { selectors });
	}
}
