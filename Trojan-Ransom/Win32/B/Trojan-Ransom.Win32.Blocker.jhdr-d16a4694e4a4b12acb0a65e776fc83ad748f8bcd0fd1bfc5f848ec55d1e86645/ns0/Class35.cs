using System;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class35 : UsageReporter
{
	public static void smethod_0(uint uint_0)
	{
		Class35 @class = default(Class35);
		try
		{
			@class = new Class35();
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
		Class35 @class = default(Class35);
		try
		{
			@class = new Class35();
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
}
