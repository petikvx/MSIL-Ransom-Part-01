using System.Net;
using System.Net.NetworkInformation;

namespace FireXc;

internal class ClientInfo
{
	public static string GetMacAddress()
	{
		string text = "";
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		foreach (NetworkInterface networkInterface in allNetworkInterfaces)
		{
			if (networkInterface.OperationalStatus == OperationalStatus.Up)
			{
				text += networkInterface.GetPhysicalAddress().ToString();
				break;
			}
		}
		return text;
	}

	public static string GetIpAdress()
	{
		return Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
	}
}
