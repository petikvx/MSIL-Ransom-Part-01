using System;
using System.Windows.Forms;
using ccats.Tools;

namespace ccats;

internal static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			Hacking.InitSoftware(Config.StartMode, (args.Length == 1) ? args[0] : null);
			new FormBackground();
			Application.Run();
		}
		catch
		{
		}
	}
}
