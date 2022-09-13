using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

internal class Class34
{
	[DllImport("iphlpapi.dll", ExactSpelling = true)]
	private static extern int SendARP(int int_0, int int_1, byte[] byte_0, ref uint uint_0);

	public static string smethod_0()
	{
		byte[] array = new byte[6];
		uint uint_ = (uint)array.Length;
		try
		{
			if (SendARP(BitConverter.ToInt32(IPAddress.Parse(smethod_1()).GetAddressBytes(), 0), 0, array, ref uint_) != 0)
			{
				return "unknown";
			}
			string[] array2 = new string[uint_];
			for (int i = 0; i < uint_; i++)
			{
				array2[i] = array[i].ToString("x2");
			}
			return string.Join(":", array2);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return "Failed";
	}

	public static string smethod_1()
	{
		try
		{
			return (from g in (from n in NetworkInterface.GetAllNetworkInterfaces()
					where n.OperationalStatus == OperationalStatus.Up
					where n.NetworkInterfaceType != NetworkInterfaceType.Loopback
					select n).SelectMany((NetworkInterface n) => n.GetIPProperties()?.GatewayAddresses)
				select g?.Address into a
				where a != null
				select a).FirstOrDefault()!.ToString();
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return "Unknown";
	}
}
