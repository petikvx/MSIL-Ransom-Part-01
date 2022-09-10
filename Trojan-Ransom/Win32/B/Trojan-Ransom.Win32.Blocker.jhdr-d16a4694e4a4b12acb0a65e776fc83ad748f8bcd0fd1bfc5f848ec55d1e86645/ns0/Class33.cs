using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.StringsEncoding;

namespace ns0;

internal static class Class33
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
				if (smethod_6(Strings.Get(4140)))
				{
					smethod_7(Strings.Get(4145));
				}
				else if (smethod_6(Strings.Get(4186)))
				{
					smethod_7(Strings.Get(4195));
				}
				else if (smethod_6(Strings.Get(4236)))
				{
					smethod_7(Strings.Get(4245));
				}
				else if (smethod_6(Strings.Get(4286)))
				{
					smethod_7(Strings.Get(4303));
				}
				else if (smethod_6(Strings.Get(4344)))
				{
					smethod_7(Strings.Get(4357));
				}
				major = Environment.OSVersion.Version.Major;
				switch (major)
				{
				case 5:
					minor2 = Environment.OSVersion.Version.Minor;
					switch (minor2)
					{
					case 0:
						smethod_7(Strings.Get(4398));
						break;
					case 1:
						smethod_7(Strings.Get(4431));
						break;
					case 2:
						smethod_7(Strings.Get(4460));
						break;
					}
					break;
				case 6:
					minor = Environment.OSVersion.Version.Minor;
					switch (minor)
					{
					case 0:
						smethod_7(Strings.Get(4493));
						break;
					case 1:
						smethod_7(Strings.Get(4534));
						break;
					case 2:
						smethod_7(Strings.Get(4571));
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
			StackFrameHelper.CreateException3(exception, major, minor2, minor);
			throw;
		}
	}

	public static void smethod_1()
	{
		try
		{
			try
			{
				smethod_7(Strings.Get(4600) + Environment.ProcessorCount);
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
				smethod_7(Strings.Get(4629) + CultureInfo.CurrentCulture.Name);
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
				smethod_7(Strings.Get(4662) + (smethod_4() ? 64 : 32));
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
			if (smethod_5(Strings.Get(4691), Strings.Get(4708)) && IsWow64Process(GetCurrentProcess(), out bool_))
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
				registryKey = Registry.LocalMachine.OpenSubKey(Strings.Get(4729) + string_0);
				if (registryKey == null)
				{
					registryKey = Registry.LocalMachine.OpenSubKey(Strings.Get(4790) + string_0);
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
			StackFrameHelper.CreateException3(exception, registryKey, flag, string_0);
			throw;
		}
	}

	public static void smethod_7([Attribute0] string string_0)
	{
		Class35.smethod_1(string_0);
	}
}
