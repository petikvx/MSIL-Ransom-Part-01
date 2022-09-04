using System;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.SmartUsageWithoutUI;

internal sealed class UsageReporterWithoutUI : UsageReporter
{
	public static void FeatureUsed(uint featureId)
	{
		UsageReporterWithoutUI usageReporterWithoutUI = default(UsageReporterWithoutUI);
		try
		{
			usageReporterWithoutUI = new UsageReporterWithoutUI();
			usageReporterWithoutUI.RecordFeatureUsed(featureId);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, usageReporterWithoutUI, featureId);
			throw;
		}
	}

	public static void DynamicFeatureUsed(string featureName)
	{
		UsageReporterWithoutUI usageReporterWithoutUI = default(UsageReporterWithoutUI);
		try
		{
			usageReporterWithoutUI = new UsageReporterWithoutUI();
			usageReporterWithoutUI.RecordFeatureUsed(featureName);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, usageReporterWithoutUI, featureName);
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
