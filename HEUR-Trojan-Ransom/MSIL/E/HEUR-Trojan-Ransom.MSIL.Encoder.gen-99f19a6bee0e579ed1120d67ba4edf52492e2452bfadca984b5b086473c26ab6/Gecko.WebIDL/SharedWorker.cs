namespace Gecko.WebIDL;

public class SharedWorker : WebIDLBase
{
	public nsISupports Port => GetProperty<nsISupports>("port");

	public SharedWorker(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
