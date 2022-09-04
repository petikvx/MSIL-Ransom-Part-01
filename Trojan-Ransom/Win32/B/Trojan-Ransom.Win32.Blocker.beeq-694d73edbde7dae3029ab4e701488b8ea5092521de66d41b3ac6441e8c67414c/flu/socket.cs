using System.Collections.Generic;
using System.Linq;
using Starksoft.Net.Proxy;

namespace flu;

public class socket
{
	internal static consocket.Tor Tor_obj;

	internal static List<consocket.proxy> proxy_socks;

	public socket()
	{
		if (Tor_obj == null || proxy_socks == null)
		{
			if (Tor_obj == null)
			{
				Tor_obj = consocket.Tor.Instance;
				Tor_obj.tor_start();
			}
			if (proxy_socks == null)
			{
				proxy_socks = new List<consocket.proxy>();
			}
		}
	}

	public int add(string type, string host, int port)
	{
		int result = -1;
		if (type == "proxy")
		{
			proxy_socks.Add(new consocket.proxy(host, port, "127.0.0.1", 9050, (ProxyType)3));
			result = proxy_socks.Count() - 1;
			proxy_socks[result].connect();
			return result;
		}
		return result;
	}
}
