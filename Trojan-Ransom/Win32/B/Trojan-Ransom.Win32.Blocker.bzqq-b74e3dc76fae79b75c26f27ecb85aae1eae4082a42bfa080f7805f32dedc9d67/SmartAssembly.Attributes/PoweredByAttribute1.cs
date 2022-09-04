using System;
using System.Reflection;
using System.Security.Principal;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.Attributes;

public sealed class PoweredByAttribute1 : Attribute
{
	public PoweredByAttribute1(string s)
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

	static PoweredByAttribute1()
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

	internal static int smethod_0(ref DateTime dateTime_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 119:
					return dateTime_0.Day;
				case 120:
					return dateTime_0.Hour;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, dateTime_0, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_1(Control control_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 9:
					return control_0.get_Visible();
				case 10:
					return control_0.Focus();
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, control_0, int_0, int_1);
			throw;
		}
	}

	internal static SecurityIdentifier smethod_2(WindowsIdentity windowsIdentity_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 34:
					return windowsIdentity_0.User;
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, windowsIdentity_0, int_0, int_1);
			throw;
		}
	}

	internal static ControlCollection smethod_3(Control control_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 58:
					return control_0.get_Controls();
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, control_0, int_0, int_1);
			throw;
		}
	}

	internal static Assembly smethod_4(Type type_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 125:
					return type_0.Assembly;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, type_0, int_0, int_1);
			throw;
		}
	}
}
