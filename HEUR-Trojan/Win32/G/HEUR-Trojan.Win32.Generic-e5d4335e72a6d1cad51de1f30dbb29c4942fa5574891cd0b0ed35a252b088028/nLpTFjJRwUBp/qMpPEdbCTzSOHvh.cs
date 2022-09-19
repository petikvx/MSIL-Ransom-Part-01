using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace nLpTFjJRwUBp;

public static class qMpPEdbCTzSOHvh
{
	public struct FsjbrggBGCa
	{
		public string wemDKlFlXxN;

		public string hKDPXcZmcLth;
	}

	[CompilerGenerated]
	private sealed class PaFsROlUaGQo
	{
		public string eZIHVZaSujJmOP;

		public bool _003CgetMacByIp_003Eb__0(FsjbrggBGCa x)
		{
			return x.hKDPXcZmcLth == eZIHVZaSujJmOP;
		}
	}

	public static void TJrlhRLmgvmREvbHh(string tqddNuuJAytai, string XAwGglCcvikn, string aRvAWvjkXZO)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		for (int i = 0; i <= 5; i++)
		{
			array[i] = byte.MaxValue;
		}
		string[] array2 = null;
		array2 = ((!tqddNuuJAytai.Contains("-")) ? tqddNuuJAytai.Split(new char[1] { ':' }) : tqddNuuJAytai.Split(new char[1] { '-' }));
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
		IPAddress pGqlpMNGOyCk = IPAddress.Parse(XAwGglCcvikn);
		IPAddress hbYpKGUstOfi = IPAddress.Parse(aRvAWvjkXZO);
		IPAddress broadcastAddress = pGqlpMNGOyCk.GetBroadcastAddress(hbYpKGUstOfi);
		udpClient.Send(array, array.Length, broadcastAddress.ToString(), 3);
	}

	public static IPAddress GetBroadcastAddress(this IPAddress PGqlpMNGOyCk, IPAddress HbYpKGUstOfi)
	{
		byte[] addressBytes = PGqlpMNGOyCk.GetAddressBytes();
		byte[] addressBytes2 = HbYpKGUstOfi.GetAddressBytes();
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

	public static string sRDQOVuLKks(string XJPrHneppMngIQ)
	{
		List<FsjbrggBGCa> list = JbSUBLGRapq();
		int num = list.FindIndex((FsjbrggBGCa x) => x.hKDPXcZmcLth == XJPrHneppMngIQ);
		if (num >= 0)
		{
			return list[num].wemDKlFlXxN.ToUpper();
		}
		return null;
	}

	public static List<FsjbrggBGCa> JbSUBLGRapq()
	{
		List<FsjbrggBGCa> list = new List<FsjbrggBGCa>();
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
			list.Add(new FsjbrggBGCa
			{
				wemDKlFlXxN = item.Groups["mac"].Value,
				hKDPXcZmcLth = item.Groups["ip"].Value
			});
		}
		return list;
	}
}
