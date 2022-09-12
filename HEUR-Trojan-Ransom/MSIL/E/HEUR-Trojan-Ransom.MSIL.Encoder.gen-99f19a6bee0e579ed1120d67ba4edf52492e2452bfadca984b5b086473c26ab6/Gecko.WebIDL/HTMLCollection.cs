namespace Gecko.WebIDL;

public class HTMLCollection : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public HTMLCollection(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
