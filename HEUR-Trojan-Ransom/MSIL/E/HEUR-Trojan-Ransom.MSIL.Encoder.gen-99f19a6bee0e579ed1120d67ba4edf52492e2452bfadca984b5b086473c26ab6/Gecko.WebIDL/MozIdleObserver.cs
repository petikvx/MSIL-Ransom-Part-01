namespace Gecko.WebIDL;

public class MozIdleObserver : WebIDLBase
{
	public uint Time => GetProperty<uint>("time");

	public MozIdleObserver(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Onidle()
	{
		CallVoidMethod("onidle");
	}

	public void Onactive()
	{
		CallVoidMethod("onactive");
	}
}
