using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using SmartAssembly.SmartUsageWithoutUI;

namespace SmartAssembly.SmartUsageCore;

internal static class PlatformUsageCounter
{
	public static void CountPlatformUsages()
	{
		try
		{
			if (DotNetVersionInstalled("v4"))
			{
				ReportUsage("Platform: .NET 4.0 installed");
			}
			else if (DotNetVersionInstalled("v3.5"))
			{
				ReportUsage("Platform: .NET 3.5 installed");
			}
			else if (DotNetVersionInstalled("v3.0"))
			{
				ReportUsage("Platform: .NET 3.0 installed");
			}
			else if (DotNetVersionInstalled("v2.0.50727"))
			{
				ReportUsage("Platform: .NET 2.0 installed");
			}
			else if (DotNetVersionInstalled("v1.1.4322"))
			{
				ReportUsage("Platform: .NET 1.1 installed");
			}
			switch (Environment.OSVersion.Version.Major)
			{
			case 5:
				switch (Environment.OSVersion.Version.Minor)
				{
				case 0:
					ReportUsage("Platform: Windows 2000");
					break;
				case 1:
					ReportUsage("Platform: Windows XP");
					break;
				case 2:
					ReportUsage("Platform: Windows 2003");
					break;
				}
				break;
			case 6:
				switch (Environment.OSVersion.Version.Minor)
				{
				case 0:
					ReportUsage("Platform: Windows Vista/2008");
					break;
				case 1:
					ReportUsage("Platform: Windows 7/2008 R2");
					break;
				}
				break;
			}
			ReportNumberOfCpuCores();
			ReportCultureName();
			ReportOSBitness();
		}
		catch
		{
		}
	}

	public static void ReportNumberOfCpuCores()
	{
		try
		{
			ReportUsage("Platform CPU Cores: " + Environment.ProcessorCount);
		}
		catch
		{
		}
	}

	public static void ReportCultureName()
	{
		try
		{
			ReportUsage("Platform Culture Name: " + CultureInfo.CurrentCulture.Name);
		}
		catch
		{
		}
	}

	public static void ReportOSBitness()
	{
		try
		{
			ReportUsage("Platform OS Bitness: " + (Is64BitOperatingSystem() ? 64 : 32));
		}
		catch
		{
		}
	}

	private static bool Is64BitOperatingSystem()
	{
		if (IntPtr.Size == 8)
		{
			return true;
		}
		if (DoesWin32MethodExist("kernel32.dll", "IsWow64Process") && IsWow64Process(GetCurrentProcess(), out var wow64Process))
		{
			return wow64Process;
		}
		return false;
	}

	private static bool DoesWin32MethodExist(string moduleName, string methodName)
	{
		IntPtr moduleHandle = GetModuleHandle(moduleName);
		if (moduleHandle == IntPtr.Zero)
		{
			return false;
		}
		return GetProcAddress(moduleHandle, methodName) != IntPtr.Zero;
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string moduleName);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hModule, [MarshalAs(UnmanagedType.LPStr)] string procName);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWow64Process(IntPtr hProcess, out bool wow64Process);

	private static bool DotNetVersionInstalled(string versionKey)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\" + versionKey);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\NET Framework Setup\\NDP\\" + versionKey);
			}
			return registryKey != null;
		}
		finally
		{
			registryKey?.Close();
		}
	}

	[ReportUsage]
	public static void ReportUsage([FeatureName][DoNotPrune] string featureName)
	{
		UsageReporterWithoutUI.DynamicFeatureUsed(featureName);
	}
}
