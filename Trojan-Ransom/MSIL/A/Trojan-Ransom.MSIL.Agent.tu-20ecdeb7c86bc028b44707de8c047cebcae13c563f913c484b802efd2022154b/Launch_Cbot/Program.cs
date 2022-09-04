using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Launch_Cbot;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		bool flag = File.Exists("control.dll");
		bool flag2 = File.Exists("image.dll");
		bool flag3 = File.Exists("HtmlAgilityPack.dll");
		bool flag4 = File.Exists("MySql.Data.dll");
		if (flag && flag2 && flag3 && flag4)
		{
			if (Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Application.get_ExecutablePath())).Length > 1)
			{
				MessageBox.Show("Program zaten çalışıyor.");
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new LaunchCbot());
		}
		else
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new LaunchCbot());
		}
	}
}
