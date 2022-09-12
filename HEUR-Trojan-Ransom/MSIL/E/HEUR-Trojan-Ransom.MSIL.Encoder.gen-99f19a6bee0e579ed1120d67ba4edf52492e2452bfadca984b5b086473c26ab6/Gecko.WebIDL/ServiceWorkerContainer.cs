namespace Gecko.WebIDL;

public class ServiceWorkerContainer : WebIDLBase
{
	public nsISupports Controller => GetProperty<nsISupports>("controller");

	public Promise<nsISupports> Ready => GetProperty<Promise<nsISupports>>("ready");

	public ServiceWorkerContainer(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> Register(USVString scriptURL)
	{
		return CallMethod<Promise<nsISupports>>("register", new object[1] { scriptURL });
	}

	public Promise<nsISupports> Register(USVString scriptURL, object options)
	{
		return CallMethod<Promise<nsISupports>>("register", new object[2] { scriptURL, options });
	}

	public Promise<nsISupports> GetRegistration()
	{
		return CallMethod<Promise<nsISupports>>("getRegistration", new object[0]);
	}

	public Promise<nsISupports> GetRegistration(USVString documentURL)
	{
		return CallMethod<Promise<nsISupports>>("getRegistration", new object[1] { documentURL });
	}

	public Promise<nsISupports[]> GetRegistrations()
	{
		return CallMethod<Promise<nsISupports[]>>("getRegistrations", new object[0]);
	}

	public string GetScopeForUrl(string url)
	{
		return CallMethod<string>("getScopeForUrl", new object[1] { url });
	}
}
