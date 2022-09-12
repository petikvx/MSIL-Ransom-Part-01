namespace Gecko.WebIDL;

public class ChildNode : WebIDLBase
{
	public ChildNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Remove()
	{
		CallVoidMethod("remove");
	}
}
