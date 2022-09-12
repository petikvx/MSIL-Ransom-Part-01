namespace Gecko.WebIDL;

public class MediaStreamAudioDestinationNode : WebIDLBase
{
	public nsISupports Stream => GetProperty<nsISupports>("stream");

	public MediaStreamAudioDestinationNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
