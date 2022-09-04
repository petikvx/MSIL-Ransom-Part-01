using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal static class Class26
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 1320)]
	private struct Struct12
	{
	}

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[660];

	private static readonly Array array_2;

	internal static byte byte_0/* Not supported: data(00) */;

	public static void smethod_0()
	{
		int major = default(int);
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
				major = Environment.OSVersion.Version.Major;
				switch (major)
				{
				case 5:
					minor2 = Environment.OSVersion.Version.Minor;
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
					minor = Environment.OSVersion.Version.Minor;
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
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException3(exception_, major, minor2, minor);
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
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException0(exception_);
			throw;
		}
	}

	public static void smethod_2()
	{
		try
		{
			try
			{
				smethod_7("Platform Culture Name: " + CultureInfo.CurrentCulture.Name);
			}
			catch
			{
			}
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException0(exception_);
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
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException0(exception_);
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
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, bool_);
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
			StackFrameHelper.CreateException3(exception_, moduleHandle, string_0, string_1);
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
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\" + string_0);
				if (registryKey == null)
				{
					registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\NET Framework Setup\\NDP\\" + string_0);
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
			StackFrameHelper.CreateException3(exception_, registryKey, flag, string_0);
			throw;
		}
	}

	public static void smethod_7([Attribute0] string string_0)
	{
		Class28.smethod_1(string_0);
	}

	static Class26()
	{
		char[] array = new char[8];
		array[7] = '\u139c';
		array[4] = 'ᯚ';
		array[1] = '㛝';
		array[3] = '\u0ef5';
		array[5] = 'ᑷ';
		array[6] = 'ߺ';
		array[0] = 'क़';
		array[2] = '⟫';
		array_2 = new string[39];
		array_0 = array;
	}
}
