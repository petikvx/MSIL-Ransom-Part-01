using System;
using System.Net;
using System.Text;
using System.Threading;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender1
{
	private sealed class Class24
	{
		private readonly ReportSender1 reportSender1_0;

		private readonly Class29 class29_0;

		private readonly Class26 class26_0;

		public bool bool_0 = true;

		internal byte[] byte_0;

		public Class24(ReportSender1 reportSender1_1, byte[] byte_1, Class29 class29_1, Class26 class26_1)
		{
			try
			{
				reportSender1_0 = reportSender1_1;
				class26_0 = class26_1;
				class29_0 = class29_1;
				byte[] array = (byte_0 = byte_1);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException5(exception_, this, reportSender1_1, byte_1, class29_1, class26_1);
				throw;
			}
		}

		public void method_0(string string_0)
		{
			byte[] bytes = default(byte[]);
			byte[] array = default(byte[]);
			Class25 @class = default(Class25);
			string text = default(string);
			try
			{
				if (string_0 == "OK")
				{
					reportSender1_0.InvokeSendingReportFeedback(SendingReportStep1.Transfering);
					bytes = Encoding.UTF8.GetBytes("{EFE03FC5-3FCE-4E9A-BCF5-31421B84CB85}");
					array = new byte[bytes.Length + byte_0.Length];
					Array.Copy(bytes, array, bytes.Length);
					Array.Copy(byte_0, 0, array, bytes.Length, byte_0.Length);
					@class = new Class25(reportSender1_0);
					class29_0.method_2(array, class26_0.EmailAddress, class26_0.AppFriendlyName, class26_0.BuildFriendlyNumber, @class.method_0);
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

	private sealed class Class25
	{
		public bool bool_0;

		internal ReportSender1 reportSender1_0;

		public Class25(ReportSender1 reportSender1_1)
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

	internal sealed class Class26
	{
		public static Class26 class26_0;

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

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

		public Class26(string string_3, string string_4, string string_5)
		{
			try
			{
				string_0 = string_3;
				string_2 = string_5;
				string_1 = string_4;
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException4(exception_, this, string_3, string_4, string_5);
				throw;
			}
		}

		static Class26()
		{
			try
			{
				class26_0 = new Class26(null, null, null);
			}
			catch (Exception exception_)
			{
				StackFrameHelper.CreateException0(exception_);
				throw;
			}
		}
	}

	private IWebProxy iwebProxy_0;

	internal byte[] byte_0;

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

	internal bool method_0(byte[] byte_1, Class26 class26_0)
	{
		byte[] object_ = default(byte[]);
		bool flag = default(bool);
		byte[] array = default(byte[]);
		Class29 @class = default(Class29);
		Class24 class2 = default(Class24);
		try
		{
			try
			{
				object_ = SimpleZip.Zip(byte_1);
			}
			catch (Exception)
			{
				InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, SimpleZip.ExceptionMessage);
				flag = false;
				return flag;
			}
			array = Class23.smethod_0(object_, "<RSAKeyValue><Modulus>5gXc02zTuw7OKY2ZyjePjoe/TQD6tlMurHOkdWWzODIqOQ7gjZ47BO6oUSTVq4iMRLbsbDnmZ/KlSsi3QPBXo2EN5L9rmwv5YjBSNH5scPSyRPPYeYMvtwJC5+KAGeXpfo8xns22Liv6wh+hXe6Kwz7aS/apz5z3ZElY0xItZss=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			if (array == null)
			{
				InvokeSendingReportFeedback(SendingReportStep1.PreparingReport, Class23.string_0);
				return false;
			}
			InvokeSendingReportFeedback(SendingReportStep1.ConnectingToServer);
			@class = new Class29("d12462a0-e7c0-5e88-a620-7499a084127e");
			if (iwebProxy_0 != null)
			{
				@class.method_0(iwebProxy_0);
			}
			class2 = new Class24(this, array, @class, class26_0);
			@class.method_1(class2.method_0);
			return class2.bool_0;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException8(exception_, object_, array, @class, class2, flag, this, byte_1, class26_0);
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
