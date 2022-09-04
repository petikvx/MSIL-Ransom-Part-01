using System;
using System.Security;

namespace SmartAssembly.SmartExceptionsCore;

public sealed class SecurityExceptionEventArgs : EventArgs
{
	private SecurityException securityException_0;

	private string string_0 = string.Empty;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2 = true;

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

	public bool ReportException => bool_1;

	public SecurityExceptionEventArgs(SecurityException securityException_1)
	{
		securityException_0 = securityException_1;
	}

	public SecurityExceptionEventArgs(SecurityException securityException_1, bool bool_3)
		: this(securityException_1)
	{
		bool_2 = bool_3;
	}

	public SecurityExceptionEventArgs(string string_1, bool bool_3)
		: this(new SecurityException(string_1), bool_3)
	{
		string_0 = string_1;
	}
}
