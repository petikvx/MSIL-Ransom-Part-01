namespace Gecko.WebIDL;

public class TVManager : WebIDLBase
{
	public TVManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports[]> GetTuners()
	{
		return CallMethod<Promise<nsISupports[]>>("getTuners", new object[0]);
	}
}
