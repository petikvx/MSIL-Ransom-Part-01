using System;
using System.Security;

namespace ns11;

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
			if (UAy8clXf8HxMky2rRCm())
			{
			}
			switch (4)
			{
			case 0:
				continue;
			case 1:
			case 4:
				bool_2 = true;
				base._002Ector();
				break;
			case 5:
				return;
			}
			break;
		}
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

	internal static bool Ljd1RvszGGWM0K3Kgb2()
	{
		return true;
	}

	internal static bool UAy8clXf8HxMky2rRCm()
	{
		return false;
	}
}
