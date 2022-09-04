using System;

namespace SmartAssembly.SmartExceptionsCore;

public class SendingReportFeedbackEventArgs3 : EventArgs
{
	private SendingReportStep3 step;

	private readonly bool failed;

	private readonly string errorMessage = string.Empty;

	private readonly string reportID = string.Empty;

	public SendingReportStep3 Step
	{
		get
		{
			try
			{
				return step;
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
				return failed;
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
				return errorMessage;
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
				return reportID;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
	}

	internal SendingReportFeedbackEventArgs3(SendingReportStep3 step)
		: this(step, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs3(SendingReportStep3 step, string errorMessage)
		: this(step, errorMessage, string.Empty)
	{
	}

	internal SendingReportFeedbackEventArgs3(SendingReportStep3 step, string errorMessage, string reportId)
	{
		try
		{
			this.step = step;
			failed = errorMessage != null && errorMessage.Length > 0;
			this.errorMessage = errorMessage;
			reportID = reportId;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, this, step, errorMessage, reportId);
			throw;
		}
	}
}
