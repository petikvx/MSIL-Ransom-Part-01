namespace Gecko.WebIDL;

public class PresentationRequest : WebIDLBase
{
	public PresentationRequest(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> Start()
	{
		return CallMethod<Promise<nsISupports>>("start", new object[0]);
	}

	public Promise<nsISupports> GetAvailability()
	{
		return CallMethod<Promise<nsISupports>>("getAvailability", new object[0]);
	}
}
