using System;
using System.Windows.Forms;
using ProxyService;

namespace TestApp;

internal class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		try
		{
			ProxyServer.Server = new ProxyServer("127.0.0.1", 8083);
			ProxyServer.Server.Start();
		}
		catch (Exception)
		{
		}
		Application.Run();
	}
}
