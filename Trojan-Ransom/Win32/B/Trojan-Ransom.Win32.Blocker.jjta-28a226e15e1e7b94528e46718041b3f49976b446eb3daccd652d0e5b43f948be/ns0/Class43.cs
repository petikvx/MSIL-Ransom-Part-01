using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using SmartAssembly.SmartUsageCore;
using ns2;
using ns9;

namespace ns0;

internal static class Class43
{
	public static void smethod_0()
	{
		try
		{
			if (smethod_6("v4"))
			{
				smethod_7("Platform: .NET 4.0 installed");
			}
			else if (smethod_6("v3.5"))
			{
				smethod_7("Platform: .NET 3.5 installed");
			}
			else if (smethod_6("v3.0"))
			{
				smethod_7("Platform: .NET 3.0 installed");
			}
			else if (smethod_6("v2.0.50727"))
			{
				smethod_7("Platform: .NET 2.0 installed");
			}
			else if (smethod_6("v1.1.4322"))
			{
				smethod_7("Platform: .NET 1.1 installed");
			}
			switch (Environment.OSVersion.Version.Major)
			{
			case 5:
				switch (Environment.OSVersion.Version.Minor)
				{
				case 0:
					smethod_7("Platform: Windows 2000");
					break;
				case 1:
					smethod_7("Platform: Windows XP");
					break;
				case 2:
					smethod_7("Platform: Windows 2003");
					break;
				}
				break;
			case 6:
				switch (Environment.OSVersion.Version.Minor)
				{
				case 0:
					smethod_7("Platform: Windows Vista/2008");
					break;
				case 1:
					smethod_7("Platform: Windows 7/2008 R2");
					break;
				}
				break;
			}
			smethod_1();
			smethod_2();
			smethod_3();
		}
		catch
		{
		}
	}

	public static void smethod_1()
	{
		try
		{
			smethod_7("Platform CPU Cores: " + Environment.ProcessorCount);
		}
		catch
		{
		}
	}

	public static void smethod_2()
	{
		try
		{
			smethod_7("Platform Culture Name: " + CultureInfo.CurrentCulture.Name);
		}
		catch
		{
		}
	}

	public static void smethod_3()
	{
		try
		{
			smethod_7("Platform OS Bitness: " + (smethod_4() ? 64 : 32));
		}
		catch
		{
		}
	}

	private static bool smethod_4()
	{
		if (IntPtr.Size == 8)
		{
			return true;
		}
		if (smethod_5("kernel32.dll", "IsWow64Process") && IsWow64Process(GetCurrentProcess(), out var wow64Process))
		{
			return wow64Process;
		}
		return false;
	}

	private static bool smethod_5(string string_0, string string_1)
	{
		IntPtr moduleHandle = GetModuleHandle(string_0);
		if (moduleHandle == IntPtr.Zero)
		{
			return false;
		}
		return GetProcAddress(moduleHandle, string_1) != IntPtr.Zero;
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hModule, [MarshalAs(UnmanagedType.LPStr)] string procName);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWow64Process(IntPtr hProcess, out bool wow64Process);

	private static bool smethod_6(string string_0)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\" + string_0);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\NET Framework Setup\\NDP\\" + string_0);
			}
			return registryKey != null;
		}
		finally
		{
			registryKey?.Close();
		}
	}

	public static void smethod_7([FeatureName][Attribute2] string featureName)
	{
		Class48.smethod_1(featureName);
	}
}
