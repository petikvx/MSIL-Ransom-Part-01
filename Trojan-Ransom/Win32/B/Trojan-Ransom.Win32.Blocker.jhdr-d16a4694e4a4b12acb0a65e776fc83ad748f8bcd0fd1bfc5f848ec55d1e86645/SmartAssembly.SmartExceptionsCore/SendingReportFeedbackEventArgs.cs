using System;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs : EventArgs
{
	private readonly string string_0 = string.Empty;

	internal SendingReportStep sendingReportStep_0;

	internal bool bool_0;

	internal string string_1 = string.Empty;

	public SendingReportStep Step => sendingReportStep_0;

	public bool Failed => bool_0;

	public string ErrorMessage => string_1;

	public string ReportID => string_0;

	internal SendingReportFeedbackEventArgs(SendingReportStep sendingReportStep_1, string string_2)
		: this(sendingReportStep_1, string_2, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs(SendingReportStep sendingReportStep_1, string string_2, string string_3)
	{
		SendingReportStep sendingReportStep = (sendingReportStep_0 = sendingReportStep_1);
		bool flag = (bool_0 = string_2 != null && string_2.Length > 0);
		string text = (string_1 = string_2);
		string_0 = string_3;
	}
}
