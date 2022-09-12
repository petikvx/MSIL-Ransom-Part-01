namespace Gecko.WebIDL;

public class MozInterAppMessagePort : WebIDLBase
{
	public MozInterAppMessagePort(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void PostMessage(object message)
	{
		CallVoidMethod("postMessage", message);
	}

	public void Start()
	{
		CallVoidMethod("start");
	}

	public void Close()
	{
		CallVoidMethod("close");
	}
}
