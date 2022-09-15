using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace anti_vzlom_popki;

internal class Detect
{
	private static void Closeprogram()
	{
		try
		{
			string location = Assembly.GetExecutingAssembly().Location;
			Process.Start(new ProcessStartInfo("cmd.exe", "/C ping 1.1.1.1 -n 1 -w 3000 > Nul & Del \"" + location + "\"")
			{
				WindowStyle = ProcessWindowStyle.Hidden
			})!.Dispose();
			Environment.Exit(0);
		}
		catch
		{
		}
	}

	public static void check()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Process[] processesByName = Process.GetProcessesByName("Fiddler");
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Programs\\Fiddler\\App.ico"))
			{
				MessageBox.Show("Runtime Error at 69464569456945694e2432");
				Closeprogram();
			}
			else if (processesByName.Length != 0)
			{
				MessageBox.Show("Runtime Error at 69464569456945694e2432");
				Closeprogram();
			}
			if (File.Exists("C:\\Program Files (x86)\\HTTPDebuggerPro\\HTTPDebuggerBrowser.dll"))
			{
				MessageBox.Show("Runtime Error at 69464569456945694e2432");
				Closeprogram();
			}
			if (Directory.Exists("C:\\Program Files (x86)\\IEInspector\\HTTPAnalyzerStdV7"))
			{
				MessageBox.Show("Runtime Error at 69464569456945694e2432");
				Closeprogram();
			}
			try
			{
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					if (process.ProcessName.ToLower().Contains("fiddler") | process.ProcessName.ToLower().Contains("wireshark") | process.ProcessName.ToLower().Contains("charles") | process.ProcessName.ToLower().Contains("dnSpy") | process.ProcessName.ToLower().Contains("Hacker") | process.ProcessName.ToLower().Contains("ollydbg") | process.MainWindowTitle.ToLower().Contains("fiddler") | process.MainWindowTitle.ToLower().Contains("dnSpy") | process.MainWindowTitle.ToLower().Contains("wireshark") | process.MainWindowTitle.ToLower().Contains("charles") | process.MainWindowTitle.ToLower().Contains("SoftPerfect") | process.MainWindowTitle.ToLower().Contains("ollydbg") | process.MainWindowTitle.ToLower().Contains("Hacker"))
					{
						MessageBox.Show("Runtime Error at 69464569456945694e2432");
						Closeprogram();
					}
					if (process.ProcessName.ToLower() == "snpa")
					{
						MessageBox.Show("Runtime Error at 69464569456945694e2432");
						Closeprogram();
					}
					if (process.ProcessName.ToLower() == "dumcap")
					{
						MessageBox.Show("Runtime Error at 69464569456945694e2432");
						Closeprogram();
					}
					try
					{
						string[] array = new StringBuilder(1024).ToString(0, 1024).Split(new char[1] { Convert.ToChar("\\") });
						string text = "";
						for (int j = 0; j < array.Length - 1; j++)
						{
							text = text + array[j] + "\\";
						}
						if (File.Exists(text + "main.lua"))
						{
							MessageBox.Show("Runtime Error at 69464569456945694e2432");
							Closeprogram();
						}
						if (File.Exists(text + "chartdir50.dll"))
						{
							MessageBox.Show("Runtime Error at 69464569456945694e2432");
							Closeprogram();
						}
						if (File.Exists(text + "lua52.dll"))
						{
							MessageBox.Show("Runtime Error at 69464569456945694e2432");
							Closeprogram();
						}
						if (File.Exists(text + "ollydbg.ini"))
						{
							MessageBox.Show("Runtime Error at 69464569456945694e2432");
							Closeprogram();
						}
						if (File.Exists(text + "lua5.1-32.dll"))
						{
							MessageBox.Show("Runtime Error at 69464569456945694e2432");
							Closeprogram();
						}
						if (File.Exists(text + "lua5.1-64.dll"))
						{
							MessageBox.Show("Runtime Error at 69464569456945694e2432");
							Closeprogram();
						}
					}
					catch (Exception)
					{
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
	}
}
