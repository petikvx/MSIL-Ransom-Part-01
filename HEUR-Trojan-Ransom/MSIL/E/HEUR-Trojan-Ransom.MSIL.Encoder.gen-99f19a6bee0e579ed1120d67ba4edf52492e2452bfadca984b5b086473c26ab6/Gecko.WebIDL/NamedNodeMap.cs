namespace Gecko.WebIDL;

public class NamedNodeMap : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public NamedNodeMap(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports SetNamedItem(nsISupports arg)
	{
		return CallMethod<nsISupports>("setNamedItem", new object[1] { arg });
	}

	public nsISupports RemoveNamedItem(string name)
	{
		return CallMethod<nsISupports>("removeNamedItem", new object[1] { name });
	}

	public nsISupports GetNamedItemNS(string namespaceURI, string localName)
	{
		return CallMethod<nsISupports>("getNamedItemNS", new object[2] { namespaceURI, localName });
	}

	public nsISupports SetNamedItemNS(nsISupports arg)
	{
		return CallMethod<nsISupports>("setNamedItemNS", new object[1] { arg });
	}

	public nsISupports RemoveNamedItemNS(string namespaceURI, string localName)
	{
		return CallMethod<nsISupports>("removeNamedItemNS", new object[2] { namespaceURI, localName });
	}
}
