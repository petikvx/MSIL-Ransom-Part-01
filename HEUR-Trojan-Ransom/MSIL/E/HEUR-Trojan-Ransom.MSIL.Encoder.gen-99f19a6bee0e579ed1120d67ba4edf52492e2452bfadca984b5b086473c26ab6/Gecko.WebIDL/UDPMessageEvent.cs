namespace Gecko.WebIDL;

public class UDPMessageEvent : WebIDLBase
{
	public string RemoteAddress => GetProperty<string>("remoteAddress");

	public ushort RemotePort => GetProperty<ushort>("remotePort");

	public object Data => GetProperty<object>("data");

	public UDPMessageEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
