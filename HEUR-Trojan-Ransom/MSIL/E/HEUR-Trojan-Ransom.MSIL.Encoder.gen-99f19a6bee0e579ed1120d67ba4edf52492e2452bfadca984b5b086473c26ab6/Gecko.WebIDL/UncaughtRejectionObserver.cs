namespace Gecko.WebIDL;

public class UncaughtRejectionObserver : WebIDLBase
{
	public UncaughtRejectionObserver(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void OnLeftUncaught(Promise<object> p)
	{
		CallVoidMethod("onLeftUncaught", p);
	}

	public void OnConsumed(Promise<object> p)
	{
		CallVoidMethod("onConsumed", p);
	}
}
