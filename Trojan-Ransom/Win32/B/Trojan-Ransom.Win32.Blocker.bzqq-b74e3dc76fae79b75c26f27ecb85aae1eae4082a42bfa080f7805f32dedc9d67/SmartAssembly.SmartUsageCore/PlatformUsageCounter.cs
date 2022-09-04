using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

internal static class PlatformUsageCounter
{
	public static void CountPlatformUsages()
	{
		int major = default(int);
		int minor2 = default(int);
		int minor = default(int);
		try
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
				major = Environment.OSVersion.Version.Major;
				switch (major)
				{
				case 5:
					minor2 = Environment.OSVersion.Version.Minor;
					switch (minor2)
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
					minor = Environment.OSVersion.Version.Minor;
					switch (minor)
					{
					case 0:
						ReportUsage("Platform: Windows Vista/2008");
						break;
					case 1:
						ReportUsage("Platform: Windows 7/2008 R2");
						break;
					case 2:
						ReportUsage("Platform: Windows 8");
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, major, minor2, minor);
			throw;
		}
	}

	public static void ReportNumberOfCpuCores()
	{
		try
		{
			try
			{
				ReportUsage("Platform CPU Cores: " + Environment.ProcessorCount);
			}
			catch
			{
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	public static void ReportCultureName()
	{
		try
		{
			try
			{
				ReportUsage("Platform Culture Name: " + CultureInfo.CurrentCulture.Name);
			}
			catch
			{
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	public static void ReportOSBitness()
	{
		try
		{
			try
			{
				ReportUsage("Platform OS Bitness: " + (Is64BitOperatingSystem() ? 64 : 32));
			}
			catch
			{
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	private static bool Is64BitOperatingSystem()
	{
		bool wow64Process = default(bool);
		try
		{
			if (IntPtr.Size == 8)
			{
				return true;
			}
			if (DoesWin32MethodExist("kernel32.dll", "IsWow64Process") && IsWow64Process(GetCurrentProcess(), out wow64Process))
			{
				return wow64Process;
			}
			return false;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, wow64Process);
			throw;
		}
	}

	private static bool DoesWin32MethodExist(string moduleName, string methodName)
	{
		IntPtr moduleHandle = default(IntPtr);
		try
		{
			moduleHandle = GetModuleHandle(moduleName);
			if (moduleHandle == IntPtr.Zero)
			{
				return false;
			}
			return GetProcAddress(moduleHandle, methodName) != IntPtr.Zero;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, moduleHandle, moduleName, methodName);
			throw;
		}
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
		RegistryKey registryKey = default(RegistryKey);
		bool flag = default(bool);
		try
		{
			registryKey = null;
			try
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\" + versionKey);
				if (registryKey == null)
				{
					registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\NET Framework Setup\\NDP\\" + versionKey);
				}
				flag = registryKey != null;
				return flag;
			}
			finally
			{
				registryKey?.Close();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, registryKey, flag, versionKey);
			throw;
		}
	}

	[ReportUsageAttribute1]
	public static void ReportUsage([DoNotPruneAttribute1][FeatureName] string featureName)
	{
	}
}
