namespace Gecko.WebIDL;

public class LocalMediaStream : WebIDLBase
{
	public LocalMediaStream(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Stop()
	{
		CallVoidMethod("stop");
	}
}
