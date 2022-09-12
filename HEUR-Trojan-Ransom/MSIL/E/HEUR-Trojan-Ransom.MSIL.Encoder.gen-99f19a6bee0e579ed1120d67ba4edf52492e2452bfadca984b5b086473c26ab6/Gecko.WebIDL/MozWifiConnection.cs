namespace Gecko.WebIDL;

public class MozWifiConnection : WebIDLBase
{
	public ConnectionStatus Status => GetProperty<ConnectionStatus>("status");

	public nsISupports Network => GetProperty<nsISupports>("network");

	public MozWifiConnection(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
