namespace Gecko.WebIDL;

public class ServiceWorkerGlobalScope : WebIDLBase
{
	public nsISupports Clients => GetProperty<nsISupports>("clients");

	public nsISupports Registration => GetProperty<nsISupports>("registration");

	public ServiceWorkerGlobalScope(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<bool> SkipWaiting()
	{
		return CallMethod<Promise<bool>>("skipWaiting", new object[0]);
	}
}
