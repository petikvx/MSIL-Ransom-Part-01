using System;
using System.IO;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportExceptionEventArgs : EventArgs
{
	private ErrorReportSender m_ReportSender;

	private Exception exception;

	private bool canDebug;

	private bool canSendReport;

	private bool showContinueCheckBox;

	private bool tryToContinue;

	public Exception Exception => exception;

	public bool CanDebug => canDebug;

	public bool CanSendReport => canSendReport;

	public bool ShowContinueCheckbox => showContinueCheckBox;

	[Obsolete("Use ShowContinueCheckbox instead, as this is now also false when the builder has chosen not to show the checkbox.")]
	public bool CanContinue => showContinueCheckBox;

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

	internal void SetShowContinueCheckBox(bool value)
	{
		showContinueCheckBox = value;
	}

	internal void EnableDebug()
	{
		canDebug = true;
	}

	internal void DisableSendReport()
	{
		canSendReport = false;
	}

	public void LaunchDebugger()
	{
		if (canDebug)
		{
			m_ReportSender.LaunchDebugger();
		}
	}

	public bool SaveEncryptedReport(string fileName)
	{
		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}
		return m_ReportSender.SaveEncryptedReport(fileName);
	}

	public byte[] GetReportRawData()
	{
		return m_ReportSender.GetReportRawData();
	}

	public bool SendReport()
	{
		if (!canSendReport)
		{
			return false;
		}
		return m_ReportSender.SendReport();
	}

	public void AddCustomProperty(string name, string value)
	{
		m_ReportSender.AddCustomProperty(name, value);
	}

	public void AttachFile(string name, string fileName)
	{
		m_ReportSender.AttachFile(name, fileName);
	}

	internal ReportExceptionEventArgs(ErrorReportSender reportSender, Exception exception)
	{
		Class2.l4t8M9wzGUypc();
		canSendReport = true;
		showContinueCheckBox = true;
		base._002Ector();
		m_ReportSender = reportSender;
		this.exception = exception;
	}
}
