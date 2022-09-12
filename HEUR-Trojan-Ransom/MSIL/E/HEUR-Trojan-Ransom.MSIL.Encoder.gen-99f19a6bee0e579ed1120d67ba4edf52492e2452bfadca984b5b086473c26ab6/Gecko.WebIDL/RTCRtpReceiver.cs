namespace Gecko.WebIDL;

public class RTCRtpReceiver : WebIDLBase
{
	public nsISupports Track => GetProperty<nsISupports>("track");

	public RTCRtpReceiver(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
