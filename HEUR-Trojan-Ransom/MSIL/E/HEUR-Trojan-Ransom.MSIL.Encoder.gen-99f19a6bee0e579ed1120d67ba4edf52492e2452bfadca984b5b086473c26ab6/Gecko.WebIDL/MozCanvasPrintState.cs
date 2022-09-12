namespace Gecko.WebIDL;

public class MozCanvasPrintState : WebIDLBase
{
	public nsISupports Context => GetProperty<nsISupports>("context");

	public MozCanvasPrintState(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Done()
	{
		CallVoidMethod("done");
	}
}
