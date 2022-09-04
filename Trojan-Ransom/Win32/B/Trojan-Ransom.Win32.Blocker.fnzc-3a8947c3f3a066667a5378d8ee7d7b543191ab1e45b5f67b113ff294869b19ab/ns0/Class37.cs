using System;
using System.Diagnostics;
using System.Security;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class37 : UsageReporter
{
	public static void smethod_0(uint uint_0)
	{
		Class37 @class = default(Class37);
		try
		{
			@class = new Class37();
			@class.RecordFeatureUsed(uint_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, @class, uint_0);
			throw;
		}
	}

	public static void smethod_1(string string_0)
	{
		Class37 @class = default(Class37);
		try
		{
			@class = new Class37();
			@class.RecordFeatureUsed(string_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, @class, string_0);
			throw;
		}
	}

	protected override void ReportUsage(UsageReportSender sender)
	{
		try
		{
			sender.SendReport();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, sender);
			throw;
		}
	}

	protected override bool CanReportUsage()
	{
		try
		{
			return true;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	[SecuritySafeCritical]
	static Class37()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static Process[] smethod_2(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 36:
				return Process.GetProcessesByName(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_3(string string_0, string string_1, string string_2, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 18:
				return string_0 + string_1 + string_2;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_4(ref long long_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 127:
				return long_0.ToString(string_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Exception smethod_5(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 102:
				return exception_0.InnerException;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_6(ref DateTime dateTime_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 27:
				return dateTime_0.Day;
			}
		}
	}
}
