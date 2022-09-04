using System;
using System.IO;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportExceptionEventArgs : EventArgs
{
	private ErrorReportSender m_ReportSender;

	private Exception exception;

	private bool canDebug;

	private bool canSendReport = true;

	private bool showContinueCheckBox = true;

	private bool tryToContinue;

	public Exception Exception => exception;

	public bool CanDebug => canDebug;

	public bool CanSendReport => canSendReport;

	public bool ShowContinueCheckbox => showContinueCheckBox;

	public bool TryToContinue
	{
		get
		{
			return tryToContinue;
		}
		set
		{
			tryToContinue = value;
		}
	}

	internal void SetShowContinueCheckBox(bool bool_0)
	{
		showContinueCheckBox = bool_0;
	}

	internal void EnableDebug()
	{
		canDebug = true;
	}

	public void LaunchDebugger()
	{
		if (canDebug)
		{
			m_ReportSender.LaunchDebugger();
		}
	}

	public bool SaveEncryptedReport(string string_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return m_ReportSender.SaveEncryptedReport(string_0);
	}

	public bool SendReport()
	{
		if (!canSendReport)
		{
			return false;
		}
		return m_ReportSender.SendReport();
	}

	internal ReportExceptionEventArgs(ErrorReportSender errorReportSender_0, Exception exception_0)
	{
		m_ReportSender = errorReportSender_0;
		exception = exception_0;
	}
}
