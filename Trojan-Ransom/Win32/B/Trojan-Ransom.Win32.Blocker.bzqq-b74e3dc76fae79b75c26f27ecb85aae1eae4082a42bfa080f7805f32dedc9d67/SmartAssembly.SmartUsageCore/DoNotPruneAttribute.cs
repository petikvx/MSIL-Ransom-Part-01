using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Threading;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace SmartAssembly.SmartUsageCore;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
public sealed class DoNotPruneAttribute : Attribute
{
	private static bool bool_0;

	public DoNotPruneAttribute()
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

	static DoNotPruneAttribute()
	{
		try
		{
			smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static decimal smethod_0(decimal decimal_0, decimal decimal_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 66:
					return decimal.Add(decimal_0, decimal_1);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, decimal_0, decimal_1, int_0, int_1);
			throw;
		}
	}

	internal static Assembly smethod_1(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 104:
					return Assembly.GetExecutingAssembly();
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(Thread thread_0, ApartmentState apartmentState_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 107:
					thread_0.SetApartmentState(apartmentState_0);
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, thread_0, apartmentState_0, int_0, int_1);
			throw;
		}
	}

	internal static byte[] smethod_3(SymmetricAlgorithm symmetricAlgorithm_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 35:
					return symmetricAlgorithm_0.Key;
				case 36:
					return symmetricAlgorithm_0.IV;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, symmetricAlgorithm_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_4(Component component_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 14:
					component_0.Dispose();
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, component_0, int_0, int_1);
			throw;
		}
	}

	internal static object smethod_5(Type type_0, bool bool_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 97:
					return Activator.CreateInstance(type_0, bool_1);
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, type_0, bool_1, int_0, int_1);
			throw;
		}
	}

	internal static SizeF smethod_6(Graphics graphics_0, string string_0, Font font_0, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 89:
					return graphics_0.MeasureString(string_0, font_0, int_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num, graphics_0, string_0, font_0, int_0, int_1, int_2);
			throw;
		}
	}

	internal static bool smethod_7(Type type_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 40:
					return type_0.IsByRef;
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, type_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_8()
	{
		int num = default(int);
		Type typeFromHandle = default(Type);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			num = 0;
			if (bool_0)
			{
				return;
			}
			num = 1;
			Monitor.Enter(typeFromHandle = typeof(DoNotPruneAttribute));
			try
			{
				num2 = 2;
				if (!bool_0)
				{
					bool_0 = true;
					AppDomain.CurrentDomain.ResourceResolve += Class22.smethod_2;
					num2 = 5;
				}
			}
			finally
			{
				Monitor.Exit(typeFromHandle);
			}
			num3 = 2;
			num3 = 0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, typeFromHandle, num, num2, num3);
			throw;
		}
	}
}
