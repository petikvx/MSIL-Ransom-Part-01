namespace Gecko.WebIDL;

public class DOMCursor : WebIDLBase
{
	public bool Done => GetProperty<bool>("done");

	public DOMCursor(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Continue()
	{
		CallVoidMethod("continue");
	}
}
