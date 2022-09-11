using System;
using System.Net;
using System.Net.Sockets;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

public static class WnAmmOkZEmVXl
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void iUXgyfrbqWEqhEN(string string_0, string string_1, string string_2)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		for (int i = 0; i <= 5; i++)
		{
			array[i] = byte.MaxValue;
		}
		string[] array2 = null;
		array2 = ((!string_0.Contains(getString_0(107409212))) ? string_0.Split(new char[1] { ':' }) : string_0.Split(new char[1] { '-' }));
		if (array2.Length != 6)
		{
			throw new ArgumentException(getString_0(107409207));
		}
		int num = 6;
		for (int i = 0; i < 16; i++)
		{
			for (int j = 0; j < 6; j++)
			{
				array[num + i * 6 + j] = (byte)Convert.ToInt32(array2[j], 16);
			}
		}
		IPAddress ipaddress_ = IPAddress.Parse(string_1);
		IPAddress ipaddress_2 = IPAddress.Parse(string_2);
		IPAddress broadcastAddress = ipaddress_.GetBroadcastAddress(ipaddress_2);
		udpClient.Send(array, array.Length, broadcastAddress.ToString(), 3);
	}

	public static IPAddress GetBroadcastAddress(this IPAddress ipaddress_0, IPAddress ipaddress_1)
	{
		byte[] addressBytes = ipaddress_0.GetAddressBytes();
		byte[] addressBytes2 = ipaddress_1.GetAddressBytes();
		if (addressBytes.Length != addressBytes2.Length)
		{
			throw new ArgumentException(getString_0(107409130));
		}
		byte[] array = new byte[addressBytes.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)(addressBytes[i] | (addressBytes2[i] ^ 0xFFu));
		}
		return new IPAddress(array);
	}

	static WnAmmOkZEmVXl()
	{
		Strings.CreateGetStringDelegate(typeof(WnAmmOkZEmVXl));
	}
}
