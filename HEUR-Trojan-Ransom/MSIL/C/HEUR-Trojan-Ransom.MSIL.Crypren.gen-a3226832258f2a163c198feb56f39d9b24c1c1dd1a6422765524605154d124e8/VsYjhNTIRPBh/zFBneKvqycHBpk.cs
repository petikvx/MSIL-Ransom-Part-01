using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace VsYjhNTIRPBh;

public static class zFBneKvqycHBpk
{
	public struct AdAkrSERecC
	{
		public string QSjSHhrsktbTXl;

		public string nEwjWzsqNrPLWMhX;
	}

	[CompilerGenerated]
	private sealed class BwwrBoAUjEnEh
	{
		public string oYETQyrHHTZDuglH;

		public bool _003CgetMacByIp_003Eb__0(AdAkrSERecC x)
		{
			return x.nEwjWzsqNrPLWMhX == oYETQyrHHTZDuglH;
		}
	}

	public static void kYmOWMVDdqCT(string bnysJzjyuUfX, string BjUZswbFtYxLKOD, string dNEJIJZooPDLwc)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		for (int i = 0; i <= 5; i++)
		{
			array[i] = byte.MaxValue;
		}
		string[] array2 = null;
		array2 = ((!bnysJzjyuUfX.Contains("-")) ? bnysJzjyuUfX.Split(new char[1] { ':' }) : bnysJzjyuUfX.Split(new char[1] { '-' }));
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
		IPAddress cOnVgLCLKJyy = IPAddress.Parse(BjUZswbFtYxLKOD);
		IPAddress kxynzYlhaOXk = IPAddress.Parse(dNEJIJZooPDLwc);
		IPAddress broadcastAddress = cOnVgLCLKJyy.GetBroadcastAddress(kxynzYlhaOXk);
		udpClient.Send(array, array.Length, broadcastAddress.ToString(), 3);
	}

	public static IPAddress GetBroadcastAddress(this IPAddress cOnVgLCLKJyy, IPAddress KxynzYlhaOXk)
	{
		byte[] addressBytes = cOnVgLCLKJyy.GetAddressBytes();
		byte[] addressBytes2 = KxynzYlhaOXk.GetAddressBytes();
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

	public static string aTSHvKpYZSvEvY(string xUaTIkEHAS)
	{
		List<AdAkrSERecC> list = wYPbkjkYof();
		int num = list.FindIndex((AdAkrSERecC x) => x.nEwjWzsqNrPLWMhX == xUaTIkEHAS);
		if (num >= 0)
		{
			return list[num].QSjSHhrsktbTXl.ToUpper();
		}
		return null;
	}

	public static List<AdAkrSERecC> wYPbkjkYof()
	{
		List<AdAkrSERecC> list = new List<AdAkrSERecC>();
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
			list.Add(new AdAkrSERecC
			{
				QSjSHhrsktbTXl = item.Groups["mac"].Value,
				nEwjWzsqNrPLWMhX = item.Groups["ip"].Value
			});
		}
		return list;
	}
}
