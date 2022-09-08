using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace YzTymtbtgFABHvJvj;

public static class MdSuPZXxpOdiuN
{
	public struct eocSalSvyOHITNq
	{
		public string kFBgRYNHzKNN;

		public string AOaeymVsCs;
	}

	[CompilerGenerated]
	private sealed class WQGgpyYYYriuvcWH
	{
		public string zTURyzlPodn;

		public bool _003CgetMacByIp_003Eb__0(eocSalSvyOHITNq x)
		{
			return x.AOaeymVsCs == zTURyzlPodn;
		}
	}

	public static void pTOrrKUqMAsEjRV(string CxzBXdTYGSUVf, string JjkhQohPaJepc, string RSdYxHmVxntnvpyE)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		for (int i = 0; i <= 5; i++)
		{
			array[i] = byte.MaxValue;
		}
		string[] array2 = null;
		array2 = ((!CxzBXdTYGSUVf.Contains("-")) ? CxzBXdTYGSUVf.Split(new char[1] { ':' }) : CxzBXdTYGSUVf.Split(new char[1] { '-' }));
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
		IPAddress jgfcCdtPYiFU = IPAddress.Parse(JjkhQohPaJepc);
		IPAddress eeqwFWjADIhyWL = IPAddress.Parse(RSdYxHmVxntnvpyE);
		IPAddress broadcastAddress = jgfcCdtPYiFU.GetBroadcastAddress(eeqwFWjADIhyWL);
		udpClient.Send(array, array.Length, broadcastAddress.ToString(), 3);
	}

	public static IPAddress GetBroadcastAddress(this IPAddress jgfcCdtPYiFU, IPAddress EeqwFWjADIhyWL)
	{
		byte[] addressBytes = jgfcCdtPYiFU.GetAddressBytes();
		byte[] addressBytes2 = EeqwFWjADIhyWL.GetAddressBytes();
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

	public static string zyHuDEDinIX(string MPPcXWyEbPf)
	{
		List<eocSalSvyOHITNq> list = RNrsfwomJcRV();
		int num = list.FindIndex((eocSalSvyOHITNq x) => x.AOaeymVsCs == MPPcXWyEbPf);
		if (num >= 0)
		{
			return list[num].kFBgRYNHzKNN.ToUpper();
		}
		return null;
	}

	public static List<eocSalSvyOHITNq> RNrsfwomJcRV()
	{
		List<eocSalSvyOHITNq> list = new List<eocSalSvyOHITNq>();
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
			list.Add(new eocSalSvyOHITNq
			{
				kFBgRYNHzKNN = item.Groups["mac"].Value,
				AOaeymVsCs = item.Groups["ip"].Value
			});
		}
		return list;
	}
}
