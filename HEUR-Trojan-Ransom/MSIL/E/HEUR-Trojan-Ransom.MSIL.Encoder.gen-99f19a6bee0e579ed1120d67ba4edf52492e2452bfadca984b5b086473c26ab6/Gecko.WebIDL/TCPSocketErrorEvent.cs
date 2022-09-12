namespace Gecko.WebIDL;

public class TCPSocketErrorEvent : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public string Message => GetProperty<string>("message");

	public TCPSocketErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
