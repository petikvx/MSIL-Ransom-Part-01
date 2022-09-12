namespace Gecko.WebIDL;

public class MozWifiConnectionInfo : WebIDLBase
{
	public short SignalStrength => GetProperty<short>("signalStrength");

	public short RelSignalStrength => GetProperty<short>("relSignalStrength");

	public int LinkSpeed => GetProperty<int>("linkSpeed");

	public string IpAddress => GetProperty<string>("ipAddress");

	public MozWifiConnectionInfo(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
