using System;
using System.Threading;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using ns0;

namespace SmartAssembly.SmartUsageCore;

public abstract class UsageReporter
{
	private sealed class Class39
	{
		public UsageCounts usageCounts_0;

		public UsageReporter usageReporter_0;

		public Class39()
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

		public void method_0()
		{
			try
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
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException1(exception2, this);
				throw;
			}
		}

		static Class39()
		{
			try
			{
				DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	private static bool bool_0;

	private static readonly object object_0;

	internal SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler1_0;

	public event SendingReportFeedbackEventHandler1 SendingReportFeedback
	{
		add
		{
			int num = default(int);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler1);
			int num2 = default(int);
			try
			{
				try
				{
					num = 3;
					sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
					num = 5;
					do
					{
						sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
						sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler1)WaitSendingReportControl.smethod_3(sendingReportFeedbackEventHandler2, value, 564, 564);
						num = 6;
						sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler1_0, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
					}
					while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, this, value);
					throw;
				}
				num2 = 1;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException7(exception2, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, num, num2, this, value);
				throw;
			}
		}
		remove
		{
			int num = default(int);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler2 = default(SendingReportFeedbackEventHandler1);
			SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler3 = default(SendingReportFeedbackEventHandler1);
			int num2 = default(int);
			try
			{
				try
				{
					num = 2;
					sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
					num = 5;
					do
					{
						sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
						sendingReportFeedbackEventHandler3 = (SendingReportFeedbackEventHandler1)AutoHeightLabel.smethod_2(sendingReportFeedbackEventHandler2, value, 318, 364);
						num = 4;
						sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler1_0, sendingReportFeedbackEventHandler3, sendingReportFeedbackEventHandler2);
					}
					while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
				}
				catch (Exception exception)
				{
					StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, this, value);
					throw;
				}
				num2 = 2;
			}
			catch (Exception exception2)
			{
				StackFrameHelper.CreateException7(exception2, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, num, num2, this, value);
				throw;
			}
		}
	}

	protected void RecordFeatureUsed(uint featureId)
	{
		object o = default(object);
		try
		{
			try
			{
				try
				{
					Class28.smethod_7(o = object_0, 696, 728);
					try
					{
						method_0();
						UsageCountStore.IncrementUsage(featureId);
					}
					finally
					{
						ReportSender.smethod_3(o, 142, 219);
					}
				}
				catch
				{
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, o, this, featureId);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, o, this, featureId);
			throw;
		}
	}

	protected void RecordFeatureUsed(string featureName)
	{
		object o = default(object);
		try
		{
			try
			{
				try
				{
					Class28.smethod_7(o = object_0, 292, 324);
					try
					{
						method_0();
						UsageCountStore.IncrementUsage(featureName);
					}
					finally
					{
						ReportSender.smethod_3(o, 547, 630);
					}
				}
				catch
				{
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, o, this, featureName);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, o, this, featureName);
			throw;
		}
	}

	private void method_0()
	{
		int num = default(int);
		Class39 @class = default(Class39);
		Thread thread = default(Thread);
		int num2 = default(int);
		try
		{
			try
			{
				num = 3;
				if (!bool_0)
				{
					@class = new Class39();
					@class.usageReporter_0 = this;
					@class.usageCounts_0 = UsageCountStore.GetAllUsageCountsAndReset();
					thread = new Thread(@class.method_0);
					num = 9;
					Class32.smethod_1(thread, bool_0: true, 440, 423);
					DoNotPruneAttribute.smethod_2(thread, ApartmentState.STA, 773, 878);
					num = 0;
					UsageReportSender.smethod_14(thread, 540, 530);
					Class4.smethod_4(469, 458).ProcessExit += method_1;
					num = 7;
					bool_0 = true;
					num = 6;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, thread, @class, this);
				throw;
			}
			num2 = 2;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException5(exception2, thread, @class, num, num2, this);
			throw;
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		int num = default(int);
		UsageCounts allUsageCounts = default(UsageCounts);
		UsageReportSender usageReportSender = default(UsageReportSender);
		try
		{
			try
			{
				num = 4;
				allUsageCounts = UsageCountStore.GetAllUsageCounts();
				if (!allUsageCounts.IsEmpty)
				{
					num = 0;
					usageReportSender = new UsageReportSender(allUsageCounts);
					usageReportSender.SendingReportFeedback += method_3;
					if (CanReportUsage())
					{
						num = 6;
						ReportUsage(usageReportSender);
						UsageCountStore.Reset();
					}
					else
					{
						num = 3;
					}
				}
				else
				{
					num = 3;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, allUsageCounts, usageReportSender, this, sender, e);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException6(exception2, allUsageCounts, usageReportSender, num, this, sender, e);
			throw;
		}
	}

	protected abstract void ReportUsage(UsageReportSender sender);

	protected abstract bool CanReportUsage();

	private void method_2(UsageCounts usageCounts_0)
	{
		int num = default(int);
		UsageReportSender usageReportSender = default(UsageReportSender);
		try
		{
			try
			{
				num = 0;
				usageReportSender = new UsageReportSender(usageCounts_0);
				usageReportSender.SendingReportFeedback += method_3;
				if (CanReportUsage())
				{
					Class32.smethod_1(DoNotObfuscateTypeAttribute.smethod_4(545, 618), bool_0: false, 851, 844);
					ReportUsage(usageReportSender);
				}
				Class36.smethod_0();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, usageReportSender, this, usageCounts_0);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException4(exception2, usageReportSender, num, this, usageCounts_0);
			throw;
		}
	}

	private void method_3(object sender, SendingReportFeedbackEventArgs1 e)
	{
		int num = default(int);
		SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
		try
		{
			try
			{
				num = 1;
				sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
				sendingReportFeedbackEventHandler?.Invoke(sender, e);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, sendingReportFeedbackEventHandler, this, sender, e);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException5(exception2, sendingReportFeedbackEventHandler, num, this, sender, e);
			throw;
		}
	}

	protected UsageReporter()
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

	static UsageReporter()
	{
		try
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
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException0(exception2);
			throw;
		}
	}
}
