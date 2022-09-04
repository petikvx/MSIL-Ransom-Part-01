using System;
using System.Threading;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

public abstract class UsageReporter
{
	private static bool s_SessionStarted;

	private static readonly object s_RecordFeatureUsedLock = new object();

	public event SendingReportFeedbackEventHandler1 SendingReportFeedback;

	protected void RecordFeatureUsed(uint featureId)
	{
		try
		{
			lock (s_RecordFeatureUsedLock)
			{
				ReportUsageIfNewSession();
				UsageCountStore.IncrementUsage(featureId);
			}
		}
		catch
		{
		}
	}

	protected void RecordFeatureUsed(string featureName)
	{
		try
		{
			lock (s_RecordFeatureUsedLock)
			{
				ReportUsageIfNewSession();
				UsageCountStore.IncrementUsage(featureName);
			}
		}
		catch
		{
		}
	}

	private void ReportUsageIfNewSession()
	{
		if (!s_SessionStarted)
		{
			UsageCounts prevUsageCounts = UsageCountStore.GetAllUsageCountsAndReset();
			Thread thread = new Thread((ThreadStart)delegate
			{
				OnSessionStart(prevUsageCounts);
			});
			thread.IsBackground = true;
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			AppDomain.CurrentDomain.ProcessExit += CurrentDomainOnProcessExit;
			s_SessionStarted = true;
		}
	}

	private void CurrentDomainOnProcessExit(object sender, EventArgs e)
	{
		UsageCounts allUsageCounts = UsageCountStore.GetAllUsageCounts();
		if (!allUsageCounts.IsEmpty)
		{
			UsageReportSender usageReportSender = new UsageReportSender(allUsageCounts);
			usageReportSender.SendingReportFeedback += InvokeSendingReportFeedback;
			if (CanReportUsage())
			{
				ReportUsage(usageReportSender);
				UsageCountStore.Reset();
			}
		}
	}

	protected abstract void ReportUsage(UsageReportSender sender);

	protected abstract bool CanReportUsage();

	private void OnSessionStart(UsageCounts usageCounts)
	{
		UsageReportSender usageReportSender = new UsageReportSender(usageCounts);
		usageReportSender.SendingReportFeedback += InvokeSendingReportFeedback;
		if (CanReportUsage())
		{
			Thread.CurrentThread.IsBackground = false;
			ReportUsage(usageReportSender);
		}
		PlatformUsageCounter.CountPlatformUsages();
	}

	private void InvokeSendingReportFeedback(object sender, SendingReportFeedbackEventArgs1 e)
	{
		this.SendingReportFeedback?.Invoke(sender, e);
	}
}
