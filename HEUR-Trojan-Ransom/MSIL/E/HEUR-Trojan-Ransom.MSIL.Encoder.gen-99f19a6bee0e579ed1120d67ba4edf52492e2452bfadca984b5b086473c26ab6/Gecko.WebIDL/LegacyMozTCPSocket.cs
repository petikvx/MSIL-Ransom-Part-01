namespace Gecko.WebIDL;

public class LegacyMozTCPSocket : WebIDLBase
{
	public LegacyMozTCPSocket(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports Open(string host, ushort port)
	{
		return CallMethod<nsISupports>("open", new object[2] { host, port });
	}

	public nsISupports Open(string host, ushort port, object options)
	{
		return CallMethod<nsISupports>("open", new object[3] { host, port, options });
	}

	public nsISupports Listen(ushort port)
	{
		return CallMethod<nsISupports>("listen", new object[1] { port });
	}

	public nsISupports Listen(ushort port, object options)
	{
		return CallMethod<nsISupports>("listen", new object[2] { port, options });
	}

	public nsISupports Listen(ushort port, object options, ushort backlog)
	{
		return CallMethod<nsISupports>("listen", new object[3] { port, options, backlog });
	}
}
