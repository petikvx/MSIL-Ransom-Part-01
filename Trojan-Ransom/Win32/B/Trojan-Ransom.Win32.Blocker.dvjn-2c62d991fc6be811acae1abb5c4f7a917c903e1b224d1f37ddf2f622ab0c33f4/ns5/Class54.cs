using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using SmartAssembly.SmartUsageCore;
using ns3;
using ns9;

namespace ns5;

internal static class Class54
{
	public static void smethod_0()
	{
		int major = default(int);
		int minor2 = default(int);
		int minor = default(int);
		try
		{
			try
			{
				if (smethod_6(Class15.smethod_0(954777)))
				{
					smethod_7(Class15.smethod_0(954782));
				}
				else if (smethod_6(Class15.smethod_0(954823)))
				{
					smethod_7(Class15.smethod_0(954832));
				}
				else if (smethod_6(Class15.smethod_0(954873)))
				{
					smethod_7(Class15.smethod_0(954882));
				}
				else if (smethod_6(Class15.smethod_0(954923)))
				{
					smethod_7(Class15.smethod_0(954940));
				}
				else if (smethod_6(Class15.smethod_0(954981)))
				{
					smethod_7(Class15.smethod_0(954994));
				}
				major = Environment.OSVersion.Version.Major;
				switch (major)
				{
				case 5:
					minor2 = Environment.OSVersion.Version.Minor;
					switch (minor2)
					{
					case 0:
						smethod_7(Class15.smethod_0(955035));
						break;
					case 1:
						smethod_7(Class15.smethod_0(955068));
						break;
					case 2:
						smethod_7(Class15.smethod_0(955097));
						break;
					}
					break;
				case 6:
					minor = Environment.OSVersion.Version.Minor;
					switch (minor)
					{
					case 0:
						smethod_7(Class15.smethod_0(955130));
						break;
					case 1:
						smethod_7(Class15.smethod_0(955171));
						break;
					case 2:
						smethod_7(Class15.smethod_0(955208));
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
		catch (Exception exception_)
		{
			Class38.smethod_3(exception_, major, minor2, minor);
			throw;
		}
	}

	public static void smethod_1()
	{
		try
		{
			try
			{
				smethod_7(Class15.smethod_0(955237) + Environment.ProcessorCount);
			}
			catch
			{
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_0(exception_);
			throw;
		}
	}

	public static void smethod_2()
	{
		try
		{
			try
			{
				smethod_7(Class15.smethod_0(955266) + CultureInfo.CurrentCulture.Name);
			}
			catch
			{
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_0(exception_);
			throw;
		}
	}

	public static void smethod_3()
	{
		try
		{
			try
			{
				smethod_7(Class15.smethod_0(955299) + (smethod_4() ? 64 : 32));
			}
			catch
			{
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_0(exception_);
			throw;
		}
	}

	private static bool smethod_4()
	{
		bool wow64Process = default(bool);
		try
		{
			if (IntPtr.Size == 8)
			{
				return true;
			}
			if (smethod_5(Class15.smethod_0(955328), Class15.smethod_0(955345)) && IsWow64Process(GetCurrentProcess(), out wow64Process))
			{
				return wow64Process;
			}
			return false;
		}
		catch (Exception exception_)
		{
			Class38.smethod_1(exception_, wow64Process);
			throw;
		}
	}

	private static bool smethod_5(string string_0, string string_1)
	{
		IntPtr moduleHandle = default(IntPtr);
		try
		{
			moduleHandle = GetModuleHandle(string_0);
			if (moduleHandle == IntPtr.Zero)
			{
				return false;
			}
			return GetProcAddress(moduleHandle, string_1) != IntPtr.Zero;
		}
		catch (Exception exception_)
		{
			Class38.smethod_3(exception_, moduleHandle, string_0, string_1);
			throw;
		}
	}

	[DllImport("kernel32.Dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.Dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hModule, [MarshalAs(UnmanagedType.LPStr)] string procName);

	[DllImport("kernel32.Dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWow64Process(IntPtr hProcess, out bool wow64Process);

	private static bool smethod_6(string string_0)
	{
		RegistryKey registryKey = default(RegistryKey);
		bool flag = default(bool);
		try
		{
			registryKey = null;
			try
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class15.smethod_0(955366) + string_0);
				if (registryKey == null)
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Class15.smethod_0(955427) + string_0);
				}
				flag = registryKey != null;
				return flag;
			}
			finally
			{
				registryKey?.Close();
			}
		}
		catch (Exception exception_)
		{
			Class38.smethod_3(exception_, registryKey, flag, string_0);
			throw;
		}
	}

	public static void smethod_7([FeatureName][Attribute3] string featureName)
	{
		Class59.smethod_1(featureName);
	}
}
