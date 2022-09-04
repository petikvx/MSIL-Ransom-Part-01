using System;
using System.Security;

namespace SmartAssembly.SmartExceptionsCore;

public class SecurityExceptionEventArgs1 : EventArgs
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

	public bool ReportException
	{
		get
		{
			return reportException;
		}
		set
		{
			reportException = value;
		}
	}

	public SecurityExceptionEventArgs1(SecurityException securityException)
	{
		this.securityException = securityException;
	}

	public SecurityExceptionEventArgs1(SecurityException securityException, bool canContinue)
		: this(securityException)
	{
		this.canContinue = canContinue;
	}

	public SecurityExceptionEventArgs1(string securityMessage, bool canContinue)
		: this(new SecurityException(securityMessage), canContinue)
	{
		this.securityMessage = securityMessage;
	}
}
