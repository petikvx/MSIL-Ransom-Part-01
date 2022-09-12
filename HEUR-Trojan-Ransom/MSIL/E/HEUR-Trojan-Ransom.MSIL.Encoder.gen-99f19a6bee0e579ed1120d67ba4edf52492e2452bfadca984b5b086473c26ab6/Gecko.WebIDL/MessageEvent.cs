namespace Gecko.WebIDL;

public class MessageEvent : WebIDLBase
{
	public object Data => GetProperty<object>("data");

	public string Origin => GetProperty<string>("origin");

	public string LastEventId => GetProperty<string>("lastEventId");

	public WebIDLUnion<nsIDOMWindow, nsISupports> Source => GetProperty<WebIDLUnion<nsIDOMWindow, nsISupports>>("source");

	public nsISupports Ports => GetProperty<nsISupports>("ports");

	public MessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void InitMessageEvent(string type, bool bubbles, bool cancelable, object data, string origin, string lastEventId, WebIDLUnion<nsIDOMWindow, nsISupports> source, nsISupports[] ports)
	{
		CallVoidMethod("initMessageEvent", type, bubbles, cancelable, data, origin, lastEventId, source, ports);
	}
}
