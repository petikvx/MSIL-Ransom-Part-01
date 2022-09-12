using System;

namespace Gecko;

public sealed class WiFiListener : nsIWifiListener
{
	public event Action<WifiAccessPoint[]> AccessPointsChanged;

	void nsIWifiListener.OnChange(nsIWifiAccessPoint[] accessPoints, uint aLen)
	{
		if (this.AccessPointsChanged != null)
		{
			WifiAccessPoint[] array = new WifiAccessPoint[aLen];
			for (int i = 0; i < accessPoints.Length; i++)
			{
				array[i] = new WifiAccessPoint(accessPoints[i]);
			}
			this.AccessPointsChanged(array);
		}
	}

	void nsIWifiListener.OnError(int error)
	{
	}
}
