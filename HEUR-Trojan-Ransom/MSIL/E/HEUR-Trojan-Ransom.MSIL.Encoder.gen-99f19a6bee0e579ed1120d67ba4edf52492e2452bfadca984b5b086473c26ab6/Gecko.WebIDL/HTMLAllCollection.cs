namespace Gecko.WebIDL;

public class HTMLAllCollection : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public HTMLAllCollection(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsIDOMNode Item(uint index)
	{
		return CallMethod<nsIDOMNode>("item", new object[1] { index });
	}

	public WebIDLUnion<nsIDOMNode, nsISupports> Item(string name)
	{
		return CallMethod<WebIDLUnion<nsIDOMNode, nsISupports>>("item", new object[1] { name });
	}
}
