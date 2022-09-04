using System;
using System.Net;

public static class GClass1
{
	public static IPAddress smethod_0(bool bool_0)
	{
		return smethod_1(Dns.GetHostEntry(Dns.GetHostName()), bool_0);
	}

	public static IPAddress smethod_1(IPHostEntry iphostEntry_0, bool bool_0)
	{
		if (iphostEntry_0 == null)
		{
			throw new ArgumentNullException("host");
		}
		if (iphostEntry_0.AddressList.Length != 1)
		{
			IPAddress[] addressList = iphostEntry_0.AddressList;
			foreach (IPAddress iPAddress in addressList)
			{
				bool flag;
				if (!(flag = smethod_2(iPAddress)) || !bool_0)
				{
					if (!flag && !bool_0)
					{
						return iPAddress;
					}
					continue;
				}
				return iPAddress;
			}
		}
		return iphostEntry_0.AddressList[0];
	}

	public static bool smethod_2(IPAddress ipaddress_0)
	{
		if (ipaddress_0 == null)
		{
			throw new ArgumentNullException("address");
		}
		byte[] addressBytes = ipaddress_0.GetAddressBytes();
		if (addressBytes[0] != 10 && (addressBytes[0] != 192 || addressBytes[1] != 168))
		{
			if (addressBytes[0] == 172 && addressBytes[1] >= 16)
			{
				return addressBytes[1] <= 31;
			}
			return false;
		}
		return true;
	}
}
