using System;
using System.Threading;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartUsageCore;

public abstract class UsageReporter1
{
	private static bool s_SessionStarted;

	private static readonly object s_RecordFeatureUsedLock;

	public event SendingReportFeedbackEventHandler3 SendingReportFeedback
	{
		add
		{
			SendingReportFeedbackEventHandler3 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler3);
			SendingReportFeedbackEventHandler3 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler3);
			SendingReportFeedbackEventHandler3 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler3);
			try
			{
				sendingReportFeedbackEventHandler = this.SendingReportFeedback;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler3)Delegate.Combine(sendingReportFeedbackEventHandler2, value);
					sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref this.SendingReportFeedback, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
				}
				while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, this, value);
				throw;
			}
		}
		remove
		{
			SendingReportFeedbackEventHandler3 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler3);
			SendingReportFeedbackEventHandler3 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler3);
			SendingReportFeedbackEventHandler3 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler3);
			try
			{
				sendingReportFeedbackEventHandler = this.SendingReportFeedback;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler3)Delegate.Remove(sendingReportFeedbackEventHandler2, value);
					sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref this.SendingReportFeedback, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
				}
				while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, this, value);
				throw;
			}
		}
	}

	protected void RecordFeatureUsed(uint featureId)
	{
		object obj = default(object);
		try
		{
			try
			{
				Monitor.Enter(obj = s_RecordFeatureUsedLock);
				try
				{
					ReportUsageIfNewSession();
					UsageCountStore1.IncrementUsage(featureId);
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			catch
			{
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, obj, this, featureId);
			throw;
		}
	}

	protected void RecordFeatureUsed(string featureName)
	{
		object obj = default(object);
		try
		{
			try
			{
				Monitor.Enter(obj = s_RecordFeatureUsedLock);
				try
				{
					ReportUsageIfNewSession();
					UsageCountStore1.IncrementUsage(featureName);
				}
				finally
				{
					Monitor.Exit(obj);
				}
			}
			catch
			{
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, obj, this, featureName);
			throw;
		}
	}

	private void ReportUsageIfNewSession()
	{
		_003C_003Ec__DisplayClass1 _003C_003Ec__DisplayClass = default(_003C_003Ec__DisplayClass1);
		Thread thread = default(Thread);
		try
		{
			if (!s_SessionStarted)
			{
				_003C_003Ec__DisplayClass = new _003C_003Ec__DisplayClass1();
				_003C_003Ec__DisplayClass._003C_003E4__this = this;
				_003C_003Ec__DisplayClass.prevUsageCounts = UsageCountStore1.GetAllUsageCountsAndReset();
				thread = new Thread(_003C_003Ec__DisplayClass._003CReportUsageIfNewSession_003Eb__0);
				thread.IsBackground = true;
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				AppDomain.CurrentDomain.ProcessExit += CurrentDomainOnProcessExit;
				s_SessionStarted = true;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, thread, _003C_003Ec__DisplayClass, this);
			throw;
		}
	}

	private void CurrentDomainOnProcessExit(object sender, EventArgs e)
	{
		UsageCounts1 allUsageCounts = default(UsageCounts1);
		UsageReportSender1 usageReportSender = default(UsageReportSender1);
		try
		{
			allUsageCounts = UsageCountStore1.GetAllUsageCounts();
			if (!allUsageCounts.IsEmpty)
			{
				usageReportSender = new UsageReportSender1(allUsageCounts);
				usageReportSender.SendingReportFeedback += InvokeSendingReportFeedback;
				if (CanReportUsage())
				{
					ReportUsage(usageReportSender);
					UsageCountStore1.Reset();
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, allUsageCounts, usageReportSender, this, sender, e);
			throw;
		}
	}

	protected abstract void ReportUsage(UsageReportSender1 sender);

	protected abstract bool CanReportUsage();

	private void OnSessionStart(UsageCounts1 usageCounts)
	{
		UsageReportSender1 usageReportSender = default(UsageReportSender1);
		try
		{
			usageReportSender = new UsageReportSender1(usageCounts);
			usageReportSender.SendingReportFeedback += InvokeSendingReportFeedback;
			if (CanReportUsage())
			{
				Thread.CurrentThread.IsBackground = false;
				ReportUsage(usageReportSender);
			}
			PlatformUsageCounter.CountPlatformUsages();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, usageReportSender, this, usageCounts);
			throw;
		}
	}

	private void InvokeSendingReportFeedback(object sender, SendingReportFeedbackEventArgs3 e)
	{
		SendingReportFeedbackEventHandler3 sendingReportFeedback = default(SendingReportFeedbackEventHandler3);
		try
		{
			sendingReportFeedback = this.SendingReportFeedback;
			sendingReportFeedback?.Invoke(sender, e);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, sendingReportFeedback, this, sender, e);
			throw;
		}
	}

	static UsageReporter1()
	{
		try
		{
			s_RecordFeatureUsedLock = new object();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
