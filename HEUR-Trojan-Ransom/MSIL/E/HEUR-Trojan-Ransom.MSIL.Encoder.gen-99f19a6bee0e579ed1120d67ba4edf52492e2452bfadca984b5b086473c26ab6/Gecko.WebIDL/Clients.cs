namespace Gecko.WebIDL;

public class Clients : WebIDLBase
{
	public Clients(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<object> Get(string id)
	{
		return CallMethod<Promise<object>>("get", new object[1] { id });
	}

	public Promise<nsISupports[]> MatchAll()
	{
		return CallMethod<Promise<nsISupports[]>>("matchAll", new object[0]);
	}

	public Promise<nsISupports[]> MatchAll(object options)
	{
		return CallMethod<Promise<nsISupports[]>>("matchAll", new object[1] { options });
	}

	public Promise<nsISupports> OpenWindow(USVString url)
	{
		return CallMethod<Promise<nsISupports>>("openWindow", new object[1] { url });
	}

	public Promise Claim()
	{
		return CallMethod<Promise>("claim", new object[0]);
	}
}
