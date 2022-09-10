using System;
using System.Threading;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace SmartAssembly.SmartUsageCore;

public abstract class UsageReporter
{
	private sealed class Class36
	{
		public UsageCounts usageCounts_0;

		public UsageReporter usageReporter_0;

		public void method_0()
		{
			try
			{
				usageReporter_0.method_2(usageCounts_0);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	private static bool bool_0;

	private SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler1_0;

	private static readonly object object_0;

	public event SendingReportFeedbackEventHandler1 SendingReportFeedback
	{
		add
		{
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler1);
			try
			{
				sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler1)Delegate.Combine(sendingReportFeedbackEventHandler2, value);
					sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler1_0, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
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
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler1);
			try
			{
				sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
				do
				{
					sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
					sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler1)Delegate.Remove(sendingReportFeedbackEventHandler2, value);
					sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler1_0, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
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
				Monitor.Enter(obj = object_0);
				try
				{
					method_0();
					UsageCountStore.IncrementUsage(featureId);
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
				Monitor.Enter(obj = object_0);
				try
				{
					method_0();
					UsageCountStore.IncrementUsage(featureName);
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

	private void method_0()
	{
		Class36 @class = default(Class36);
		Thread thread = default(Thread);
		try
		{
			if (!bool_0)
			{
				@class = new Class36();
				@class.usageReporter_0 = this;
				@class.usageCounts_0 = UsageCountStore.GetAllUsageCountsAndReset();
				thread = new Thread(@class.method_0);
				thread.IsBackground = true;
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				AppDomain.CurrentDomain.ProcessExit += method_1;
				bool_0 = true;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, thread, @class, this);
			throw;
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		UsageCounts allUsageCounts = default(UsageCounts);
		UsageReportSender usageReportSender = default(UsageReportSender);
		try
		{
			allUsageCounts = UsageCountStore.GetAllUsageCounts();
			if (!allUsageCounts.IsEmpty)
			{
				usageReportSender = new UsageReportSender(allUsageCounts);
				usageReportSender.SendingReportFeedback += method_3;
				if (CanReportUsage())
				{
					ReportUsage(usageReportSender);
					UsageCountStore.Reset();
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, allUsageCounts, usageReportSender, this, sender, e);
			throw;
		}
	}

	protected abstract void ReportUsage(UsageReportSender sender);

	protected abstract bool CanReportUsage();

	private void method_2(UsageCounts usageCounts_0)
	{
		UsageReportSender usageReportSender = default(UsageReportSender);
		try
		{
			usageReportSender = new UsageReportSender(usageCounts_0);
			usageReportSender.SendingReportFeedback += method_3;
			if (CanReportUsage())
			{
				Thread.CurrentThread.IsBackground = false;
				ReportUsage(usageReportSender);
			}
			Class33.smethod_0();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, usageReportSender, this, usageCounts_0);
			throw;
		}
	}

	private void method_3(object sender, SendingReportFeedbackEventArgs1 e)
	{
		SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
		try
		{
			sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
			sendingReportFeedbackEventHandler?.Invoke(sender, e);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, sendingReportFeedbackEventHandler, this, sender, e);
			throw;
		}
	}

	static UsageReporter()
	{
		try
		{
			object_0 = new object();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
