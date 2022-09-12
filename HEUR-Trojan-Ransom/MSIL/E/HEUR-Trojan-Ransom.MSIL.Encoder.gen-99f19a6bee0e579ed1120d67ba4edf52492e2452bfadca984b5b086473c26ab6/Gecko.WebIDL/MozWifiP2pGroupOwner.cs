namespace Gecko.WebIDL;

public class MozWifiP2pGroupOwner : WebIDLBase
{
	public string GroupName => GetProperty<string>("groupName");

	public string MacAddress => GetProperty<string>("macAddress");

	public string IpAddress => GetProperty<string>("ipAddress");

	public string Passphrase => GetProperty<string>("passphrase");

	public string Ssid => GetProperty<string>("ssid");

	public object WpsCapabilities => GetProperty<object>("wpsCapabilities");

	public uint Freq => GetProperty<uint>("freq");

	public bool IsLocal => GetProperty<bool>("isLocal");

	public MozWifiP2pGroupOwner(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
