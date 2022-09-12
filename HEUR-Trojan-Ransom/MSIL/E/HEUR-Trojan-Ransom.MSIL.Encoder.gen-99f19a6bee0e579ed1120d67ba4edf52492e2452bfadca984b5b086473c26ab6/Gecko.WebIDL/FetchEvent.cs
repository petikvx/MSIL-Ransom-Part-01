namespace Gecko.WebIDL;

public class FetchEvent : WebIDLBase
{
	public nsISupports Request => GetProperty<nsISupports>("request");

	public string ClientId => GetProperty<string>("clientId");

	public bool IsReload => GetProperty<bool>("isReload");

	public FetchEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void RespondWith(Promise<nsISupports> r)
	{
		CallVoidMethod("respondWith", r);
	}
}
