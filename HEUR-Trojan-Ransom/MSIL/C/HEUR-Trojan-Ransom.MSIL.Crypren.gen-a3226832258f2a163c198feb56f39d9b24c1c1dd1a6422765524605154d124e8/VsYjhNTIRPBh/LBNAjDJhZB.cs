using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace VsYjhNTIRPBh;

public class LBNAjDJhZB
{
	public static List<string> jPYjUDwcSzUMMwgM(string qcKKwEqBRJHeCYG)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = "." + i;
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(qcKKwEqBRJHeCYG + text, 900);
			if (pingReply.Status == IPStatus.Success)
			{
				try
				{
					IPAddress address = IPAddress.Parse(qcKKwEqBRJHeCYG + text);
					Dns.GetHostEntry(address);
					list.Add(qcKKwEqBRJHeCYG + text);
				}
				catch
				{
				}
			}
		}
		return list;
	}
}
