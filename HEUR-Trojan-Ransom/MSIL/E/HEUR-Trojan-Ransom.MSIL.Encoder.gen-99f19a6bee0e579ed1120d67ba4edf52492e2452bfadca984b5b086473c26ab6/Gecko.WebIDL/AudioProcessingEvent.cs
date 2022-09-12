namespace Gecko.WebIDL;

public class AudioProcessingEvent : WebIDLBase
{
	public double PlaybackTime => GetProperty<double>("playbackTime");

	public nsISupports InputBuffer => GetProperty<nsISupports>("inputBuffer");

	public nsISupports OutputBuffer => GetProperty<nsISupports>("outputBuffer");

	public AudioProcessingEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
