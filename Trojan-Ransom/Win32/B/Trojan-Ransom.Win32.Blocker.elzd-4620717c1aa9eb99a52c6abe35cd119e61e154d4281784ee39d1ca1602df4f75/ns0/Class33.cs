using System;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class33 : UsageReporter
{
	public static void smethod_0(uint uint_0)
	{
		Class33 @class = default(Class33);
		try
		{
			@class = new Class33();
			@class.RecordFeatureUsed(uint_0);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException2(exception_, @class, uint_0);
			throw;
		}
	}

	public static void smethod_1(string string_0)
	{
		Class33 @class = default(Class33);
		try
		{
			@class = new Class33();
			@class.RecordFeatureUsed(string_0);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException2(exception_, @class, string_0);
			throw;
		}
	}

	protected override void ReportUsage(UsageReportSender usageReportSender_0)
	{
		try
		{
			usageReportSender_0.SendReport();
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException2(exception_, this, usageReportSender_0);
			throw;
		}
	}

	protected override bool CanReportUsage()
	{
		try
		{
			return true;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, this);
			throw;
		}
	}
}
