namespace Gecko.WebIDL;

public class MozWifiP2pManager : WebIDLBase
{
	public bool Enabled => GetProperty<bool>("enabled");

	public nsISupports GroupOwner => GetProperty<nsISupports>("groupOwner");

	public MozWifiP2pManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports SetScanEnabled(bool enabled)
	{
		return CallMethod<nsISupports>("setScanEnabled", new object[1] { enabled });
	}

	public nsISupports Connect(string address, WPSMethod wpsMethod)
	{
		return CallMethod<nsISupports>("connect", new object[2] { address, wpsMethod });
	}

	public nsISupports Connect(string address, WPSMethod wpsMethod, sbyte goIntent)
	{
		return CallMethod<nsISupports>("connect", new object[3] { address, wpsMethod, goIntent });
	}

	public nsISupports Disconnect(string address)
	{
		return CallMethod<nsISupports>("disconnect", new object[1] { address });
	}

	public nsISupports GetPeerList()
	{
		return CallMethod<nsISupports>("getPeerList", new object[0]);
	}

	public nsISupports SetPairingConfirmation(bool accepted)
	{
		return CallMethod<nsISupports>("setPairingConfirmation", new object[1] { accepted });
	}

	public nsISupports SetPairingConfirmation(bool accepted, string pin)
	{
		return CallMethod<nsISupports>("setPairingConfirmation", new object[2] { accepted, pin });
	}

	public nsISupports SetDeviceName(string deviceName)
	{
		return CallMethod<nsISupports>("setDeviceName", new object[1] { deviceName });
	}
}
