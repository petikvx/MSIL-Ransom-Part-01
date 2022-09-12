namespace Gecko.WebIDL;

public class NonDocumentTypeChildNode : WebIDLBase
{
	public nsIDOMElement PreviousElementSibling => GetProperty<nsIDOMElement>("previousElementSibling");

	public nsIDOMElement NextElementSibling => GetProperty<nsIDOMElement>("nextElementSibling");

	public NonDocumentTypeChildNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
