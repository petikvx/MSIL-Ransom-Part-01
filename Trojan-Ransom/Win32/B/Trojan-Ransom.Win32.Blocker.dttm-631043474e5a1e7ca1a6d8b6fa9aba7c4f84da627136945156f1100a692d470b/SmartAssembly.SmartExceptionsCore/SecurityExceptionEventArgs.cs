using System;
using System.Security;

namespace SmartAssembly.SmartExceptionsCore;

public class SecurityExceptionEventArgs : EventArgs
{
	private SecurityException securityException_0;

	private string string_0 = string.Empty;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2 = true;

	public bool TryToContinue => bool_0;

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

	public SecurityExceptionEventArgs(SecurityException securityException_1)
	{
		securityException_0 = securityException_1;
	}
}
