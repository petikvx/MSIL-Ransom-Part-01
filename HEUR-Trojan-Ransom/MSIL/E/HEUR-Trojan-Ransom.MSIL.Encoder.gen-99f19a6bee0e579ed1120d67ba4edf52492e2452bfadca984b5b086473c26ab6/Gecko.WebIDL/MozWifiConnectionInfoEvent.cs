namespace Gecko.WebIDL;

public class MozWifiConnectionInfoEvent : WebIDLBase
{
	public object Network => GetProperty<object>("network");

	public short SignalStrength => GetProperty<short>("signalStrength");

	public short RelSignalStrength => GetProperty<short>("relSignalStrength");

	public int LinkSpeed => GetProperty<int>("linkSpeed");

	public string IpAddress => GetProperty<string>("ipAddress");

	public MozWifiConnectionInfoEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
