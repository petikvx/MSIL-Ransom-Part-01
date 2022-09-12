namespace Gecko.WebIDL;

public class RTCDataChannelEvent : WebIDLBase
{
	public nsISupports Channel => GetProperty<nsISupports>("channel");

	public RTCDataChannelEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
