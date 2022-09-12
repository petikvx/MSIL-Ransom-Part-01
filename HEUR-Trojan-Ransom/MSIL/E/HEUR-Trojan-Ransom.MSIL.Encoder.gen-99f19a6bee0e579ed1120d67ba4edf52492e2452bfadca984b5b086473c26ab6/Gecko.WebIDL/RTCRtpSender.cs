namespace Gecko.WebIDL;

public class RTCRtpSender : WebIDLBase
{
	public nsISupports Track => GetProperty<nsISupports>("track");

	public RTCRtpSender(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise ReplaceTrack(nsISupports track)
	{
		return CallMethod<Promise>("replaceTrack", new object[1] { track });
	}
}
