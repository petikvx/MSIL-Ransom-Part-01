using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace YXHSMjloYIX;

public class RSeBInhhLrmQeX
{
	public static List<string> hCeRbIUAFSJtMD(string aMTxNihvTaqi)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = "." + i;
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(aMTxNihvTaqi + text, 900);
			if (pingReply.Status == IPStatus.Success)
			{
				try
				{
					IPAddress address = IPAddress.Parse(aMTxNihvTaqi + text);
					Dns.GetHostEntry(address);
					list.Add(aMTxNihvTaqi + text);
				}
				catch
				{
				}
			}
		}
		return list;
	}
}
