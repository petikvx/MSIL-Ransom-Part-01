namespace Gecko.WebIDL;

public class OfflineAudioContext : WebIDLBase
{
	public OfflineAudioContext(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> StartRendering()
	{
		return CallMethod<Promise<nsISupports>>("startRendering", new object[0]);
	}
}
