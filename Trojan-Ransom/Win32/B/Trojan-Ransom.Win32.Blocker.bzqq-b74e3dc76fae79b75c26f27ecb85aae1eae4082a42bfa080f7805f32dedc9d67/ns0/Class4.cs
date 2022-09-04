using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class4
{
	public static string smethod_0()
	{
		int num = default(int);
		RegistryKey registryKey = default(RegistryKey);
		string text = default(string);
		string text2 = default(string);
		int num2 = default(int);
		string text3 = default(string);
		int num3 = default(int);
		try
		{
			try
			{
				try
				{
					num = 9;
					registryKey = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_1(Registry.LocalMachine, Class5.smethod_0(), 122, 23);
					if (registryKey == null)
					{
						num = 5;
						registryKey = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_1(Registry.LocalMachine, Class5.smethod_1(), 563, 606);
						num = 0;
					}
					else
					{
						num = 0;
					}
					if (registryKey == null)
					{
						num = 1;
						text = null;
					}
					else
					{
						num = 2;
						text2 = (string)DoNotPruneTypeAttribute.smethod_0(registryKey, "Path", null, 914, 938);
						num = 3;
						SmartAssembly.SmartUsageCore.DoNotObfuscateAttribute.smethod_0(registryKey, 160, 252);
						text = text2;
					}
				}
				catch
				{
					text = null;
				}
				num2 = 0;
				text3 = text;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, registryKey, text2, text);
				throw;
			}
			num3 = 2;
			return text3;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException7(exception2, registryKey, text2, text, text3, num, num2, num3);
			throw;
		}
	}

	static Class4()
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

	internal static void smethod_1(Label label_0, bool bool_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 50:
					label_0.set_TabStop(bool_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, label_0, bool_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_2(ref DateTime dateTime_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 111:
					return dateTime_0.Year;
				case 112:
					return dateTime_0.Second;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, dateTime_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_3(ref Color color_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 125:
					return color_0.ToArgb();
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, color_0, int_0, int_1);
			throw;
		}
	}

	internal static AppDomain smethod_4(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 31:
					return AppDomain.CurrentDomain;
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_5(Control control_0, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			num = 2;
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 79:
					control_0.set_Height(int_0);
					return;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, int_0, int_1, int_2);
			throw;
		}
	}

	internal static object smethod_6(UnhandledExceptionEventArgs unhandledExceptionEventArgs_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 46:
					return unhandledExceptionEventArgs_0.ExceptionObject;
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, unhandledExceptionEventArgs_0, int_0, int_1);
			throw;
		}
	}

	internal static object smethod_7(Array array_0, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 102:
					return array_0.GetValue(int_0);
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, array_0, int_0, int_1, int_2);
			throw;
		}
	}
}
