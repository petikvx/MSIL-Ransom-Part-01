namespace Gecko.WebIDL;

public class Cache : WebIDLBase
{
	public Cache(nsIDOMWindow globalWindow, nsISupports thisObject)
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

	public Promise<nsISupports[]> MatchAll()
	{
		return CallMethod<Promise<nsISupports[]>>("matchAll", new object[0]);
	}

	public Promise<nsISupports[]> MatchAll(WebIDLUnion<nsISupports, USVString> request)
	{
		return CallMethod<Promise<nsISupports[]>>("matchAll", new object[1] { request });
	}

	public Promise<nsISupports[]> MatchAll(WebIDLUnion<nsISupports, USVString> request, object options)
	{
		return CallMethod<Promise<nsISupports[]>>("matchAll", new object[2] { request, options });
	}

	public Promise Add(WebIDLUnion<nsISupports, USVString> request)
	{
		return CallMethod<Promise>("add", new object[1] { request });
	}

	public Promise AddAll(WebIDLUnion<nsISupports, USVString> requests)
	{
		return CallMethod<Promise>("addAll", new object[1] { requests });
	}

	public Promise Put(WebIDLUnion<nsISupports, USVString> request, nsISupports response)
	{
		return CallMethod<Promise>("put", new object[2] { request, response });
	}

	public Promise<bool> Delete(WebIDLUnion<nsISupports, USVString> request)
	{
		return CallMethod<Promise<bool>>("delete", new object[1] { request });
	}

	public Promise<bool> Delete(WebIDLUnion<nsISupports, USVString> request, object options)
	{
		return CallMethod<Promise<bool>>("delete", new object[2] { request, options });
	}

	public Promise<nsISupports[]> Keys()
	{
		return CallMethod<Promise<nsISupports[]>>("keys", new object[0]);
	}

	public Promise<nsISupports[]> Keys(WebIDLUnion<nsISupports, USVString> request)
	{
		return CallMethod<Promise<nsISupports[]>>("keys", new object[1] { request });
	}

	public Promise<nsISupports[]> Keys(WebIDLUnion<nsISupports, USVString> request, object options)
	{
		return CallMethod<Promise<nsISupports[]>>("keys", new object[2] { request, options });
	}
}
