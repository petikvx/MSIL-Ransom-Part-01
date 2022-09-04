using System;
using System.Reflection;
using System.Threading;
using Microsoft.Win32;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.SmartExceptionsCore;

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
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static RegistryKey smethod_0(RegistryKey registryKey_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 61:
					return registryKey_0.CreateSubKey(string_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, registryKey_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static RegistryKey smethod_1(RegistryKey registryKey_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 109:
					return registryKey_0.OpenSubKey(string_0);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, registryKey_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static MethodInfo smethod_2(Assembly assembly_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 111:
					return assembly_0.EntryPoint;
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

	internal static string smethod_3(ref int int_0, string string_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 54:
					return int_0.ToString(string_0);
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, int_0, string_0, int_1, int_2);
			throw;
		}
	}

	internal static void smethod_4(Mutex mutex_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 58:
					mutex_0.ReleaseMutex();
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, mutex_0, int_0, int_1);
			throw;
		}
	}
}
