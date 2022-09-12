namespace Gecko.WebIDL;

public class EventSource : WebIDLBase
{
	public string Url => GetProperty<string>("url");

	public bool WithCredentials => GetProperty<bool>("withCredentials");

	public ushort ReadyState => GetProperty<ushort>("readyState");

	public EventSource(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Close()
	{
		CallVoidMethod("close");
	}
}
