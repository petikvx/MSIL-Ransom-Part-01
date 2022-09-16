using System.Net;
using System.Net.Sockets;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class0
{
	public static bool smethod_0(IPAddress ipaddress_0)
	{
		if (ipaddress_0.AddressFamily != AddressFamily.InterNetwork)
		{
			return false;
		}
		byte[] addressBytes = ipaddress_0.GetAddressBytes();
		if (addressBytes[0] != 10 && (addressBytes[0] != 172 || addressBytes[1] <= 15 || addressBytes[1] >= 32) && (addressBytes[0] != 192 || addressBytes[1] != 168))
		{
			return false;
		}
		return true;
	}
}
