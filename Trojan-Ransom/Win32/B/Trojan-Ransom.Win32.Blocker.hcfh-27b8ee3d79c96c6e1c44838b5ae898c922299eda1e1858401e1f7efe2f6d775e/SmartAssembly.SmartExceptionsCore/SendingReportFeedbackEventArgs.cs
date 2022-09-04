using System;

namespace SmartAssembly.SmartExceptionsCore;

public sealed class SendingReportFeedbackEventArgs : EventArgs
{
	private SendingReportStep step;

	private readonly bool failed;

	private readonly string errorMessage = string.Empty;

	private readonly string reportID = string.Empty;

	public SendingReportStep Step => step;

	public bool Failed => failed;

	public string ErrorMessage => errorMessage;

	public string ReportID => reportID;

	internal SendingReportFeedbackEventArgs(SendingReportStep step)
		: this(step, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs(SendingReportStep step, string errorMessage)
		: this(step, errorMessage, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs(SendingReportStep step, string errorMessage, string reportId)
	{
		this.step = step;
		failed = errorMessage != null && errorMessage.Length > 0;
		this.errorMessage = errorMessage;
		reportID = reportId;
	}
}
