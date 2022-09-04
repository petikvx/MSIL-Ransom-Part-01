using System;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs : EventArgs
{
	private SendingReportStep sendingReportStep_0;

	private readonly string string_0 = string.Empty;

	internal bool bool_0;

	internal string string_1 = string.Empty;

	internal SendingReportFeedbackEventArgs(SendingReportStep sendingReportStep_1, string string_2)
		: this(sendingReportStep_1, string_2, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs(SendingReportStep sendingReportStep_1, string string_2, string string_3)
	{
		sendingReportStep_0 = sendingReportStep_1;
		bool flag = (bool_0 = string_2 != null && string_2.Length > 0);
		string_0 = string_2;
		string text = (string_1 = string_3);
	}
}
