using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace YXHSMjloYIX;

public static class FppEWzVjmWxh
{
	public struct xVKlFwpAUpWl
	{
		public string megHiFHSQWS;

		public string IeMIXMwzuEbNk;
	}

	[CompilerGenerated]
	private sealed class ZsJaVwOkkqCd
	{
		public string mRacnmqPRow;

		public bool _003CgetMacByIp_003Eb__0(xVKlFwpAUpWl x)
		{
			return x.IeMIXMwzuEbNk == mRacnmqPRow;
		}
	}

	public static void jnjjkGSILXWbE(string FsJZsiItGBlBvW, string juXXhmHcFYLpY, string XVnqggmmEBnKoXOW)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		for (int i = 0; i <= 5; i++)
		{
			array[i] = byte.MaxValue;
		}
		string[] array2 = null;
		array2 = ((!FsJZsiItGBlBvW.Contains("-")) ? FsJZsiItGBlBvW.Split(new char[1] { ':' }) : FsJZsiItGBlBvW.Split(new char[1] { '-' }));
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
		IPAddress avRgWPmdpumkd = IPAddress.Parse(juXXhmHcFYLpY);
		IPAddress odQVaybGvaHUN = IPAddress.Parse(XVnqggmmEBnKoXOW);
		IPAddress broadcastAddress = avRgWPmdpumkd.GetBroadcastAddress(odQVaybGvaHUN);
		udpClient.Send(array, array.Length, broadcastAddress.ToString(), 3);
	}

	public static IPAddress GetBroadcastAddress(this IPAddress AvRgWPmdpumkd, IPAddress OdQVaybGvaHUN)
	{
		byte[] addressBytes = AvRgWPmdpumkd.GetAddressBytes();
		byte[] addressBytes2 = OdQVaybGvaHUN.GetAddressBytes();
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

	public static string kOubFvQjhIqnA(string FxSjQmOeUNyUz)
	{
		List<xVKlFwpAUpWl> list = UJXDUWrNQyPAVk();
		int num = list.FindIndex((xVKlFwpAUpWl x) => x.IeMIXMwzuEbNk == FxSjQmOeUNyUz);
		if (num >= 0)
		{
			return list[num].megHiFHSQWS.ToUpper();
		}
		return null;
	}

	public static List<xVKlFwpAUpWl> UJXDUWrNQyPAVk()
	{
		List<xVKlFwpAUpWl> list = new List<xVKlFwpAUpWl>();
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
			list.Add(new xVKlFwpAUpWl
			{
				megHiFHSQWS = item.Groups["mac"].Value,
				IeMIXMwzuEbNk = item.Groups["ip"].Value
			});
		}
		return list;
	}
}
