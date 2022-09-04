using System;
using System.Net;
using System.Text;
using System.Threading;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender1
{
	private sealed class Class19
	{
		private readonly byte[] byte_0;

		private readonly Class21 class21_0;

		public bool bool_0 = true;

		internal ReportSender1 reportSender1_0;

		internal Class24 class24_0;

		public Class19(ReportSender1 reportSender1_1, byte[] byte_1, Class24 class24_1, Class21 class21_1)
		{
			try
			{
				ReportSender1 reportSender = (reportSender1_0 = reportSender1_1);
				class21_0 = class21_1;
				Class24 @class = (class24_0 = class24_1);
				byte_0 = byte_1;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException5(exception_, this, reportSender1_1, byte_1, class24_1, class21_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			byte[] bytes = default(byte[]);
			byte[] array = default(byte[]);
			Class20 @class = default(Class20);
			string text = default(string);
			try
			{
				if (string_0 == "OK")
				{
					reportSender1_0.InvokeSendingReportFeedback(SendingReportStep1.Transfering);
					bytes = Encoding.UTF8.GetBytes("{012EA29B-015F-428D-8911-D35A59441944}");
					array = new byte[bytes.Length + byte_0.Length];
					Array.Copy(bytes, array, bytes.Length);
					Array.Copy(byte_0, 0, array, bytes.Length, byte_0.Length);
					@class = new Class20(reportSender1_0);
					class24_0.method_2(array, class21_0.EmailAddress, class21_0.AppFriendlyName, class21_0.BuildFriendlyNumber, @class.method_0);
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
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException6(exception_, bytes, array, @class, text, this, string_0);
				throw;
			}
		}
	}

	private sealed class Class20
	{
		public bool bool_0;

		internal ReportSender1 reportSender1_0;

		public Class20(ReportSender1 reportSender1_1)
		{
			try
			{
				ReportSender1 reportSender = (reportSender1_0 = reportSender1_1);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException2(exception_, this, reportSender1_1);
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
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException2(exception_, this, string_0);
				throw;
			}
		}
	}

	internal sealed class Class21
	{
		public static Class21 class21_0;

		private readonly string string_0;

		private readonly string string_1;

		internal string string_2;

		public string BuildFriendlyNumber
		{
			get
			{
				try
				{
					return string_2;
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException1(exception_, this);
					throw;
				}
			}
		}

		public string AppFriendlyName
		{
			get
			{
				try
				{
					return string_1;
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException1(exception_, this);
					throw;
				}
			}
		}

		public string EmailAddress
		{
			get
			{
				try
				{
					return string_0;
				}
				catch (Exception exception_)
				{
					StackFrameHelper.CreateException1(exception_, this);
					throw;
				}
			}
		}

		public Class21(string string_3, string string_4, string string_5)
		{
			try
			{
				string_0 = string_3;
				string text = (string_2 = string_5);
				string_1 = string_4;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException4(exception_, this, string_3, string_4, string_5);
				throw;
			}
		}

		static Class21()
		{
			try
			{
				class21_0 = new Class21(null, null, null);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException0(exception_);
				throw;
			}
		}
	}

	internal IWebProxy iwebProxy_0;

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
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException5(exception_, sendingReportFeedbackEventHandler, sendingReportFeedbackEventHandler2, sendingReportFeedbackEventHandler3, this, value);
				throw;
			}
		}
	}

	internal bool method_0(byte[] byte_0, Class21 class21_0)
	{
		byte[] array = default(byte[]);
		bool flag = default(bool);
		byte[] array2 = default(byte[]);
		Class24 @class = default(Class24);
		Class19 class2 = default(Class19);
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
			array2 = Class18.smethod_0(array, "<RSAKeyValue><Modulus>w9O+Ad5rDch6xojhSngoya/UMjuMhiDsWHhjHsoMf4qkz36aWk8Y+XPrbayALHIO13J5hQ8lj0oL1/4AEarBNBGrFz3I3TZe4DovRL8RlDTx7/3ZjGv1VDs+4pBBdybj+4TlucEUtaiCjsDNS9VQSIaExrqlCIsnVYGomJQFZhU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			if (array2 == null)
			{
				InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, Class18.string_0);
				return false;
			}
			InvokeSendingReportFeedback(SendingReportStep1.ConnectingToServer);
			@class = new Class24("ded353a0-d5a9-370b-c782-4c5fe54c8f0b");
			if (iwebProxy_0 != null)
			{
				@class.method_0(iwebProxy_0);
			}
			class2 = new Class19(this, array2, @class, class21_0);
			@class.method_1(class2.method_0);
			return class2.bool_0;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException8(exception_, array, array2, @class, class2, flag, this, byte_0, class21_0);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 sendingReportStep1_0, string string_0, string string_1)
	{
		SendingReportFeedbackEventHandler1 sendingReportFeedbackEventHandler = default(SendingReportFeedbackEventHandler1);
		try
		{
			sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler1_0;
			sendingReportFeedbackEventHandler?.Invoke(this, new SendingReportFeedbackEventArgs1(sendingReportStep1_0, string_0, string_1));
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException5(exception_, sendingReportFeedbackEventHandler, this, sendingReportStep1_0, string_0, string_1);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 sendingReportStep1_0, string string_0)
	{
		try
		{
			InvokeSendingReportFeedback(sendingReportStep1_0, string_0, string.Empty);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException3(exception_, this, sendingReportStep1_0, string_0);
			throw;
		}
	}

	protected void InvokeSendingReportFeedback(SendingReportStep1 sendingReportStep1_0)
	{
		try
		{
			InvokeSendingReportFeedback(sendingReportStep1_0, string.Empty);
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException2(exception_, this, sendingReportStep1_0);
			throw;
		}
	}
}
