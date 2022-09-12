namespace Gecko.WebIDL;

public class NetworkInformation : WebIDLBase
{
	public ConnectionType Type => GetProperty<ConnectionType>("type");

	public NetworkInformation(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
