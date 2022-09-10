using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

internal static class Class33
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
				num = Class13.smethod_1(AutoHeightLabel.smethod_2(429, 450).Version, 955, 950);
				switch (num)
				{
				case 5:
					minor2 = AutoHeightLabel.smethod_2(305, 350).Version.Minor;
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
					minor = AutoHeightLabel.smethod_2(758, 665).Version.Minor;
					switch (minor)
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
				smethod_7(ReportSender.smethod_0("Platform Culture Name: ", CultureInfo.CurrentCulture.Name, 211, 176));
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
			return Class37.smethod_6(GetProcAddress(moduleHandle, string_1), IntPtr.Zero, 465, 424);
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
				registryKey = SimpleZip.Class8.smethod_0(Registry.LocalMachine, ReportSender.smethod_0("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\", string_0, 308, 343), 697, 649);
				if (registryKey == null)
				{
					registryKey = SimpleZip.Class8.smethod_0(Registry.LocalMachine, ReportSender.smethod_0("SOFTWARE\\Wow6432Node\\Microsoft\\NET Framework Setup\\NDP\\", string_0, 889, 794), 39, 23);
				}
				flag = registryKey != null;
				return flag;
			}
			finally
			{
				if (registryKey != null)
				{
					DoNotPruneTypeAttribute.smethod_0(registryKey, 826, 794);
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, registryKey, flag, string_0);
			throw;
		}
	}

	[SmartAssembly.SmartUsageCore.ReportUsage]
	public static void smethod_7([SmartAssembly.SmartUsageCore.DoNotPrune][Attribute0] string string_0)
	{
		Class35.smethod_1(string_0);
	}

	static Class33()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static object smethod_8(MethodBase methodBase_0, object object_0, object[] object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 16:
				return methodBase_0.Invoke(object_0, object_1);
			}
		}
	}

	internal static void smethod_9(Graphics graphics_0, Rectangle rectangle_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 28:
				graphics_0.SetClip(rectangle_0);
				return;
			}
		}
	}

	internal static Color smethod_10(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 19:
				return Color.FromArgb(int_0);
			}
		}
	}

	internal static int smethod_11(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 44:
				return stream_0.Read(byte_0, int_0, int_1);
			}
		}
	}
}
