using System.Collections.Generic;
using System.Linq;
using System.Text;
using xClient.Core.Data;

namespace xClient.Core.Helper;

public static class HostHelper
{
	public static List<Host> GetHostsList(string rawHosts)
	{
		List<Host> list = new List<Host>();
		if (string.IsNullOrEmpty(rawHosts))
		{
			return list;
		}
		string[] array = rawHosts.Split(new char[1] { ';' });
		foreach (string text in array)
		{
			if (!string.IsNullOrEmpty(text) && Enumerable.Contains(text, ':') && ushort.TryParse(text.Substring(text.LastIndexOf(':') + 1), out var result))
			{
				list.Add(new Host
				{
					Hostname = text.Substring(0, text.LastIndexOf(':')),
					Port = result
				});
			}
		}
		return list;
	}

	public static string GetRawHosts(List<Host> hosts)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (Host host in hosts)
		{
			stringBuilder.Append(string.Concat(host, ";"));
		}
		return stringBuilder.ToString();
	}
}
