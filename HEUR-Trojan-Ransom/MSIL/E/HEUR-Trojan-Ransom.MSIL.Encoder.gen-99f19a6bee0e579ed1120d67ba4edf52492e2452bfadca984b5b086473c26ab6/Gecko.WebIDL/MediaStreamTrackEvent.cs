namespace Gecko.WebIDL;

public class MediaStreamTrackEvent : WebIDLBase
{
	public nsISupports Receiver => GetProperty<nsISupports>("receiver");

	public nsISupports Track => GetProperty<nsISupports>("track");

	public nsISupports Stream => GetProperty<nsISupports>("stream");

	public MediaStreamTrackEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
