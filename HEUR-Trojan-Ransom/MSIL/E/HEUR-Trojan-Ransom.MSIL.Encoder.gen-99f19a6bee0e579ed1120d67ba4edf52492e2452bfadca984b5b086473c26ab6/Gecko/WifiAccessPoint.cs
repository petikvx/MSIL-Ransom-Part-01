namespace Gecko;

public sealed class WifiAccessPoint
{
	private nsIWifiAccessPoint _wifiAccessPoint;

	public string Mac => nsString.Get(_wifiAccessPoint.GetMacAttribute);

	public string Ssid => nsString.Get(_wifiAccessPoint.GetSsidAttribute);

	public WifiAccessPoint(nsIWifiAccessPoint wifiAccessPoint)
	{
		_wifiAccessPoint = wifiAccessPoint;
	}
}
