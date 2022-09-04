using System;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs1 : EventArgs
{
	private SendingReportStep1 step;

	private readonly bool failed;

	private readonly string errorMessage = string.Empty;

	private readonly string reportID = string.Empty;

	public SendingReportStep1 Step => step;

	public bool Failed => failed;

	public string ErrorMessage => errorMessage;

	public string ReportID => reportID;

	internal SendingReportFeedbackEventArgs1(SendingReportStep1 step)
		: this(step, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs1(SendingReportStep1 step, string errorMessage)
		: this(step, errorMessage, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs1(SendingReportStep1 step, string errorMessage, string reportId)
	{
		this.step = step;
		failed = errorMessage != null && errorMessage.Length > 0;
		this.errorMessage = errorMessage;
		reportID = reportId;
	}
}
