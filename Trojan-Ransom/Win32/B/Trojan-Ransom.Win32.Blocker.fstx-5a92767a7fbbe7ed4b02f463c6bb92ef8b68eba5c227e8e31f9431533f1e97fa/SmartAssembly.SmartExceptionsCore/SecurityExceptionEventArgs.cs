using System;
using System.Security;

namespace SmartAssembly.SmartExceptionsCore;

public class SecurityExceptionEventArgs : EventArgs
{
	private SecurityException securityException;

	private string securityMessage = string.Empty;

	private bool tryToContinue;

	private bool reportException;

	private bool canContinue = true;

	public SecurityException SecurityException => securityException;

	public string SecurityMessage => securityMessage;

	public bool CanContinue => canContinue;

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

	public bool ReportException => reportException;

	public SecurityExceptionEventArgs(SecurityException securityException_0)
	{
		securityException = securityException_0;
	}

	public SecurityExceptionEventArgs(SecurityException securityException_0, bool bool_0)
		: this(securityException_0)
	{
		canContinue = bool_0;
	}

	public SecurityExceptionEventArgs(string string_0, bool bool_0)
		: this(new SecurityException(string_0), bool_0)
	{
		securityMessage = string_0;
	}
}
