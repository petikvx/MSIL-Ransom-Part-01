using System;
using System.Net;

namespace insomnia;

internal class Class18
{
	public static IPAddress Method3(bool A_0)
	{
		return Method2(Dns.GetHostEntry(Dns.GetHostName()), A_0);
	}

	public static IPAddress Method2(IPHostEntry A_0, bool A_1)
	{
		if (A_0 == null)
		{
			throw new ArgumentNullException("host");
		}
		if (A_0.AddressList.Length != 1)
		{
			IPAddress[] addressList = A_0.AddressList;
			foreach (IPAddress iPAddress in addressList)
			{
				bool flag;
				if (!(flag = Method1(iPAddress)) || !A_1)
				{
					if (!flag && !A_1)
					{
						return iPAddress;
					}
					continue;
				}
				return iPAddress;
			}
		}
		return A_0.AddressList[0];
	}

	public static bool Method1(IPAddress A_0)
	{
		if (A_0 == null)
		{
			throw new ArgumentNullException("address");
		}
		byte[] addressBytes = A_0.GetAddressBytes();
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
