namespace Gecko.WebIDL;

public class MozWifiCapabilities : WebIDLBase
{
	public WifiSecurityMethod[] Security => GetProperty<WifiSecurityMethod[]>("security");

	public WifiWpaMethod[] EapMethod => GetProperty<WifiWpaMethod[]>("eapMethod");

	public WifiWpaPhase2Method[] EapPhase2 => GetProperty<WifiWpaPhase2Method[]>("eapPhase2");

	public WifiWpaCertificate[] Certificate => GetProperty<WifiWpaCertificate[]>("certificate");

	public MozWifiCapabilities(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
