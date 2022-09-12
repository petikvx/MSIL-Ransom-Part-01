namespace Gecko.WebIDL;

public class RTCPeerConnectionIceEvent : WebIDLBase
{
	public nsISupports Candidate => GetProperty<nsISupports>("candidate");

	public RTCPeerConnectionIceEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
