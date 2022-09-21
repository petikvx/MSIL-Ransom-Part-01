using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace vQzMGKHeycFziMq;

public static class fxPtfJOjYtkx
{
	public struct rjbQMeiBTYGgDcl
	{
		public string XmvvfDyeQCt;

		public string mKZPQnnJzcPXMn;
	}

	[CompilerGenerated]
	private sealed class eMvbBmhwhJoTAxBE
	{
		public string lBuKciWArtM;

		public bool _003CgetMacByIp_003Eb__0(rjbQMeiBTYGgDcl x)
		{
			return x.mKZPQnnJzcPXMn == lBuKciWArtM;
		}
	}

	public static void hsyUNnDlbwg(string WIRVtYRTXOYREHd, string eqHhpVHlMmtv, string KSqypdiSiPnD)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		for (int i = 0; i <= 5; i++)
		{
			array[i] = byte.MaxValue;
		}
		string[] array2 = null;
		array2 = ((!WIRVtYRTXOYREHd.Contains("-")) ? WIRVtYRTXOYREHd.Split(new char[1] { ':' }) : WIRVtYRTXOYREHd.Split(new char[1] { '-' }));
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
		IPAddress hFZSwOaMIRstRok = IPAddress.Parse(eqHhpVHlMmtv);
		IPAddress eXqWiRJqgKi = IPAddress.Parse(KSqypdiSiPnD);
		IPAddress broadcastAddress = hFZSwOaMIRstRok.GetBroadcastAddress(eXqWiRJqgKi);
		udpClient.Send(array, array.Length, broadcastAddress.ToString(), 3);
	}

	public static IPAddress GetBroadcastAddress(this IPAddress HFZSwOaMIRstRok, IPAddress eXqWiRJqgKi)
	{
		byte[] addressBytes = HFZSwOaMIRstRok.GetAddressBytes();
		byte[] addressBytes2 = eXqWiRJqgKi.GetAddressBytes();
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

	public static string SVIfOCeMnkUS(string RZmCmszlEhvUS)
	{
		List<rjbQMeiBTYGgDcl> list = HvffBXvDoZfW();
		int num = list.FindIndex((rjbQMeiBTYGgDcl x) => x.mKZPQnnJzcPXMn == RZmCmszlEhvUS);
		if (num >= 0)
		{
			return list[num].XmvvfDyeQCt.ToUpper();
		}
		return null;
	}

	public static List<rjbQMeiBTYGgDcl> HvffBXvDoZfW()
	{
		List<rjbQMeiBTYGgDcl> list = new List<rjbQMeiBTYGgDcl>();
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
			list.Add(new rjbQMeiBTYGgDcl
			{
				XmvvfDyeQCt = item.Groups["mac"].Value,
				mKZPQnnJzcPXMn = item.Groups["ip"].Value
			});
		}
		return list;
	}
}
