using System;
using System.Security;

namespace ns9;

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
		if (Pr7uac48yBd8kYYOQCv())
		{
			switch (3)
			{
			case 0:
			case 3:
				break;
			case 1:
				goto IL_0039;
			default:
				goto IL_0040;
			case 5:
				return;
			}
		}
		string_0 = string.Empty;
		goto IL_0039;
		IL_0040:
		base._002Ector();
		securityException_0 = securityException;
		return;
		IL_0039:
		bool_2 = true;
		goto IL_0040;
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

	internal static bool Pr7uac48yBd8kYYOQCv()
	{
		return true;
	}

	internal static bool VWCVSj4Y87lLRMsEZdo()
	{
		return false;
	}
}
