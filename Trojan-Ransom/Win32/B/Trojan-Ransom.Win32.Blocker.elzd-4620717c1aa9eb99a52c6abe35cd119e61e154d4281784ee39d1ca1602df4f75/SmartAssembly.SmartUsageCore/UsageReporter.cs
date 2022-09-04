using System;
using System.Threading;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace SmartAssembly.SmartUsageCore;

public abstract class UsageReporter
{
	private sealed class Class34
	{
		public UsageCounts usageCounts_0;

		public UsageReporter usageReporter_0;

		public void method_0()
		{
			try
			{
				usageReporter_0.method_2(usageCounts_0);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException1(exception_, this);
				throw;
			}
		}
	}

	private static bool bool_0;

	private static readonly object object_0;

	internal SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler1_0;

	protected void RecordFeatureUsed(uint uint_0)
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
					UsageCountStore.IncrementUsage(uint_0);
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
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException3(exception_, obj, this, uint_0);
			throw;
		}
	}

	protected void RecordFeatureUsed(string string_0)
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
					UsageCountStore.IncrementUsage(string_0);
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
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException3(exception_, obj, this, string_0);
			throw;
		}
	}

	private void method_0()
	{
		Class34 @class = default(Class34);
		Thread thread = default(Thread);
		try
		{
			if (!bool_0)
			{
				@class = new Class34();
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
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException3(exception_, thread, @class, this);
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
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException5(exception_, allUsageCounts, usageReportSender, this, sender, e);
			throw;
		}
	}

	protected abstract void ReportUsage(UsageReportSender usageReportSender_0);

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
			Class31.smethod_0();
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException3(exception_, usageReportSender, this, usageCounts_0);
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
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException4(exception_, sendingReportFeedbackEventHandler, this, sender, e);
			throw;
		}
	}

	static UsageReporter()
	{
		try
		{
			object_0 = new object();
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException0(exception_);
			throw;
		}
	}
}
