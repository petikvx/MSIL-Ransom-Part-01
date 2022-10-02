using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace LSMgrTguKYchoUzfqQ;

public static class GpDBcWTrqaBjnPZ
{
	public struct wpSzNRTIrsQF
	{
		public string uNpEwHZTbF;

		public string rXvlcNcJAxnK;
	}

	[CompilerGenerated]
	private sealed class ETRjtAiKwVQpBK
	{
		public string qXIpTKVKPdXYKS;

		public bool _003CgetMacByIp_003Eb__0(wpSzNRTIrsQF x)
		{
			return x.rXvlcNcJAxnK == qXIpTKVKPdXYKS;
		}
	}

	public static void UmrhBfydMCgSZaZ(string nAAbPFMlyDdoKXo, string XogBwggEXP, string iaytaKwUVJAoFf)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		for (int i = 0; i <= 5; i++)
		{
			array[i] = byte.MaxValue;
		}
		string[] array2 = null;
		array2 = ((!nAAbPFMlyDdoKXo.Contains("-")) ? nAAbPFMlyDdoKXo.Split(new char[1] { ':' }) : nAAbPFMlyDdoKXo.Split(new char[1] { '-' }));
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
		IPAddress mnfBgmHPAICbVb = IPAddress.Parse(XogBwggEXP);
		IPAddress dImGbuLXgZE = IPAddress.Parse(iaytaKwUVJAoFf);
		IPAddress broadcastAddress = mnfBgmHPAICbVb.GetBroadcastAddress(dImGbuLXgZE);
		udpClient.Send(array, array.Length, broadcastAddress.ToString(), 3);
	}

	public static IPAddress GetBroadcastAddress(this IPAddress MnfBgmHPAICbVb, IPAddress DImGbuLXgZE)
	{
		byte[] addressBytes = MnfBgmHPAICbVb.GetAddressBytes();
		byte[] addressBytes2 = DImGbuLXgZE.GetAddressBytes();
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

	public static string YkUuhDNtYrns(string RORPTxaFad)
	{
		List<wpSzNRTIrsQF> list = CpgnioPrDv();
		int num = list.FindIndex((wpSzNRTIrsQF x) => x.rXvlcNcJAxnK == RORPTxaFad);
		if (num >= 0)
		{
			return list[num].uNpEwHZTbF.ToUpper();
		}
		return null;
	}

	public static List<wpSzNRTIrsQF> CpgnioPrDv()
	{
		List<wpSzNRTIrsQF> list = new List<wpSzNRTIrsQF>();
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
			list.Add(new wpSzNRTIrsQF
			{
				uNpEwHZTbF = item.Groups["mac"].Value,
				rXvlcNcJAxnK = item.Groups["ip"].Value
			});
		}
		return list;
	}
}
