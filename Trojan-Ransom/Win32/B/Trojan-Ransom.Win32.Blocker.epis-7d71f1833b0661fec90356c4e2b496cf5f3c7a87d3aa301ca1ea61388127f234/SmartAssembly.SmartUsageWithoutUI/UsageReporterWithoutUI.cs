using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.SmartUsageWithoutUI;

internal class UsageReporterWithoutUI : UsageReporter
{
	public static void FeatureUsed(uint featureId)
	{
		UsageReporterWithoutUI usageReporterWithoutUI = new UsageReporterWithoutUI();
		usageReporterWithoutUI.RecordFeatureUsed(featureId);
	}

	public static void DynamicFeatureUsed(string featureName)
	{
		UsageReporterWithoutUI usageReporterWithoutUI = new UsageReporterWithoutUI();
		usageReporterWithoutUI.RecordFeatureUsed(featureName);
	}

	protected override void ReportUsage(UsageReportSender sender)
	{
		sender.SendReport();
	}

	protected override bool CanReportUsage()
	{
		return true;
	}
}
