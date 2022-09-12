namespace Gecko.WebIDL;

public class NodeFilter : WebIDLBase
{
	public NodeFilter(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public ushort AcceptNode(nsIDOMNode node)
	{
		return CallMethod<ushort>("acceptNode", new object[1] { node });
	}
}
