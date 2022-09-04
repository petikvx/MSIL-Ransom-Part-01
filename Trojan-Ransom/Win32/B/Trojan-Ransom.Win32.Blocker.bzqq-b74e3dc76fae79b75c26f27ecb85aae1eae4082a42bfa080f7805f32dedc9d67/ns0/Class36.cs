using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using Microsoft.Win32;
using My;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal static class Class36
{
	public static void smethod_0()
	{
		int num = default(int);
		int num2 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			try
			{
				try
				{
					num = 7;
					if (smethod_6("v4"))
					{
						num = 20;
						smethod_7("Platform: .NET 4.0 installed");
						num = 5;
					}
					else
					{
						num = 3;
						if (smethod_6("v3.5"))
						{
							num = 8;
							smethod_7("Platform: .NET 3.5 installed");
							num = 5;
						}
						else
						{
							num = 23;
							if (smethod_6("v3.0"))
							{
								num = 10;
								smethod_7("Platform: .NET 3.0 installed");
								num = 5;
							}
							else
							{
								num = 21;
								if (smethod_6("v2.0.50727"))
								{
									num = 4;
									smethod_7("Platform: .NET 2.0 installed");
									num = 5;
								}
								else
								{
									num = 15;
									if (smethod_6("v1.1.4322"))
									{
										num = 2;
										smethod_7("Platform: .NET 1.1 installed");
									}
									else
									{
										num = 5;
									}
								}
							}
						}
					}
					num2 = UsageCounts.smethod_0(WaitSendingReportControl.smethod_6(ReportSender1.smethod_5(924, 945), 278, 272), 491, 494);
					num = 1;
					switch (num2)
					{
					default:
						num = 17;
						num = 9;
						break;
					case 5:
						num = 0;
						num4 = Class28.smethod_5(WaitSendingReportControl.smethod_6(ReportSender1.smethod_5(804, 777), 784, 790), 494, 477);
						num = 14;
						switch (num4)
						{
						default:
							num = 12;
							num = 9;
							break;
						case 0:
							num = 13;
							smethod_7("Platform: Windows 2000");
							num = 9;
							break;
						case 1:
							num = 25;
							smethod_7("Platform: Windows XP");
							num = 9;
							break;
						case 2:
							num = 24;
							smethod_7("Platform: Windows 2003");
							num = 9;
							break;
						}
						break;
					case 6:
						num = 18;
						num3 = Class28.smethod_5(WaitSendingReportControl.smethod_6(ReportSender1.smethod_5(668, 689), 265, 271), 840, 891);
						num = 16;
						switch (num3)
						{
						default:
							num = 6;
							num = 9;
							break;
						case 0:
							num = 22;
							smethod_7("Platform: Windows Vista/2008");
							num = 9;
							break;
						case 1:
							num = 29;
							smethod_7("Platform: Windows 7/2008 R2");
							num = 9;
							break;
						case 2:
							num = 27;
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
				num5 = 4;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, num2, num4, num3);
				throw;
			}
			num6 = 0;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException6(exception2, num2, num4, num3, num, num5, num6);
			throw;
		}
	}

	public static void smethod_1()
	{
		try
		{
			try
			{
				try
				{
					smethod_7(MyApplication.smethod_1("Platform CPU Cores: ", Class5.smethod_5(186, 200), 587, 600));
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
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException0(exception2);
			throw;
		}
	}

	public static void smethod_2()
	{
		try
		{
			try
			{
				try
				{
					smethod_7(Form0.smethod_1("Platform Culture Name: ", AppPathFinder.smethod_2(UnhandledExceptionHandlerWithUI.smethod_7(633, 572), 23, 85), 524, 574));
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
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException0(exception2);
			throw;
		}
	}

	public static void smethod_3()
	{
		try
		{
			try
			{
				try
				{
					smethod_7(MyApplication.smethod_1("Platform OS Bitness: ", smethod_4() ? 64 : 32, 461, 478));
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
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException0(exception2);
			throw;
		}
	}

	private static bool smethod_4()
	{
		int num = default(int);
		bool flag = default(bool);
		bool bool_ = default(bool);
		try
		{
			try
			{
				num = 4;
				if (AppPathFinder.smethod_3(925, 950) == 8)
				{
					num = 2;
					flag = true;
					return flag;
				}
				num = 0;
				if (smethod_5("kernel32.dll", "IsWow64Process"))
				{
					num = 3;
					if (IsWow64Process(GetCurrentProcess(), out bool_))
					{
						num = 6;
						flag = bool_;
						return flag;
					}
					num = 7;
				}
				else
				{
					num = 7;
				}
				flag = false;
				return flag;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, bool_);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, bool_, flag, num);
			throw;
		}
	}

	private static bool smethod_5(string string_0, string string_1)
	{
		int num = default(int);
		IntPtr moduleHandle = default(IntPtr);
		bool flag = default(bool);
		try
		{
			try
			{
				num = 0;
				moduleHandle = GetModuleHandle(string_0);
				if (DoNotPruneTypeAttribute.smethod_6(moduleHandle, IntPtr.Zero, 744, 659))
				{
					flag = false;
					return flag;
				}
				flag = AppPathFinder.smethod_4(GetProcAddress(moduleHandle, string_1), IntPtr.Zero, 929, 1000);
				return flag;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, moduleHandle, string_0, string_1);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException5(exception2, moduleHandle, flag, num, string_0, string_1);
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
		int num = default(int);
		RegistryKey registryKey = default(RegistryKey);
		int num2 = default(int);
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		try
		{
			try
			{
				num = 1;
				registryKey = null;
				try
				{
					num2 = 1;
					registryKey = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_1(Registry.LocalMachine, Form0.smethod_1("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\", string_0, 773, 823), 644, 745);
					num2 = 5;
					if (registryKey == null)
					{
						registryKey = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_1(Registry.LocalMachine, Form0.smethod_1("SOFTWARE\\Wow6432Node\\Microsoft\\NET Framework Setup\\NDP\\", string_0, 477, 495), 256, 365);
						num2 = 2;
					}
					flag = registryKey != null;
				}
				finally
				{
					num3 = 1;
					if (registryKey != null)
					{
						SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_0(registryKey, 1023, 931);
					}
				}
				num4 = 1;
				flag2 = flag;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, registryKey, flag, string_0);
				throw;
			}
			num5 = 1;
			return flag2;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException9(exception2, registryKey, flag, flag2, num, num2, num3, num4, num5, string_0);
			throw;
		}
	}

	public static void smethod_7([Attribute0] string string_0)
	{
		try
		{
			Class38.smethod_1(string_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, string_0);
			throw;
		}
	}

	static Class36()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static string smethod_8(Exception exception_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 98:
					return exception_0.StackTrace;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, exception_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_9(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 50:
					return assembly_0.FullName;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, assembly_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_10(XmlWriter xmlWriter_0, string string_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					xmlWriter_0.WriteElementString(string_0, string_1);
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException7(exception, num, num2, xmlWriter_0, string_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static FileStream smethod_11(string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 73:
					return File.OpenWrite(string_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_0, int_0, int_1);
			throw;
		}
	}

	internal static byte[] smethod_12(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 5:
					return memoryStream_0.ToArray();
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, memoryStream_0, int_0, int_1);
			throw;
		}
	}
}
