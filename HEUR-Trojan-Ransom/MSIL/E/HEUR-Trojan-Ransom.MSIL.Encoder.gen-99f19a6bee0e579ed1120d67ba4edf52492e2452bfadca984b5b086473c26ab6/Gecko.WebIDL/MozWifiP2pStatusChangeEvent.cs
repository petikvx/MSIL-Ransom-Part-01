namespace Gecko.WebIDL;

public class MozWifiP2pStatusChangeEvent : WebIDLBase
{
	public string PeerAddress => GetProperty<string>("peerAddress");

	public MozWifiP2pStatusChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
