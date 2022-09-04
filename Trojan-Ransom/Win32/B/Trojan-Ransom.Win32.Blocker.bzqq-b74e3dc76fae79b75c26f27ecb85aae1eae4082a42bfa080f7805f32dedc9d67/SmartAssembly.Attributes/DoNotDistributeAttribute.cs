using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.Attributes;

public sealed class DoNotDistributeAttribute : Attribute
{
	public DoNotDistributeAttribute(string s)
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, s);
			throw;
		}
	}

	static DoNotDistributeAttribute()
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

	internal static void smethod_0(Label label_0, bool bool_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 36:
					label_0.set_UseCompatibleTextRendering(bool_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, label_0, bool_0, int_0, int_1);
			throw;
		}
	}

	internal static byte smethod_1(ref Color color_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 30:
					return color_0.A;
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

	internal static Assembly smethod_2(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 113:
					return Assembly.GetEntryAssembly();
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static Exception smethod_3(Exception exception_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 65:
					return exception_0.InnerException;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, exception_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_4(Control control_0, Cursor cursor_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 83:
					control_0.set_Cursor(cursor_0);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, cursor_0, int_0, int_1);
			throw;
		}
	}

	internal static Module smethod_5(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 81:
					return assembly_0.ManifestModule;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, assembly_0, int_0, int_1);
			throw;
		}
	}
}
