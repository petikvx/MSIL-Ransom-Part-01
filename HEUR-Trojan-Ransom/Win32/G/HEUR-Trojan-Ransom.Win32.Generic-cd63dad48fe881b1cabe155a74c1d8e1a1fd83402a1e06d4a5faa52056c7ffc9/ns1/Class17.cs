using System;
using System.Net;

namespace ns1;

internal static class Class17
{
	public static IPAddress smethod_0(this IPAddress ipaddress_0, IPAddress ipaddress_1)
	{
		byte[] addressBytes = ipaddress_0.GetAddressBytes();
		byte[] addressBytes2 = ipaddress_1.GetAddressBytes();
		if (addressBytes.Length != addressBytes2.Length)
		{
			throw new ArgumentException("Lengths of IP address and subnet mask do not match.");
		}
		byte[] array = new byte[addressBytes.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)(addressBytes[i] | (addressBytes2[i] ^ 0xFFu));
		}
		return new IPAddress(array);
	}
}
