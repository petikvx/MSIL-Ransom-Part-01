namespace Gecko.WebIDL;

public class MediaKeySystemAccess : WebIDLBase
{
	public string KeySystem => GetProperty<string>("keySystem");

	public MediaKeySystemAccess(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object GetConfiguration()
	{
		return CallMethod<object>("getConfiguration", new object[0]);
	}

	public Promise<nsISupports> CreateMediaKeys()
	{
		return CallMethod<Promise<nsISupports>>("createMediaKeys", new object[0]);
	}
}
