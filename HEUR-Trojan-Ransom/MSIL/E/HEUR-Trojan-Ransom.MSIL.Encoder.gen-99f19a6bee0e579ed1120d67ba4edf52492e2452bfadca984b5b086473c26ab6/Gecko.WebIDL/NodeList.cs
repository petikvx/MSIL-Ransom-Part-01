namespace Gecko.WebIDL;

public class NodeList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public NodeList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
