using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;

namespace ALzLGBAFaCqNDAE;

public class JXHzPBkJtqLy
{
	public static List<string> CCYmVaYiuTo(string JkitlStquTdfRmG)
	{
		List<string> list = new List<string>();
		for (int i = 1; i < 255; i++)
		{
			string text = "." + i;
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(JkitlStquTdfRmG + text, 900);
			if (pingReply.Status == IPStatus.Success)
			{
				try
				{
					IPAddress address = IPAddress.Parse(JkitlStquTdfRmG + text);
					Dns.GetHostEntry(address);
					list.Add(JkitlStquTdfRmG + text);
				}
				catch
				{
				}
			}
		}
		return list;
	}
}
