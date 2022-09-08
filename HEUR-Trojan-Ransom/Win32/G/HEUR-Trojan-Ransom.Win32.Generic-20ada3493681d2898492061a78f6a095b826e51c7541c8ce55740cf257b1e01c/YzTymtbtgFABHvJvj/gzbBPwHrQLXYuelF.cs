using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace YzTymtbtgFABHvJvj;

public class gzbBPwHrQLXYuelF
{
	public static List<string> YpSqrhUhBTlMXIwF(string kEwfGyOqbsFgEXm)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = "." + i;
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(kEwfGyOqbsFgEXm + text, 900);
			if (pingReply.Status == IPStatus.Success)
			{
				try
				{
					IPAddress address = IPAddress.Parse(kEwfGyOqbsFgEXm + text);
					Dns.GetHostEntry(address);
					list.Add(kEwfGyOqbsFgEXm + text);
				}
				catch
				{
				}
			}
		}
		return list;
	}
}
