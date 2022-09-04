using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Win32;

internal static class Class26
{
	public static void smethod_0()
	{
		try
		{
			if (smethod_6(GClass4.smethod_0(1244)))
			{
				smethod_7(GClass4.smethod_0(1249));
			}
			else if (smethod_6(GClass4.smethod_0(1290)))
			{
				smethod_7(GClass4.smethod_0(1299));
			}
			else if (smethod_6(GClass4.smethod_0(1340)))
			{
				smethod_7(GClass4.smethod_0(1349));
			}
			else if (smethod_6(GClass4.smethod_0(1390)))
			{
				smethod_7(GClass4.smethod_0(1407));
			}
			else if (smethod_6(GClass4.smethod_0(1448)))
			{
				smethod_7(GClass4.smethod_0(1461));
			}
			switch (Environment.OSVersion.Version.Major)
			{
			case 5:
				switch (Environment.OSVersion.Version.Minor)
				{
				case 0:
					smethod_7(GClass4.smethod_0(1502));
					break;
				case 1:
					smethod_7(GClass4.smethod_0(1535));
					break;
				case 2:
					smethod_7(GClass4.smethod_0(1564));
					break;
				}
				break;
			case 6:
				switch (Environment.OSVersion.Version.Minor)
				{
				case 0:
					smethod_7(GClass4.smethod_0(1597));
					break;
				case 1:
					smethod_7(GClass4.smethod_0(1638));
					break;
				case 2:
					smethod_7(GClass4.smethod_0(1675));
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
			smethod_7(GClass4.smethod_0(1704) + Environment.ProcessorCount);
		}
		catch
		{
		}
	}

	public static void smethod_2()
	{
		try
		{
			smethod_7(GClass4.smethod_0(1733) + CultureInfo.CurrentCulture.Name);
		}
		catch
		{
		}
	}

	public static void smethod_3()
	{
		try
		{
			smethod_7(GClass4.smethod_0(1766) + (smethod_4() ? 64 : 32));
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
		if (smethod_5(GClass4.smethod_0(1795), GClass4.smethod_0(1812)) && IsWow64Process(GetCurrentProcess(), out var bool_))
		{
			return bool_;
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
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPStr)] string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

	private static bool smethod_6(string string_0)
	{
		RegistryKey registryKey = null;
		try
		{
			registryKey = Registry.LocalMachine.OpenSubKey(GClass4.smethod_0(1833) + string_0);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(GClass4.smethod_0(1894) + string_0);
			}
			return registryKey != null;
		}
		finally
		{
			registryKey?.Close();
		}
	}

	public static void smethod_7([Attribute0] string string_0)
	{
		Class28.smethod_0(string_0);
	}
}
