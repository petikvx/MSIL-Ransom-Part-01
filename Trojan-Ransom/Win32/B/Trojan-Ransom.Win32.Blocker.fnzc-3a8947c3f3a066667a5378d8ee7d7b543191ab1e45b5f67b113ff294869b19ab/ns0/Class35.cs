using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32;
using SmartAssembly.Attributes;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal static class Class35
{
	public static void smethod_0()
	{
		int num = default(int);
		int minor2 = default(int);
		int minor = default(int);
		try
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
				num = ReportExceptionEventArgs.smethod_0(SecurityExceptionEventArgs.smethod_0(182, 151).Version, 883, 774);
				switch (num)
				{
				case 5:
					minor2 = SecurityExceptionEventArgs.smethod_0(526, 559).Version.Minor;
					switch (minor2)
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
					minor = SecurityExceptionEventArgs.smethod_0(238, 207).Version.Minor;
					switch (minor)
					{
					case 0:
						smethod_7("Platform: Windows Vista/2008");
						break;
					case 1:
						smethod_7("Platform: Windows 7/2008 R2");
						break;
					case 2:
						smethod_7("Platform: Windows 8");
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, minor2, minor);
			throw;
		}
	}

	public static void smethod_1()
	{
		try
		{
			try
			{
				smethod_7("Platform CPU Cores: " + Environment.ProcessorCount);
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

	public static void smethod_2()
	{
		try
		{
			try
			{
				smethod_7(smethod_8("Platform Culture Name: ", CultureInfo.CurrentCulture.Name, 796, 882));
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

	public static void smethod_3()
	{
		try
		{
			try
			{
				smethod_7("Platform OS Bitness: " + (smethod_4() ? 64 : 32));
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

	private static bool smethod_4()
	{
		bool bool_ = default(bool);
		try
		{
			if (IntPtr.Size == 8)
			{
				return true;
			}
			if (smethod_5("kernel32.dll", "IsWow64Process") && IsWow64Process(GetCurrentProcess(), out bool_))
			{
				return bool_;
			}
			return false;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, bool_);
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, moduleHandle, string_0, string_1);
			throw;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPStr)] string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

	private static bool smethod_6(string string_0)
	{
		RegistryKey registryKey = default(RegistryKey);
		bool flag = default(bool);
		try
		{
			registryKey = null;
			try
			{
				registryKey = DoNotObfuscateAttribute.smethod_0(Registry.LocalMachine, smethod_8("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\", string_0, 820, 858), 89, 80);
				if (registryKey == null)
				{
					registryKey = DoNotObfuscateAttribute.smethod_0(Registry.LocalMachine, smethod_8("SOFTWARE\\Wow6432Node\\Microsoft\\NET Framework Setup\\NDP\\", string_0, 160, 206), 132, 141);
				}
				flag = registryKey != null;
				return flag;
			}
			finally
			{
				if (registryKey != null)
				{
					DoNotDistributeAttribute.smethod_0(registryKey, 284, 342);
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, registryKey, flag, string_0);
			throw;
		}
	}

	public static void smethod_7([Attribute0] string string_0)
	{
		Class37.smethod_1(string_0);
	}

	[SecuritySafeCritical]
	static Class35()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static string smethod_8(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 110:
				return string_0 + string_1;
			}
		}
	}
}
