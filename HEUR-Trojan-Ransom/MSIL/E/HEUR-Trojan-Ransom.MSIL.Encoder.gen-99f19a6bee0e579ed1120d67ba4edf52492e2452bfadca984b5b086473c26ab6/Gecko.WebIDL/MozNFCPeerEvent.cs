namespace Gecko.WebIDL;

public class MozNFCPeerEvent : WebIDLBase
{
	public nsISupports Peer => GetProperty<nsISupports>("peer");

	public MozNFCPeerEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
