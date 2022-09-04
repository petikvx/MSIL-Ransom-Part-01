using System;
using System.Security;

namespace SmartAssembly.SmartExceptionsCore;

public class SecurityExceptionEventArgs : EventArgs
{
	private SecurityException securityException;

	private string securityMessage;

	private bool tryToContinue;

	private bool reportException;

	private bool canContinue;

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

	public SecurityExceptionEventArgs(SecurityException securityException)
	{
		Class2.l4t8M9wzGUypc();
		securityMessage = string.Empty;
		canContinue = true;
		base._002Ector();
		this.securityException = securityException;
	}

	public SecurityExceptionEventArgs(SecurityException securityException, bool canContinue)
	{
		Class2.l4t8M9wzGUypc();
		this._002Ector(securityException);
		this.canContinue = canContinue;
	}

	public SecurityExceptionEventArgs(string securityMessage, bool canContinue)
	{
		Class2.l4t8M9wzGUypc();
		this._002Ector(new SecurityException(securityMessage), canContinue);
		this.securityMessage = securityMessage;
	}
}
