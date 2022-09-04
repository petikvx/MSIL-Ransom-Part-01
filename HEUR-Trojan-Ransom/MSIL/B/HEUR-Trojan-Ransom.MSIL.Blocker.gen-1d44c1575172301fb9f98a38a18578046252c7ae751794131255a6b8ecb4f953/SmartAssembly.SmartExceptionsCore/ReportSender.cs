using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender
{
	private sealed class Class14
	{
		private readonly byte[] byte_0;

		private readonly Class21 class21_0;

		private readonly Class16 class16_0;

		public bool bool_0 = true;

		internal ReportSender reportSender_0;

		public Class14(ReportSender reportSender_1, byte[] byte_1, Class21 class21_1, Class16 class16_1)
		{
			ReportSender reportSender = (reportSender_0 = reportSender_1);
			class16_0 = class16_1;
			class21_0 = class21_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				reportSender_0.InvokeSendingReportFeedback(SendingReportStep.Transfering);
				byte[] bytes = Encoding.UTF8.GetBytes("{5073F953-287E-4137-ADF6-D4C5C7821FA6}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class15 @class = new Class15(reportSender_0);
				class21_0.method_2(destinationArray, class16_0.method_2(), class16_0.method_1(), class16_0.method_0(), @class.method_0);
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

		public Class16(string string_3, string string_4, string string_5)
		{
			string text = (string_1 = string_3);
			string text2 = (string_2 = string_5);
			string_0 = string_4;
		}

		[SpecialName]
		public string method_0()
		{
			return string_2;
		}

		[SpecialName]
		public string method_1()
		{
			return string_0;
		}

		[SpecialName]
		public string method_2()
		{
			return string_1;
		}
	}

	protected const string AssemblyID = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	private SendingReportFeedbackEventHandler sendingReportFeedbackEventHandler_0;

	internal IWebProxy iwebProxy_0;

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
		IWebProxy webProxy = (iwebProxy_0 = proxy);
	}

	internal bool method_0(byte[] byte_0, Class16 class16_0)
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
		byte[] array = Class12.smethod_0(byte_, "<RSAKeyValue><Modulus>8ffGzqH8cUgPLkoH3ibGxj6nE0hNZGkVODIrZjCJm6mfxDpxs499ievE/14TSnD/fIR+53p6oEhKA+UF0zNLpe1KdUs9Iol7A3oItdO76YE/SfVE8dlaMnFYKlXiCKm0+ymC/k9lFG/4Ynt/jBQPc9jSS7nMszq5SLB6n4PbLXU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport, Class12.string_0);
			return false;
		}
		InvokeSendingReportFeedback(SendingReportStep.ConnectingToServer);
		Class21 @class = new Class21("a9b48f91-4f96-f20e-0538-d1460b5d526e");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class14 class2 = new Class14(this, array, @class, class16_0);
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
