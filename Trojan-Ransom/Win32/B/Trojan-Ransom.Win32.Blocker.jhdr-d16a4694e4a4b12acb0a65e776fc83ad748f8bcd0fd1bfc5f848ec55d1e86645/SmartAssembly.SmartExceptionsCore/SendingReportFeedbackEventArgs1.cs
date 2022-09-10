using System;
using System.Runtime.InteropServices;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs1 : EventArgs
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 48446)]
	private struct Struct26
	{
	}

	private SendingReportStep1 sendingReportStep1_0;

	private readonly string string_0 = string.Empty;

	internal static byte byte_0/* Not supported: data(00) */;

	internal bool bool_0;

	internal string string_1 = string.Empty;

	public SendingReportStep1 Step
	{
		get
		{
			try
			{
				return sendingReportStep1_0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	public bool Failed
	{
		get
		{
			try
			{
				return bool_0;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	public string ErrorMessage
	{
		get
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
	}

	public string ReportID
	{
		get
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
	}

	internal SendingReportFeedbackEventArgs1(SendingReportStep1 sendingReportStep1_1, string string_2)
		: this(sendingReportStep1_1, string_2, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs1(SendingReportStep1 sendingReportStep1_1, string string_2, string string_3)
	{
		try
		{
			sendingReportStep1_0 = sendingReportStep1_1;
			bool flag = (bool_0 = string_2 != null && string_2.Length > 0);
			string_0 = string_2;
			string text = (string_1 = string_3);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, this, sendingReportStep1_1, string_2, string_3);
			throw;
		}
	}
}
