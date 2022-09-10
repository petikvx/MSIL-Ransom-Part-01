using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;

namespace Complex;

public static class WakeOnLan
{
	public struct MacIpPair
	{
		public string MacAddress;

		public string IpAddress;
	}

	public static void WakeUp(string macAddress, string ipAddress, string subnetMask)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		for (int i = 0; i <= 5; i++)
		{
			array[i] = byte.MaxValue;
		}
		string[] array2 = null;
		array2 = ((!macAddress.Contains("-")) ? macAddress.Split(new char[1] { ':' }) : macAddress.Split(new char[1] { '-' }));
		if (array2.Length != 6)
		{
			throw new ArgumentException("Incorrect MAC address supplied!");
		}
		int num = 6;
		for (int i = 0; i < 16; i++)
		{
			for (int j = 0; j < 6; j++)
			{
				array[num + i * 6 + j] = (byte)Convert.ToInt32(array2[j], 16);
			}
		}
		IPAddress address = IPAddress.Parse(ipAddress);
		IPAddress subnetMask2 = IPAddress.Parse(subnetMask);
		IPAddress broadcastAddress = address.GetBroadcastAddress(subnetMask2);
		udpClient.Send(array, array.Length, broadcastAddress.ToString(), 3);
	}

	public static IPAddress GetBroadcastAddress(this IPAddress address, IPAddress subnetMask)
	{
		byte[] addressBytes = address.GetAddressBytes();
		byte[] addressBytes2 = subnetMask.GetAddressBytes();
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

	public static string getMacByIp(string ip)
	{
		List<MacIpPair> allMacAddressesAndIppairs = GetAllMacAddressesAndIppairs();
		int num = allMacAddressesAndIppairs.FindIndex((MacIpPair x) => x.IpAddress == ip);
		if (num >= 0)
		{
			return allMacAddressesAndIppairs[num].MacAddress.ToUpper();
		}
		return null;
	}

	public static List<MacIpPair> GetAllMacAddressesAndIppairs()
	{
		List<MacIpPair> list = new List<MacIpPair>();
		Process process = new Process();
		process.StartInfo.FileName = "arp";
		process.StartInfo.Arguments = "-a ";
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.StartInfo.CreateNoWindow = true;
		process.Start();
		string input = process.StandardOutput.ReadToEnd();
		string pattern = "(?<ip>([0-9]{1,3}\\.?){4})\\s*(?<mac>([a-f0-9]{2}-?){6})";
		foreach (Match item in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
		{
			list.Add(new MacIpPair
			{
				MacAddress = item.Groups["mac"].Value,
				IpAddress = item.Groups["ip"].Value
			});
		}
		return list;
	}
}
