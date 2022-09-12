namespace Gecko.WebIDL;

public class TCPServerSocket : WebIDLBase
{
	public ushort LocalPort => GetProperty<ushort>("localPort");

	public TCPServerSocket(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Close()
	{
		CallVoidMethod("close");
	}
}
