namespace Gecko.WebIDL;

public class TCPSocketEvent : WebIDLBase
{
	public object Data => GetProperty<object>("data");

	public TCPSocketEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
