namespace Gecko.WebIDL;

public class XPathNSResolver : WebIDLBase
{
	public XPathNSResolver(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string LookupNamespaceURI(string prefix)
	{
		return CallMethod<string>("lookupNamespaceURI", new object[1] { prefix });
	}
}
