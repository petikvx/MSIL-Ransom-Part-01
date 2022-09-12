namespace Gecko.WebIDL;

public class SEManager : WebIDLBase
{
	public SEManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports[]> GetSEReaders()
	{
		return CallMethod<Promise<nsISupports[]>>("getSEReaders", new object[0]);
	}
}
