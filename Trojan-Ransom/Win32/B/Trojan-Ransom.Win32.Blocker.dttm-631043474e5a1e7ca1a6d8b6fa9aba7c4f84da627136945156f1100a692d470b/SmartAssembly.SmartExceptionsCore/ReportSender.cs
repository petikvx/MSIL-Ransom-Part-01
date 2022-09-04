using System;
using System.Net;
using System.Text;
using System.Threading;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender
{
	private sealed class Class9
	{
		private readonly byte[] byte_0;

		private readonly Class11 class11_0;

		public bool bool_0 = true;

		internal ReportSender reportSender_0;

		internal Class15 class15_0;

		public Class9(ReportSender reportSender_1, byte[] byte_1, Class15 class15_1, Class11 class11_1)
		{
			ReportSender reportSender = (reportSender_0 = reportSender_1);
			class11_0 = class11_1;
			Class15 @class = (class15_0 = class15_1);
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				reportSender_0.InvokeSendingReportFeedback(SendingReportStep.Transfering);
				byte[] bytes = Encoding.UTF8.GetBytes("{012EA29B-015F-428D-8911-D35A59441944}");
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class10 @class = new Class10(reportSender_0);
				class15_0.method_2(destinationArray, class11_0.EmailAddress, class11_0.AppFriendlyName, class11_0.BuildFriendlyNumber, @class.method_0);
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

	private sealed class Class10
	{
		private readonly ReportSender reportSender_0;

		public bool bool_0;

		public Class10(ReportSender reportSender_1)
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

	internal sealed class Class11
	{
		public static Class11 class11_0 = new Class11(null, null, null);

		internal string string_0;

		internal string string_1;

		internal string string_2;

		public string BuildFriendlyNumber => string_2;

		public string AppFriendlyName => string_1;

		public string EmailAddress => string_0;

		public Class11(string string_3, string string_4, string string_5)
		{
			string text = (string_0 = string_3);
			string text2 = (string_2 = string_5);
			string text3 = (string_1 = string_4);
		}
	}

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
	}

	public void SetProxy(IWebProxy iwebProxy_1)
	{
		IWebProxy webProxy = (iwebProxy_0 = iwebProxy_1);
	}

	internal bool method_0(byte[] byte_0, Class11 class11_0)
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
		byte[] array = Class7.smethod_0(byte_, "<RSAKeyValue><Modulus>w9O+Ad5rDch6xojhSngoya/UMjuMhiDsWHhjHsoMf4qkz36aWk8Y+XPrbayALHIO13J5hQ8lj0oL1/4AEarBNBGrFz3I3TZe4DovRL8RlDTx7/3ZjGv1VDs+4pBBdybj+4TlucEUtaiCjsDNS9VQSIaExrqlCIsnVYGomJQFZhU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport, Class7.string_0);
			return false;
		}
		InvokeSendingReportFeedback(SendingReportStep.ConnectingToServer);
		Class15 @class = new Class15("ded353a0-d5a9-370b-c782-4c5fe54c8f0b");
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class9 class2 = new Class9(this, array, @class, class11_0);
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
