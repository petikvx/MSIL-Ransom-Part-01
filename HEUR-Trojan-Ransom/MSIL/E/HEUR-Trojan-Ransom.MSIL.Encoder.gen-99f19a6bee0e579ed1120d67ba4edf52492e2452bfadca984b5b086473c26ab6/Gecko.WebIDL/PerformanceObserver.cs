namespace Gecko.WebIDL;

public class PerformanceObserver : WebIDLBase
{
	public PerformanceObserver(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Observe(object options)
	{
		CallVoidMethod("observe", options);
	}

	public void Disconnect()
	{
		CallVoidMethod("disconnect");
	}
}
