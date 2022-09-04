using System;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs2 : EventArgs
{
	private SendingReportStep2 step;

	private readonly bool failed;

	private readonly string errorMessage = string.Empty;

	private readonly string reportID = string.Empty;

	public SendingReportStep2 Step => step;

	public bool Failed => failed;

	public string ErrorMessage => errorMessage;

	public string ReportID => reportID;

	internal SendingReportFeedbackEventArgs2(SendingReportStep2 step)
		: this(step, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs2(SendingReportStep2 step, string errorMessage)
		: this(step, errorMessage, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs2(SendingReportStep2 step, string errorMessage, string reportId)
	{
		this.step = step;
		failed = errorMessage != null && errorMessage.Length > 0;
		this.errorMessage = errorMessage;
		reportID = reportId;
	}
}
