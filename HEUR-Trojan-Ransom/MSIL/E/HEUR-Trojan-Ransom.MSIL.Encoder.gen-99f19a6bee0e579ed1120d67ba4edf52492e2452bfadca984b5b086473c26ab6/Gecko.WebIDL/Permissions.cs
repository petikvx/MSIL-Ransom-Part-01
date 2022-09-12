namespace Gecko.WebIDL;

public class Permissions : WebIDLBase
{
	public Permissions(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> Query(object permission)
	{
		return CallMethod<Promise<nsISupports>>("query", new object[1] { permission });
	}
}
