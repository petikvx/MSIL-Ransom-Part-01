namespace Gecko.WebIDL;

public class GlobalFetch : WebIDLBase
{
	public GlobalFetch(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> Fetch(WebIDLUnion<nsISupports, USVString> input)
	{
		return CallMethod<Promise<nsISupports>>("fetch", new object[1] { input });
	}

	public Promise<nsISupports> Fetch(WebIDLUnion<nsISupports, USVString> input, object init)
	{
		return CallMethod<Promise<nsISupports>>("fetch", new object[2] { input, init });
	}
}
