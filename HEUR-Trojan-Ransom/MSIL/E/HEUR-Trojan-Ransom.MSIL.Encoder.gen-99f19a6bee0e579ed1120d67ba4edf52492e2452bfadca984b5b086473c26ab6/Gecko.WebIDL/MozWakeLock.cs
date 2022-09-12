namespace Gecko.WebIDL;

public class MozWakeLock : WebIDLBase
{
	public string Topic => GetProperty<string>("topic");

	public MozWakeLock(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Unlock()
	{
		CallVoidMethod("unlock");
	}
}
