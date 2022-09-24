using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace PbjBzLsVOvNrzQ;

public static class yPqGNCHRyu
{
	public struct RPeTfpUVPFs
	{
		public string IHRGfEidvq;

		public string ZyfUaxlVwSgRl;
	}

	[CompilerGenerated]
	private sealed class CWilYstvrK
	{
		public string egQRWhbFxpXdB;

		public bool _003CgetMacByIp_003Eb__0(RPeTfpUVPFs x)
		{
			return x.ZyfUaxlVwSgRl == egQRWhbFxpXdB;
		}
	}

	public static void uEJodmVTcBURWJA(string HFoVmrXTILm, string PKXbnAtWspEJiZ, string KgkxiyyHSPWsA)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		for (int i = 0; i <= 5; i++)
		{
			array[i] = byte.MaxValue;
		}
		string[] array2 = null;
		array2 = ((!HFoVmrXTILm.Contains("-")) ? HFoVmrXTILm.Split(new char[1] { ':' }) : HFoVmrXTILm.Split(new char[1] { '-' }));
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
		IPAddress gKaKlrtubvM = IPAddress.Parse(PKXbnAtWspEJiZ);
		IPAddress cpizVBorFBGFNTd = IPAddress.Parse(KgkxiyyHSPWsA);
		IPAddress broadcastAddress = gKaKlrtubvM.GetBroadcastAddress(cpizVBorFBGFNTd);
		udpClient.Send(array, array.Length, broadcastAddress.ToString(), 3);
	}

	public static IPAddress GetBroadcastAddress(this IPAddress GKaKlrtubvM, IPAddress cpizVBorFBGFNTd)
	{
		byte[] addressBytes = GKaKlrtubvM.GetAddressBytes();
		byte[] addressBytes2 = cpizVBorFBGFNTd.GetAddressBytes();
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

	public static string iPWsvbAWFoo(string APyYDdZZXTbE)
	{
		List<RPeTfpUVPFs> list = vKrIoPvNlnjnK();
		int num = list.FindIndex((RPeTfpUVPFs x) => x.ZyfUaxlVwSgRl == APyYDdZZXTbE);
		if (num >= 0)
		{
			return list[num].IHRGfEidvq.ToUpper();
		}
		return null;
	}

	public static List<RPeTfpUVPFs> vKrIoPvNlnjnK()
	{
		List<RPeTfpUVPFs> list = new List<RPeTfpUVPFs>();
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
			list.Add(new RPeTfpUVPFs
			{
				IHRGfEidvq = item.Groups["mac"].Value,
				ZyfUaxlVwSgRl = item.Groups["ip"].Value
			});
		}
		return list;
	}
}
