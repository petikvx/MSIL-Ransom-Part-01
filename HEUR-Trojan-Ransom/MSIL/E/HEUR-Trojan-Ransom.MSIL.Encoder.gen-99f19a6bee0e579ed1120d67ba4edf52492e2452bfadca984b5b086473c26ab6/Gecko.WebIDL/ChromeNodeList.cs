namespace Gecko.WebIDL;

public class ChromeNodeList : WebIDLBase
{
	public ChromeNodeList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Append(nsIDOMNode aNode)
	{
		CallVoidMethod("append", aNode);
	}

	public void Remove(nsIDOMNode aNode)
	{
		CallVoidMethod("remove", aNode);
	}
}
