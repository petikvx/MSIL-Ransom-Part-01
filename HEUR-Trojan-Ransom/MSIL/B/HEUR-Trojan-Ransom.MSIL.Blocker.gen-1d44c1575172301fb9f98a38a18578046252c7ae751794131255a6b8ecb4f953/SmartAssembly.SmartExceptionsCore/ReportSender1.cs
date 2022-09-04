using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender1
{
	private sealed class Class25
	{
		private readonly ReportSender1 reportSender1_0;

		private readonly byte[] byte_0;

		private readonly Class30 class30_0;

		private readonly Class27 class27_0;

		public bool bool_0 = true;

		public Class25(ReportSender1 reportSender1_1, byte[] byte_1, Class30 class30_1, Class27 class27_1)
		{
			try
			{
				reportSender1_0 = reportSender1_1;
				class27_0 = class27_1;
				class30_0 = class30_1;
				byte_0 = byte_1;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, this, reportSender1_1, byte_1, class30_1, class27_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			byte[] bytes = default(byte[]);
			byte[] array = default(byte[]);
			Class26 @class = default(Class26);
			string text = default(string);
			try
			{
				if (string_0 == "OK")
				{
					reportSender1_0.InvokeSendingReportFeedback(SendingReportStep1.Transfering);
					bytes = Encoding.UTF8.GetBytes("{5073F953-287E-4137-ADF6-D4C5C7821FA6}");
					array = new byte[bytes.Length + byte_0.Length];
					Array.Copy(bytes, array, bytes.Length);
					Array.Copy(byte_0, 0, array, bytes.Length, byte_0.Length);
					@class = new Class26(reportSender1_0);
					class30_0.method_2(array, class27_0.method_2(), class27_0.method_1(), class27_0.method_0(), @class.method_0);
					bool_0 = @class.bool_0;
				}
				else
				{
					text = string_0;
					if (reportSender1_0.sendingReportFeedbackEventHandler1_0 != null)
					{
						reportSender1_0.sendingReportFeedbackEventHandler1_0(this, new SendingReportFeedbackEventArgs1(SendingReportStep1.ConnectingToServer, text));
					}
					bool_0 = false;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException6(exception, bytes, array, @class, text, this, string_0);
				throw;
			}
		}
	}

	private sealed class Class26
	{
		public bool bool_0;

		internal ReportSender1 reportSender1_0;

		public Class26(ReportSender1 reportSender1_1)
		{
			try
			{
				ReportSender1 reportSender = (reportSender1_0 = reportSender1_1);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, reportSender1_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			try
			{
				if (string_0.StartsWith("ERR"))
				{
					reportSender1_0.InvokeSendingReportFeedback(SendingReportStep1.Transfering, string_0);
					bool_0 = false;
				}
				else
				{
					reportSender1_0.InvokeSendingReportFeedback(SendingReportStep1.Finished, string.Empty, string_0);
					bool_0 = true;
				}
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, string_0);
				throw;
			}
		}
	}

	internal sealed class Class27
	{
		public static Class27 class27_0;

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class27(string string_3, string string_4, string string_5)
		{
			try
			{
				string_0 = string_3;
				string_2 = string_5;
				string_1 = string_4;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, this, string_3, string_4, string_5);
				throw;
			}
		}

		[SpecialName]
		public string method_0()
		{
			try
			{
				return string_2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		[SpecialName]
		public string method_1()
		{
			try
			{
				return string_1;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		[SpecialName]
		public string method_2()
		{
			try
			{
				return string_0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}

		static Class27()
		{
			try
			{
				class27_0 = new Class27(null, null, null);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	protected const string AssemblyID = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	private IWebProxy iwebProxy_0;

	internal UsageCounts usageCounts_0;

	internal SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler1_0;

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

	public void SetProxy(IWebProxy proxy)
	{
		try
		{
			iwebProxy_0 = proxy;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, proxy);
			throw;
		}
	}

	internal bool method_0(byte[] byte_0, Class27 class27_0)
	{
		byte[] array = default(byte[]);
		bool flag = default(bool);
		byte[] array2 = default(byte[]);
		Class30 @class = default(Class30);
		Class25 class2 = default(Class25);
		try
		{
			try
			{
				array = SimpleZip.Zip(byte_0);
			}
			catch (Exception)
			{
				InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, SimpleZip.ExceptionMessage);
				flag = false;
				return flag;
			}
			array2 = Class24.smethod_0(array, "<RSAKeyValue><Modulus>8ffGzqH8cUgPLkoH3ibGxj6nE0hNZGkVODIrZjCJm6mfxDpxs499ievE/14TSnD/fIR+53p6oEhKA+UF0zNLpe1KdUs9Iol7A3oItdO76YE/SfVE8dlaMnFYKlXiCKm0+ymC/k9lFG/4Ynt/jBQPc9jSS7nMszq5SLB6n4PbLXU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			if (array2 == null)
			{
				InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, Class24.string_0);
				return false;
			}
			InvokeSendingReportFeedback(SendingReportStep1.ConnectingToServer);
			@class = new Class30("a9b48f91-4f96-f20e-0538-d1460b5d526e");
			if (iwebProxy_0 != null)
			{
				@class.method_0(iwebProxy_0);
			}
			class2 = new Class25(this, array2, @class, class27_0);
			@class.method_1(class2.method_0);
			return class2.bool_0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, array, array2, @class, class2, flag, this, byte_0, class27_0);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step, string errorMessage, string reportId)
	{
		SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
		try
		{
			sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
			sendingReportFeedbackEventHandler?.Invoke(this, new SendingReportFeedbackEventArgs1(step, errorMessage, reportId));
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, sendingReportFeedbackEventHandler, this, step, errorMessage, reportId);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step, string errorMessage)
	{
		try
		{
			InvokeSendingReportFeedback(step, errorMessage, string.Empty);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, step, errorMessage);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 step)
	{
		try
		{
			InvokeSendingReportFeedback(step, string.Empty);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, step);
			throw;
		}
	}
}
