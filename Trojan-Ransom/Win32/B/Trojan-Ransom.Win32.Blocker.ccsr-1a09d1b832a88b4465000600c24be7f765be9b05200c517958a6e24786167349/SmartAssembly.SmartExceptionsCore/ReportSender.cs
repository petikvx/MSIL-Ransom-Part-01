using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender
{
	private sealed class Class15
	{
		private readonly Class17 class17_0;

		public bool bool_0 = true;

		internal ReportSender reportSender_0;

		internal byte[] byte_0;

		internal Class22 class22_0;

		public Class15(ReportSender reportSender_1, byte[] byte_1, Class22 class22_1, Class17 class17_1)
		{
			ReportSender reportSender = (reportSender_0 = reportSender_1);
			class17_0 = class17_1;
			Class22 @class = (class22_0 = class22_1);
			byte[] array = (byte_0 = byte_1);
		}

		public void method_0(string string_0)
		{
			if (string_0 == "OK")
			{
				reportSender_0.InvokeSendingReportFeedback(SendingReportStep.Transfering);
				byte[] array = Win32.smethod_12(Class20.smethod_2(865, 783), "{E8999F69-FF1B-4846-9283-897940EB0660}", 153, 247);
				byte[] array2 = new byte[array.Length + byte_0.Length];
				Array.Copy(array, array2, array.Length);
				SendingReportFeedbackEventArgs.smethod_0(byte_0, 0, array2, array.Length, byte_0.Length, 776, 801);
				Class16 @class = new Class16(reportSender_0);
				class22_0.method_2(array2, class17_0.method_2(), class17_0.method_1(), class17_0.method_0(), @class.method_0);
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

		static Class15()
		{
			DESCryptoIndirector.smethod_0();
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
			if (Win32.smethod_9(string_0, "ERR", 120, 96))
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

		static Class16()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	internal sealed class Class17
	{
		public static Class17 class17_0;

		internal string string_0;

		internal string string_1;

		internal string string_2;

		public Class17(string string_3, string string_4, string string_5)
		{
			string text = (string_0 = string_3);
			string text2 = (string_2 = string_5);
			string text3 = (string_1 = string_4);
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

		static Class17()
		{
			DESCryptoIndirector.smethod_0();
			class17_0 = new Class17(null, null, null);
		}
	}

	protected const string AssemblyID = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	internal IWebProxy iwebProxy_0;

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
				SendingReportFeedbackEventHandler value2 = (SendingReportFeedbackEventHandler)Class18.smethod_0(sendingReportFeedbackEventHandler2, value, 422, 398);
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
		byte[] array = Class13.smethod_0(byte_, "<RSAKeyValue><Modulus>znwYeoTG6J3QopcRcVswJImI+sp841M9VIxjD0lwpQSIUbCGhs7GlMCO0wcXiv0A4XdWnvGHlxBCVBqx89h2hXKJ6VXiOgcxb17pgdTbMMqlj0hezKhZRm93xjdaMR7DiqWlfEot945SsraToAkIcII0lEug/xhK9gQuHLj4O0E=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport, Class13.string_0);
			return false;
		}
		InvokeSendingReportFeedback(SendingReportStep.ConnectingToServer);
		Class22 @class = new Class22("d98c1dd4-008f-04b2-e980-0998ecf8427e");
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

	static ReportSender()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static string smethod_0(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 99:
				return string_0 + string_1;
			case 100:
				return Path.Combine(string_0, string_1);
			}
		}
	}

	internal static int smethod_1(ref DateTime dateTime_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 73:
				return dateTime_0.Year;
			}
		}
	}
}
