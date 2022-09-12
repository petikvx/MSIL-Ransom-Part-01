namespace Gecko.WebIDL;

public class SimplePushManager : WebIDLBase
{
	public SimplePushManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Register()
	{
		return CallMethod<nsISupports>("register", new object[0]);
	}

	public nsISupports Unregister(string pushEndpoint)
	{
		return CallMethod<nsISupports>("unregister", new object[1] { pushEndpoint });
	}

	public nsISupports Registrations()
	{
		return CallMethod<nsISupports>("registrations", new object[0]);
	}
}
