using System;
using System.Security;

namespace ns12;

internal class EventArgs2 : EventArgs
{
	internal SecurityException securityException_0;

	internal string string_0;

	internal bool bool_0;

	internal bool bool_1;

	internal bool bool_2;

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
		while (true)
		{
			string_0 = string.Empty;
			if (TOmbQCRkYFdopAGKvbi())
			{
			}
			switch (3)
			{
			case 4:
				continue;
			case 1:
			case 3:
				bool_2 = true;
				break;
			case 5:
				return;
			}
			break;
		}
		base._002Ector();
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

	internal static bool uJGNjTRKQrKKPKRdNuX()
	{
		return true;
	}

	internal static bool TOmbQCRkYFdopAGKvbi()
	{
		return false;
	}
}
