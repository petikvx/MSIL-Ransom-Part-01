using System;
using System.Reflection;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class DoNotObfuscateAttribute : Attribute
{
	public DoNotObfuscateAttribute()
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

	static DoNotObfuscateAttribute()
	{
		try
		{
			DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static void smethod_0(RegistryKey registryKey_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 5;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 92:
					registryKey_0.Close();
					return;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, registryKey_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(Array array_0, Array array_1, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 93:
					Array.Copy(array_0, array_1, int_0);
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException7(exception, num, num2, array_0, array_1, int_0, int_1, int_2);
			throw;
		}
	}

	internal static byte smethod_2(int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 107:
					return Convert.ToByte(int_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, int_0, int_1, int_2);
			throw;
		}
	}

	internal static object smethod_3(FieldInfo fieldInfo_0, object object_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 76:
					return fieldInfo_0.GetValue(object_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, fieldInfo_0, object_0, int_0, int_1);
			throw;
		}
	}
}
