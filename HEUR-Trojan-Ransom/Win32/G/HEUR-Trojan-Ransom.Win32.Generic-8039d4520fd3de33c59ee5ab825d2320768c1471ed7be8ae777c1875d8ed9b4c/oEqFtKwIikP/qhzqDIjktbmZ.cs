using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace oEqFtKwIikP;

public class qhzqDIjktbmZ
{
	public static List<string> zhMoouJhWKesQFE(string cHIYCyhVHYS)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = "." + i;
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(cHIYCyhVHYS + text, 900);
			if (pingReply.Status == IPStatus.Success)
			{
				try
				{
					IPAddress address = IPAddress.Parse(cHIYCyhVHYS + text);
					Dns.GetHostEntry(address);
					list.Add(cHIYCyhVHYS + text);
				}
				catch
				{
				}
			}
		}
		return list;
	}
}
