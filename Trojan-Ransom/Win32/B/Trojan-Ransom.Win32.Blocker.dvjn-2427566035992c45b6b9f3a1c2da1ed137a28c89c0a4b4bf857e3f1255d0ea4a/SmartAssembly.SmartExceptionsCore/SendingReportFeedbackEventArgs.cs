using System;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs : EventArgs
{
	private SendingReportStep step;

	private readonly bool failed;

	private readonly string errorMessage;

	private readonly string reportID;

	public SendingReportStep Step => step;

	public bool Failed => failed;

	public string ErrorMessage => errorMessage;

	public string ReportID => reportID;

	internal SendingReportFeedbackEventArgs(SendingReportStep step)
	{
		Class2.l4t8M9wzGUypc();
		this._002Ector(step, string.Empty);
	}

	internal SendingReportFeedbackEventArgs(SendingReportStep step, string errorMessage)
	{
		Class2.l4t8M9wzGUypc();
		this._002Ector(step, errorMessage, string.Empty);
	}

	internal SendingReportFeedbackEventArgs(SendingReportStep step, string errorMessage, string reportId)
	{
		Class2.l4t8M9wzGUypc();
		this.errorMessage = string.Empty;
		reportID = string.Empty;
		base._002Ector();
		this.step = step;
		failed = errorMessage != null && errorMessage.Length > 0;
		this.errorMessage = errorMessage;
		reportID = reportId;
	}
}
