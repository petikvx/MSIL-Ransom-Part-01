namespace Gecko.WebIDL;

public class CacheStorage : WebIDLBase
{
	public CacheStorage(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> Match(WebIDLUnion<nsISupports, USVString> request)
	{
		return CallMethod<Promise<nsISupports>>("match", new object[1] { request });
	}

	public Promise<nsISupports> Match(WebIDLUnion<nsISupports, USVString> request, object options)
	{
		return CallMethod<Promise<nsISupports>>("match", new object[2] { request, options });
	}

	public Promise<bool> Has(string cacheName)
	{
		return CallMethod<Promise<bool>>("has", new object[1] { cacheName });
	}

	public Promise<nsISupports> Open(string cacheName)
	{
		return CallMethod<Promise<nsISupports>>("open", new object[1] { cacheName });
	}

	public Promise<bool> Delete(string cacheName)
	{
		return CallMethod<Promise<bool>>("delete", new object[1] { cacheName });
	}

	public Promise<string[]> Keys()
	{
		return CallMethod<Promise<string[]>>("keys", new object[0]);
	}
}
