namespace Gecko.WebIDL;

public class ServiceWorkerRegistration : WebIDLBase
{
	public nsISupports Installing => GetProperty<nsISupports>("installing");

	public nsISupports Waiting => GetProperty<nsISupports>("waiting");

	public nsISupports Active => GetProperty<nsISupports>("active");

	public USVString Scope => GetProperty<USVString>("scope");

	public ServiceWorkerRegistration(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise ShowNotification(string title)
	{
		return CallMethod<Promise>("showNotification", new object[1] { title });
	}

	public Promise ShowNotification(string title, object options)
	{
		return CallMethod<Promise>("showNotification", new object[2] { title, options });
	}

	public Promise<nsISupports[]> GetNotifications()
	{
		return CallMethod<Promise<nsISupports[]>>("getNotifications", new object[0]);
	}

	public Promise<nsISupports[]> GetNotifications(object filter)
	{
		return CallMethod<Promise<nsISupports[]>>("getNotifications", new object[1] { filter });
	}

	public Promise Update()
	{
		return CallMethod<Promise>("update", new object[0]);
	}

	public Promise<bool> Unregister()
	{
		return CallMethod<Promise<bool>>("unregister", new object[0]);
	}
}
