using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class GClass44
{
	public static List<GClass55> smethod_0(string rawHosts)
	{
		List<GClass55> list = new List<GClass55>();
		if (string.IsNullOrEmpty(rawHosts))
		{
			return list;
		}
		string[] array = rawHosts.Split(new char[1] { ';' });
		foreach (string text in array)
		{
			if (!string.IsNullOrEmpty(text) && Enumerable.Contains(text, ':') && ushort.TryParse(text.Substring(text.LastIndexOf(':') + 1), out var result))
			{
				list.Add(new GClass55
				{
					Hostname = text.Substring(0, text.LastIndexOf(':')),
					Port = result
				});
			}
		}
		return list;
	}

	public static string smethod_1(List<GClass55> hosts)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (GClass55 host in hosts)
		{
			stringBuilder.Append(string.Concat(host, ";"));
		}
		return stringBuilder.ToString();
	}
}
