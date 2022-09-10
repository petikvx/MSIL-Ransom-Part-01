using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using SmartAssembly.StringsEncoding;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender
{
	private sealed class Class15
	{
		private readonly ReportSender reportSender_0;

		private readonly byte[] byte_0;

		private readonly Class22 class22_0;

		private readonly Class17 class17_0;

		public bool bool_0 = true;

		public Class15(ReportSender reportSender_1, byte[] byte_1, Class22 class22_1, Class17 class17_1)
		{
			reportSender_0 = reportSender_1;
			class17_0 = class17_1;
			class22_0 = class22_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == Strings.Get(1481))
			{
				reportSender_0.InvokeSendingReportFeedback(SendingReportStep.Transfering);
				byte[] bytes = Encoding.UTF8.GetBytes(Strings.Get(1486));
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class16 @class = new Class16(reportSender_0);
				class22_0.method_2(destinationArray, class17_0.method_2(), class17_0.method_1(), class17_0.method_0(), @class.method_0);
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

	private sealed class Class16
	{
		public bool bool_0;

		internal ReportSender reportSender_0;

		public Class16(ReportSender reportSender_1)
		{
			ReportSender reportSender = (reportSender_0 = reportSender_1);
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith(Strings.Get(1539)))
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

	internal sealed class Class17
	{
		public static Class17 class17_0 = new Class17(null, null, null);

		private readonly string string_0;

		internal string string_1;

		internal string string_2;

		public Class17(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string text = (string_2 = string_5);
			string text2 = (string_1 = string_4);
		}

		[SpecialName]
		public string method_0()
		{
			return string_2;
		}

		[SpecialName]
		public string method_1()
		{
			return string_1;
		}

		[SpecialName]
		public string method_2()
		{
			return string_0;
		}
	}

	protected const string AssemblyID = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	private IWebProxy iwebProxy_0;

	private SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler_0;

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
		remove
		{
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler = sendingReportFeedbackEventHandler_0;
			SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler2;
			do
			{
				sendingReportFeedbackEventHandler2 = sendingReportFeedbackEventHandler;
				SendingReportFeedbackEventHandler value2 = (SendingReportFeedbackEventHandler)Delegate.Remove(sendingReportFeedbackEventHandler2, value);
				sendingReportFeedbackEventHandler = Interlocked.CompareExchange(ref sendingReportFeedbackEventHandler_0, value2, sendingReportFeedbackEventHandler2);
			}
			while ((object)sendingReportFeedbackEventHandler != sendingReportFeedbackEventHandler2);
		}
	}

	public void SetProxy(IWebProxy proxy)
	{
		iwebProxy_0 = proxy;
	}

	internal bool method_0(byte[] byte_0, Class17 class17_0)
	{
		byte[] byte_;
		try
		{
			byte_ = SimpleZip.Zip(byte_0);
		}
		catch (Exception)
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport, SimpleZip.ExceptionMessage);
			return false;
		}
		byte[] array = Class13.smethod_0(byte_, Strings.Get(1106));
		if (array == null)
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport, Class13.string_0);
			return false;
		}
		InvokeSendingReportFeedback(SendingReportStep.ConnectingToServer);
		Class22 @class = new Class22(Strings.Get(1432));
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class15 class2 = new Class15(this, array, @class, class17_0);
		@class.method_1(class2.method_0);
		return class2.bool_0;
	}

	protected void InvokeSendingReportFeedback(SendingReportStep step, string errorMessage, string reportId)
	{
		sendingReportFeedbackEventHandler_0?.Invoke(this, new SendingReportFeedbackEventArgs(step, errorMessage, reportId));
	}

	protected void InvokeSendingReportFeedback(SendingReportStep step, string errorMessage)
	{
		InvokeSendingReportFeedback(step, errorMessage, string.Empty);
	}

	protected void InvokeSendingReportFeedback(SendingReportStep step)
	{
		InvokeSendingReportFeedback(step, string.Empty);
	}
}
