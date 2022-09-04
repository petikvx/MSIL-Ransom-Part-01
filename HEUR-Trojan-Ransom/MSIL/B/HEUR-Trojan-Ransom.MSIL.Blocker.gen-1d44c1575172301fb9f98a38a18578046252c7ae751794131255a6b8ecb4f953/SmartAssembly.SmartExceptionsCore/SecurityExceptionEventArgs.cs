using System;
using System.Security;

namespace SmartAssembly.SmartExceptionsCore;

public class SecurityExceptionEventArgs : EventArgs
{
	private string string_0 = string.Empty;

	private bool bool_0;

	private bool bool_1;

	internal SecurityException securityException_0;

	internal bool bool_2 = true;

	public SecurityException SecurityException => securityException_0;

	public string SecurityMessage => string_0;

	public bool CanContinue => bool_2;

	public bool TryToContinue
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public bool ReportException
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	public SecurityExceptionEventArgs(SecurityException securityException)
	{
		SecurityException ex = (securityException_0 = securityException);
	}

	public SecurityExceptionEventArgs(SecurityException securityException, bool canContinue)
		: this(securityException)
	{
		bool flag = (bool_2 = canContinue);
	}

	public SecurityExceptionEventArgs(string securityMessage, bool canContinue)
		: this(new SecurityException(securityMessage), canContinue)
	{
		string_0 = securityMessage;
	}
}
