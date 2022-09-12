namespace Gecko.WebIDL;

public class TCPServerSocketEvent : WebIDLBase
{
	public nsISupports Socket => GetProperty<nsISupports>("socket");

	public TCPServerSocketEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
