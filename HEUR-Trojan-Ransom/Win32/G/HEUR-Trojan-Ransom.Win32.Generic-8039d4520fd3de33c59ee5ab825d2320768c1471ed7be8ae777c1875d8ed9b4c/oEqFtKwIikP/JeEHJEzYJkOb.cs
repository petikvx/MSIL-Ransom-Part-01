using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace oEqFtKwIikP;

public static class JeEHJEzYJkOb
{
	public struct gqGrAEHqGplrq
	{
		public string MQOlKTLIauzrZg;

		public string EGnIuQrMBKyiUoB;
	}

	[CompilerGenerated]
	private sealed class IbIuWEzLZBlLXqr
	{
		public string AYyRfDjHaXekU;

		public bool _003CgetMacByIp_003Eb__0(gqGrAEHqGplrq x)
		{
			return x.EGnIuQrMBKyiUoB == AYyRfDjHaXekU;
		}
	}

	public static void mqUQiXilyZVs(string dlrtIXzJOMDunoDB, string gPfYMkdVmjlR, string fkeyLJZiCoWJ)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		for (int i = 0; i <= 5; i++)
		{
			array[i] = byte.MaxValue;
		}
		string[] array2 = null;
		array2 = ((!dlrtIXzJOMDunoDB.Contains("-")) ? dlrtIXzJOMDunoDB.Split(new char[1] { ':' }) : dlrtIXzJOMDunoDB.Split(new char[1] { '-' }));
		if (array2.Length != 6)
		{
			throw new ArgumentException("Incorrect MAC address supplied!");
		}
		int num = 6;
		for (int j = 0; j < 16; j++)
		{
			for (int k = 0; k < 6; k++)
			{
				array[num + j * 6 + k] = (byte)Convert.ToInt32(array2[k], 16);
			}
		}
		IPAddress fUTJFEgKGUCZ = IPAddress.Parse(gPfYMkdVmjlR);
		IPAddress bxLSNMPaIciHEL = IPAddress.Parse(fkeyLJZiCoWJ);
		IPAddress broadcastAddress = fUTJFEgKGUCZ.GetBroadcastAddress(bxLSNMPaIciHEL);
		udpClient.Send(array, array.Length, broadcastAddress.ToString(), 3);
	}

	public static IPAddress GetBroadcastAddress(this IPAddress fUTJFEgKGUCZ, IPAddress bxLSNMPaIciHEL)
	{
		byte[] addressBytes = fUTJFEgKGUCZ.GetAddressBytes();
		byte[] addressBytes2 = bxLSNMPaIciHEL.GetAddressBytes();
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

	public static string UJoftNooFyymTJtu(string NuwiTsDjnIF)
	{
		List<gqGrAEHqGplrq> list = pLjkGjBPEnAwSpt();
		int num = list.FindIndex((gqGrAEHqGplrq x) => x.EGnIuQrMBKyiUoB == NuwiTsDjnIF);
		if (num >= 0)
		{
			return list[num].MQOlKTLIauzrZg.ToUpper();
		}
		return null;
	}

	public static List<gqGrAEHqGplrq> pLjkGjBPEnAwSpt()
	{
		List<gqGrAEHqGplrq> list = new List<gqGrAEHqGplrq>();
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
			list.Add(new gqGrAEHqGplrq
			{
				MQOlKTLIauzrZg = item.Groups["mac"].Value,
				EGnIuQrMBKyiUoB = item.Groups["ip"].Value
			});
		}
		return list;
	}
}
