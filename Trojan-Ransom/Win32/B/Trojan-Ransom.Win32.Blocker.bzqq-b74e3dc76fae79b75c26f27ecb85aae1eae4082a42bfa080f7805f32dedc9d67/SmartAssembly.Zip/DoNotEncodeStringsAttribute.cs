using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.Zip;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class DoNotEncodeStringsAttribute : Attribute
{
	public DoNotEncodeStringsAttribute()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static DoNotEncodeStringsAttribute()
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

	internal static DateTime smethod_0(ref DateTime dateTime_0, double double_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 125:
					return dateTime_0.AddDays(double_0);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, dateTime_0, double_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(Control control_0, bool bool_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 73:
					control_0.set_AutoSize(bool_0);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, bool_0, int_0, int_1);
			throw;
		}
	}

	internal static StackFrame smethod_2(StackTrace stackTrace_0, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 91:
					return stackTrace_0.GetFrame(int_0);
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, stackTrace_0, int_0, int_1, int_2);
			throw;
		}
	}

	internal static IntPtr smethod_3(Font font_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 15:
					return font_0.ToHfont();
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, font_0, int_0, int_1);
			throw;
		}
	}
}
