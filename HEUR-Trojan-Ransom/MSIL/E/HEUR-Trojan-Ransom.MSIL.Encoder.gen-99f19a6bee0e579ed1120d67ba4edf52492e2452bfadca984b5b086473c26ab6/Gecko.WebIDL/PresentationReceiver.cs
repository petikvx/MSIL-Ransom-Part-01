namespace Gecko.WebIDL;

public class PresentationReceiver : WebIDLBase
{
	public PresentationReceiver(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> GetConnection()
	{
		return CallMethod<Promise<nsISupports>>("getConnection", new object[0]);
	}

	public Promise<nsISupports[]> GetConnections()
	{
		return CallMethod<Promise<nsISupports[]>>("getConnections", new object[0]);
	}
}
