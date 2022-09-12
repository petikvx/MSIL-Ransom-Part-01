namespace Gecko.WebIDL;

public class RequestSyncManager : WebIDLBase
{
	public RequestSyncManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports[]> Registrations()
	{
		return CallMethod<Promise<nsISupports[]>>("registrations", new object[0]);
	}
}
