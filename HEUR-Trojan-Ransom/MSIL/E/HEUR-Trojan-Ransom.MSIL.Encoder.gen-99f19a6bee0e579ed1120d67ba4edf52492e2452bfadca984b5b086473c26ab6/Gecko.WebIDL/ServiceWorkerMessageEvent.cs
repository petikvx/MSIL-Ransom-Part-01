namespace Gecko.WebIDL;

public class ServiceWorkerMessageEvent : WebIDLBase
{
	public object Data => GetProperty<object>("data");

	public string Origin => GetProperty<string>("origin");

	public string LastEventId => GetProperty<string>("lastEventId");

	public WebIDLUnion<nsISupports, nsISupports> Source => GetProperty<WebIDLUnion<nsISupports, nsISupports>>("source");

	public nsISupports Ports => GetProperty<nsISupports>("ports");

	public ServiceWorkerMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
