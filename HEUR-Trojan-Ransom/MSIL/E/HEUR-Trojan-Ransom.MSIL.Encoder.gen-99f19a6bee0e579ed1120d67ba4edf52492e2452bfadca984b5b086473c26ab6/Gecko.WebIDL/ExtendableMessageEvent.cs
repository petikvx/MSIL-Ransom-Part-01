namespace Gecko.WebIDL;

public class ExtendableMessageEvent : WebIDLBase
{
	public object Data => GetProperty<object>("data");

	public string Origin => GetProperty<string>("origin");

	public string LastEventId => GetProperty<string>("lastEventId");

	public WebIDLUnion<nsISupports, nsISupports, nsISupports> Source => GetProperty<WebIDLUnion<nsISupports, nsISupports, nsISupports>>("source");

	public nsISupports Ports => GetProperty<nsISupports>("ports");

	public ExtendableMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
