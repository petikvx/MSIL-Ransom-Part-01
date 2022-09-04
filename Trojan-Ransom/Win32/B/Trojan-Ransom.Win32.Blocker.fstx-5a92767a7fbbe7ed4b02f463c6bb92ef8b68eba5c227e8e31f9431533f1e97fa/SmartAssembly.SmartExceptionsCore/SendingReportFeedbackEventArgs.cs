using System;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs : EventArgs
{
	private SendingReportStep step;

	private readonly bool failed;

	private readonly string errorMessage = string.Empty;

	private readonly string reportID = string.Empty;

	public SendingReportStep Step => step;

	public bool Failed => failed;

	public string ErrorMessage => errorMessage;

	internal SendingReportFeedbackEventArgs(SendingReportStep sendingReportStep_0, string string_0)
		: this(sendingReportStep_0, string_0, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs(SendingReportStep sendingReportStep_0, string string_0, string string_1)
	{
		step = sendingReportStep_0;
		failed = string_0 != null && string_0.Length > 0;
		errorMessage = string_0;
		reportID = string_1;
	}
}
