namespace Gecko.WebIDL;

public class ParentNode : WebIDLBase
{
	public nsISupports Children => GetProperty<nsISupports>("children");

	public nsIDOMElement FirstElementChild => GetProperty<nsIDOMElement>("firstElementChild");

	public nsIDOMElement LastElementChild => GetProperty<nsIDOMElement>("lastElementChild");

	public uint ChildElementCount => GetProperty<uint>("childElementCount");

	public ParentNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
