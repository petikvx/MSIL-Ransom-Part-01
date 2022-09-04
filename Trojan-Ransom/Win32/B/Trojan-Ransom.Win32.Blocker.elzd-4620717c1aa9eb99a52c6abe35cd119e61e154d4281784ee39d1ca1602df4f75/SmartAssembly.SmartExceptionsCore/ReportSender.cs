using System;
using System.Net;
using System.Text;
using System.Threading;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender
{
	private sealed class Class14
	{
		private readonly Class20 class20_0;

		private readonly Class16 class16_0;

		public bool bool_0 = true;

		internal ReportSender reportSender_0;

		internal byte[] byte_0;

		public Class14(ReportSender reportSender_1, byte[] byte_1, Class20 class20_1, Class16 class16_1)
		{
			ReportSender reportSender = (reportSender_0 = reportSender_1);
			class16_0 = class16_1;
			class20_0 = class20_1;
			byte[] array = (byte_0 = byte_1);
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				reportSender_0.InvokeSendingReportFeedback(SendingReportStep.Transfering);
				byte[] bytes = Encoding.UTF8.GetBytes("{EFE03FC5-3FCE-4E9A-BCF5-31421B84CB85}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class15 @class = new Class15(reportSender_0);
				class20_0.method_2(destinationArray, class16_0.EmailAddress, class16_0.AppFriendlyName, class16_0.BuildFriendlyNumber, @class.method_0);
				bool_0 = @class.bool_0;
			}
			else
			{
				if (reportSender_0.sendingReportFeedbackEventHandler_0 != null)
				{
					reportSender_0.sendingReportFeedbackEventHandler_0(this, new SendingReportFeedbackEventArgs(SendingReportStep.ConnectingToServer, string_0));
				}
				bool_0 = false;
			}
		}
	}

	private sealed class Class15
	{
		private readonly ReportSender reportSender_0;

		public bool bool_0;

		public Class15(ReportSender reportSender_1)
		{
			reportSender_0 = reportSender_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith("ERR"))
			{
				reportSender_0.InvokeSendingReportFeedback(SendingReportStep.Transfering, string_0);
				bool_0 = false;
			}
			else
			{
				reportSender_0.InvokeSendingReportFeedback(SendingReportStep.Finished, string.Empty, string_0);
				bool_0 = true;
			}
		}
	}

	internal sealed class Class16
	{
		public static Class16 class16_0 = new Class16(null, null, null);

		private readonly string string_0;

		internal string string_1;

		internal string string_2;

		public string BuildFriendlyNumber => string_0;

		public string AppFriendlyName => string_2;

		public string EmailAddress => string_1;

		public Class16(string string_3, string string_4, string string_5)
		{
			string text = (string_1 = string_3);
			string_0 = string_5;
			string text2 = (string_2 = string_4);
		}
	}

	private IWebProxy iwebProxy_0;

	internal byte[] byte_0;

	internal FatalExceptionEventHandler fatalExceptionEventHandler_0;

	internal EventHandler eventHandler_0;

	internal SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler_0;

	public event SendingReportFeedbackEventHandler SendingReportFeedback
	{
		add
		{
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler_0;
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler2;
			do
			{
				sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
				SendingReportFeedbackEventHandler value2 = (SendingReportFeedbackEventHandler)Delegate.Combine(sendingReportFeedbackEventHandler2, value);
				sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler_0, value2, sendingReportFeedbackEventHandler2);
			}
			while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
		}
	}

	public void SetProxy(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	internal bool method_0(byte[] byte_1, Class16 class16_0)
	{
		byte[] array;
		try
		{
			array = SimpleZip.Zip(byte_1);
		}
		catch (Exception)
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport, SimpleZip.ExceptionMessage);
			return false;
		}
		byte[] array2 = Class12.smethod_0(array, "<RSAKeyValue><Modulus>5gXc02zTuw7OKY2ZyjePjoe/TQD6tlMurHOkdWWzODIqOQ7gjZ47BO6oUSTVq4iMRLbsbDnmZ/KlSsi3QPBXo2EN5L9rmwv5YjBSNH5scPSyRPPYeYMvtwJC5+KAGeXpfo8xns22Liv6wh+hXe6Kwz7aS/apz5z3ZElY0xItZss=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array2 == null)
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport, Class12.string_0);
			return false;
		}
		InvokeSendingReportFeedback(SendingReportStep.ConnectingToServer);
		Class20 @class = new Class20("d12462a0-e7c0-5e88-a620-7499a084127e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class14 class2 = new Class14(this, array2, @class, class16_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
	}

	protected void InvokeSendingReportFeedback(SendingReportStep sendingReportStep_0, string string_0, string string_1)
	{
		sendingReportFeedbackEventHandler_0?.Invoke(this, new SendingReportFeedbackEventArgs(sendingReportStep_0, string_0, string_1));
	}

	protected void InvokeSendingReportFeedback(SendingReportStep sendingReportStep_0, string string_0)
	{
		InvokeSendingReportFeedback(sendingReportStep_0, string_0, string.Empty);
	}

	protected void InvokeSendingReportFeedback(SendingReportStep sendingReportStep_0)
	{
		InvokeSendingReportFeedback(sendingReportStep_0, string.Empty);
	}
}
