using System;
using System.Runtime.CompilerServices;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.SmartExceptionsCore;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public class ReportUsageAttribute : Attribute
{
	public ReportUsageAttribute()
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

	public ReportUsageAttribute(string featureName)
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, featureName);
			throw;
		}
	}

	static ReportUsageAttribute()
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

	internal static object smethod_0(object object_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 88:
					return RuntimeHelpers.GetObjectValue(object_0);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, object_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_1(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0, int int_0, int int_1)
	{
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 100:
					RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
					return;
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, array_0, runtimeFieldHandle_0, int_0, int_1);
			throw;
		}
	}
}
