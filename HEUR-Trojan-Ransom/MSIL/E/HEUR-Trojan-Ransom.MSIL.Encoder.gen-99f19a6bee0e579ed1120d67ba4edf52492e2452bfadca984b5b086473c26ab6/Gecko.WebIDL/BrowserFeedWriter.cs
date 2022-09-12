namespace Gecko.WebIDL;

public class BrowserFeedWriter : WebIDLBase
{
	public BrowserFeedWriter(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void WriteContent()
	{
		CallVoidMethod("writeContent");
	}

	public void Close()
	{
		CallVoidMethod("close");
	}
}
