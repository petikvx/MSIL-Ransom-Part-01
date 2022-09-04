using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using SmartAssembly.Zip;
using ns1;
using ns3;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportSender
{
	private sealed class Class8
	{
		[NonSerialized]
		internal static GetString getString_0;

		private readonly ReportSender reportSender_0;

		private readonly byte[] byte_0;

		private readonly Class13 class13_0;

		private readonly Class10 class10_0;

		public bool bool_0 = true;

		static Class8()
		{
			Strings.CreateGetStringDelegate(typeof(Class8));
		}

		public Class8(ReportSender reportSender_1, byte[] byte_1, Class13 class13_1, Class10 class10_1)
		{
			reportSender_0 = reportSender_1;
			class10_0 = class10_1;
			class13_0 = class13_1;
			byte_0 = byte_1;
		}

		public void method_0(string string_0)
		{
			if (string_0 == getString_0(1194))
			{
				reportSender_0.InvokeSendingReportFeedback(SendingReportStep.Transfering);
				byte[] bytes = Encoding.UTF8.GetBytes(getString_0(1199));
				byte[] destinationArray = new byte[bytes.Length + byte_0.Length];
				Array.Copy(bytes, destinationArray, bytes.Length);
				Array.Copy(byte_0, 0, destinationArray, bytes.Length, byte_0.Length);
				Class9 @class = new Class9(reportSender_0);
				class13_0.method_2(destinationArray, class10_0.method_2(), class10_0.method_1(), class10_0.method_0(), @class.method_0);
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

	private sealed class Class9
	{
		[NonSerialized]
		internal static GetString getString_0;

		private readonly ReportSender reportSender_0;

		public bool bool_0;

		static Class9()
		{
			Strings.CreateGetStringDelegate(typeof(Class9));
		}

		public Class9(ReportSender reportSender_1)
		{
			reportSender_0 = reportSender_1;
		}

		public void method_0(string string_0)
		{
			if (string_0.StartsWith(getString_0(1258)))
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

	internal sealed class Class10
	{
		public static Class10 class10_0 = new Class10(null, null, null);

		private readonly string string_0;

		private readonly string string_1;

		private readonly string string_2;

		public Class10(string string_3, string string_4, string string_5)
		{
			string_0 = string_3;
			string_2 = string_5;
			string_1 = string_4;
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

	[NonSerialized]
	internal static GetString getString_0;

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
	}

	static ReportSender()
	{
		Strings.CreateGetStringDelegate(typeof(ReportSender));
	}

	public void SetProxy(IWebProxy iwebProxy_1)
	{
		iwebProxy_0 = iwebProxy_1;
	}

	internal bool method_0(byte[] byte_0, Class10 class10_0)
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
		byte[] array = Class6.smethod_0(byte_, getString_0(816));
		if (array == null)
		{
			InvokeSendingReportFeedback(SendingReportStep.PreparingReport, Class6.string_0);
			return false;
		}
		InvokeSendingReportFeedback(SendingReportStep.ConnectingToServer);
		Class13 @class = new Class13(getString_0(1142));
		if (iwebProxy_0 != null)
		{
			@class.method_0(iwebProxy_0);
		}
		Class8 class2 = new Class8(this, array, @class, class10_0);
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
