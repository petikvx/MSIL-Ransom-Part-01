using System;
using System.Security;

namespace ns0;

internal sealed class EventArgs2 : EventArgs
{
	private SecurityException securityException_0;

	private string string_0 = string.Empty;

	internal bool bool_0;

	internal bool bool_1;

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

	public EventArgs2(SecurityException securityException)
	{
		securityException_0 = securityException;
	}

	public EventArgs2(SecurityException securityException, bool canContinue)
		: this(securityException)
	{
		bool_2 = canContinue;
	}

	public EventArgs2(string securityMessage, bool canContinue)
		: this(new SecurityException(securityMessage), canContinue)
	{
		string_0 = securityMessage;
	}
}
