using Gecko.Interop;

namespace Gecko;

public static class WiFiMonitor
{
	private static ComPtr<nsIWifiMonitor> _wifiMonitor;

	static WiFiMonitor()
	{
		_wifiMonitor = Xpcom.GetService2<nsIWifiMonitor>("@mozilla.org/wifi/monitor;1");
	}

	public static void StartWatching(WiFiListener wifiListener)
	{
		_wifiMonitor.Instance.StartWatching(wifiListener);
	}

	public static void StopWatching(WiFiListener wifiListener)
	{
		_wifiMonitor.Instance.StopWatching(wifiListener);
	}
}
