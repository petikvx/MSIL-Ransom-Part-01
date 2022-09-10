using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using SmartAssembly.StringsEncoding;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender1
{
	private sealed class Class26
	{
		private readonly Class28 class28_0;

		public bool bool_0 = true;

		internal ReportSender1 reportSender1_0;

		internal byte[] byte_0;

		internal Class31 class31_0;

		public Class26(ReportSender1 reportSender1_1, byte[] byte_1, Class31 class31_1, Class28 class28_1)
		{
			try
			{
				ReportSender1 reportSender = (reportSender1_0 = reportSender1_1);
				class28_0 = class28_1;
				Class31 @class = (class31_0 = class31_1);
				byte[] array = (byte_0 = byte_1);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException5(exception, this, reportSender1_1, byte_1, class31_1, class28_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			byte[] bytes = default(byte[]);
			byte[] array = default(byte[]);
			Class27 @class = default(Class27);
			string text = default(string);
			try
			{
				if (string_0 == Strings.Get(1481))
				{
					reportSender1_0.InvokeSendingReportFeedback(SendingReportStep1.Transfering);
					bytes = Encoding.UTF8.GetBytes(Strings.Get(1486));
					array = new byte[bytes.Length + byte_0.Length];
					Array.Copy(bytes, array, bytes.Length);
					Array.Copy(byte_0, 0, array, bytes.Length, byte_0.Length);
					@class = new Class27(reportSender1_0);
					class31_0.method_2(array, class28_0.method_2(), class28_0.method_1(), class28_0.method_0(), @class.method_0);
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

	private sealed class Class27
	{
		private readonly ReportSender1 reportSender1_0;

		public bool bool_0;

		public Class27(ReportSender1 reportSender1_1)
		{
			try
			{
				reportSender1_0 = reportSender1_1;
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
				if (string_0.StartsWith(Strings.Get(1539)))
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

	internal sealed class Class28
	{
		public static Class28 class28_0;

		private readonly string string_0;

		internal string string_1;

		internal string string_2;

		public Class28(string string_3, string string_4, string string_5)
		{
			try
			{
				string_0 = string_3;
				string text = (string_2 = string_5);
				string text2 = (string_1 = string_4);
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

		static Class28()
		{
			try
			{
				class28_0 = new Class28(null, null, null);
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

	internal bool method_0(byte[] byte_0, Class28 class28_0)
	{
		byte[] array = default(byte[]);
		bool flag = default(bool);
		byte[] array2 = default(byte[]);
		Class31 @class = default(Class31);
		Class26 class2 = default(Class26);
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
			array2 = Class25.smethod_0(array, Strings.Get(1106));
			if (array2 == null)
			{
				InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, Class25.string_0);
				return false;
			}
			InvokeSendingReportFeedback(SendingReportStep1.ConnectingToServer);
			@class = new Class31(Strings.Get(1432));
			if (iwebProxy_0 != null)
			{
				@class.method_0(iwebProxy_0);
			}
			class2 = new Class26(this, array2, @class, class28_0);
			@class.method_1(class2.method_0);
			return class2.bool_0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException8(exception, array, array2, @class, class2, flag, this, byte_0, class28_0);
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
