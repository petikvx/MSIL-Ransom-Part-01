namespace Gecko.WebIDL;

public class MediaDevices : WebIDLBase
{
	public MediaDevices(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object GetSupportedConstraints()
	{
		return CallMethod<object>("getSupportedConstraints", new object[0]);
	}

	public Promise<nsISupports[]> EnumerateDevices()
	{
		return CallMethod<Promise<nsISupports[]>>("enumerateDevices", new object[0]);
	}

	public Promise<nsISupports> GetUserMedia()
	{
		return CallMethod<Promise<nsISupports>>("getUserMedia", new object[0]);
	}

	public Promise<nsISupports> GetUserMedia(object constraints)
	{
		return CallMethod<Promise<nsISupports>>("getUserMedia", new object[1] { constraints });
	}
}
