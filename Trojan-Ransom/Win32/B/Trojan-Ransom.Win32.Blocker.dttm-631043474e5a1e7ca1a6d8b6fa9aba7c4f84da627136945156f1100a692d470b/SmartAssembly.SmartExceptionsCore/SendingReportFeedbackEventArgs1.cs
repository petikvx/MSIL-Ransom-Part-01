using System;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs1 : EventArgs
{
	private SendingReportStep1 sendingReportStep1_0;

	private readonly string string_0 = string.Empty;

	internal bool bool_0;

	internal string string_1 = string.Empty;

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
			string text = (string_1 = string_2);
			string_0 = string_3;
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException4(exception_, this, sendingReportStep1_1, string_2, string_3);
			throw;
		}
	}
}
