using System.Runtime.InteropServices;

namespace youknowcaliber;

internal class BSSID
{
	[DllImport("iphlpapi.dll", ExactSpelling = true)]
	private static extern int SendARP(int destIp, int srcIP, byte[] macAddr, ref uint physicalAddrLen);

	public static extern string GetBSSID();

	public static extern string GetDefaultGateway();

	public extern BSSID();
}
