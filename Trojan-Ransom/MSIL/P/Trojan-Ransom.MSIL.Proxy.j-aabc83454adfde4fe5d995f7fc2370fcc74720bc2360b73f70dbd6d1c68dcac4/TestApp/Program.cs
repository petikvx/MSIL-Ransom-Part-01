using System;
using ProxyService;

namespace TestApp;

internal class Program
{
	private static void Main(string[] args)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		try
		{
			ProxyServer.Server = new ProxyServer("127.0.0.1", 8083);
			ProxyServer.Server.Start();
		}
		catch (Exception)
		{
		}
	}
}
