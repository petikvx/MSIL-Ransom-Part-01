namespace Gecko.WebIDL;

public class MozMobileConnectionInfo : WebIDLBase
{
	public MobileConnectionState State => GetProperty<MobileConnectionState>("state");

	public bool Connected => GetProperty<bool>("connected");

	public bool EmergencyCallsOnly => GetProperty<bool>("emergencyCallsOnly");

	public bool Roaming => GetProperty<bool>("roaming");

	public nsISupports Network => GetProperty<nsISupports>("network");

	public MobileConnectionType Type => GetProperty<MobileConnectionType>("type");

	public int? SignalStrength => GetProperty<int?>("signalStrength");

	public ushort? RelSignalStrength => GetProperty<ushort?>("relSignalStrength");

	public nsISupports Cell => GetProperty<nsISupports>("cell");

	public MozMobileConnectionInfo(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
