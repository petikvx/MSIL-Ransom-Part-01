namespace Gecko.WebIDL;

public class MessageChannel : WebIDLBase
{
	public nsISupports Port1 => GetProperty<nsISupports>("port1");

	public nsISupports Port2 => GetProperty<nsISupports>("port2");

	public MessageChannel(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
