using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace dfbDZtGQEYGzK;

public static class TwSubFeqdyvmM
{
	public struct VDtlgtMWiiKLwf
	{
		public string RraimdkPkTJHV;

		public string rBFAdwGxve;
	}

	[CompilerGenerated]
	private sealed class tuJdOiUbDQ
	{
		public string iWhtVQxqRaT;

		public bool _003CgetMacByIp_003Eb__0(VDtlgtMWiiKLwf x)
		{
			return x.rBFAdwGxve == iWhtVQxqRaT;
		}
	}

	public static void wcYWJQOWNvEgIOz(string ozryxvHxTRzif, string nXRAFAYZlTPt, string JdWKetDUxivOWvO)
	{
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		for (int i = 0; i <= 5; i++)
		{
			array[i] = byte.MaxValue;
		}
		string[] array2 = null;
		array2 = ((!ozryxvHxTRzif.Contains("-")) ? ozryxvHxTRzif.Split(new char[1] { ':' }) : ozryxvHxTRzif.Split(new char[1] { '-' }));
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
		IPAddress mNLSbRaEdxYaL = IPAddress.Parse(nXRAFAYZlTPt);
		IPAddress rcdvPuIvwxAi = IPAddress.Parse(JdWKetDUxivOWvO);
		IPAddress broadcastAddress = mNLSbRaEdxYaL.GetBroadcastAddress(rcdvPuIvwxAi);
		udpClient.Send(array, array.Length, broadcastAddress.ToString(), 3);
	}

	public static IPAddress GetBroadcastAddress(this IPAddress MNLSbRaEdxYaL, IPAddress rcdvPuIvwxAi)
	{
		byte[] addressBytes = MNLSbRaEdxYaL.GetAddressBytes();
		byte[] addressBytes2 = rcdvPuIvwxAi.GetAddressBytes();
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

	public static string gUUXAnPKSZaU(string obrYnSqoNqIEOy)
	{
		List<VDtlgtMWiiKLwf> list = mxJtpEKzNJXHaHXtj();
		int num = list.FindIndex((VDtlgtMWiiKLwf x) => x.rBFAdwGxve == obrYnSqoNqIEOy);
		if (num >= 0)
		{
			return list[num].RraimdkPkTJHV.ToUpper();
		}
		return null;
	}

	public static List<VDtlgtMWiiKLwf> mxJtpEKzNJXHaHXtj()
	{
		List<VDtlgtMWiiKLwf> list = new List<VDtlgtMWiiKLwf>();
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
			list.Add(new VDtlgtMWiiKLwf
			{
				RraimdkPkTJHV = item.Groups["mac"].Value,
				rBFAdwGxve = item.Groups["ip"].Value
			});
		}
		return list;
	}
}
