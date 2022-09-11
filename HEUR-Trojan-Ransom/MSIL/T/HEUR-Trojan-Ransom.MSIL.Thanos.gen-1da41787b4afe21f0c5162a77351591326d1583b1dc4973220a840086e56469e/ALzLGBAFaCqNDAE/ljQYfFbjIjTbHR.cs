using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace ALzLGBAFaCqNDAE;

public static class ljQYfFbjIjTbHR
{
	public struct UYxNuwnXSWhKy
	{
		public string QpayIVWAHzo;

		public string BrcetuPMKWK;
	}

	[CompilerGenerated]
	private sealed class kkzyIKkuneBSzIZs
	{
		public string PMAIOUOsmvKn;

		public bool _003CgetMacByIp_003Eb__0(UYxNuwnXSWhKy x)
		{
			return x.BrcetuPMKWK == PMAIOUOsmvKn;
		}
	}

	public static void jjWOuFUGHOxtaU(string suypxhOYcdr, string CmoZZzdtWxBZNaM, string keHyZlhYVvtYWFP)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		for (int i = 0; i <= 5; i++)
		{
			array[i] = byte.MaxValue;
		}
		string[] array2 = null;
		array2 = ((!suypxhOYcdr.Contains("-")) ? suypxhOYcdr.Split(new char[1] { ':' }) : suypxhOYcdr.Split(new char[1] { '-' }));
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
		IPAddress tDAvXTLNbunOPsed = IPAddress.Parse(CmoZZzdtWxBZNaM);
		IPAddress bCfoejispmyea = IPAddress.Parse(keHyZlhYVvtYWFP);
		IPAddress broadcastAddress = tDAvXTLNbunOPsed.GetBroadcastAddress(bCfoejispmyea);
		udpClient.Send(array, array.Length, broadcastAddress.ToString(), 3);
	}

	public static IPAddress GetBroadcastAddress(this IPAddress TDAvXTLNbunOPsed, IPAddress bCfoejispmyea)
	{
		byte[] addressBytes = TDAvXTLNbunOPsed.GetAddressBytes();
		byte[] addressBytes2 = bCfoejispmyea.GetAddressBytes();
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

	public static string NdoqLwnGqeK(string ZDcSlGDQskQ)
	{
		List<UYxNuwnXSWhKy> list = wjwogUmmTNgF();
		int num = list.FindIndex((UYxNuwnXSWhKy x) => x.BrcetuPMKWK == ZDcSlGDQskQ);
		if (num >= 0)
		{
			return list[num].QpayIVWAHzo.ToUpper();
		}
		return null;
	}

	public static List<UYxNuwnXSWhKy> wjwogUmmTNgF()
	{
		List<UYxNuwnXSWhKy> list = new List<UYxNuwnXSWhKy>();
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
			list.Add(new UYxNuwnXSWhKy
			{
				QpayIVWAHzo = item.Groups["mac"].Value,
				BrcetuPMKWK = item.Groups["ip"].Value
			});
		}
		return list;
	}
}
