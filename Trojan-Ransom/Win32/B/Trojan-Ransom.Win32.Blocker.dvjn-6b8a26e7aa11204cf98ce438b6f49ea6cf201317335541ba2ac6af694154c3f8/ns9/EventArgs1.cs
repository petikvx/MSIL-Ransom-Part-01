using System;

namespace ns9;

internal class EventArgs1 : EventArgs
{
	internal Class29 class29_0;

	internal Exception exception_0;

	internal bool bool_0;

	internal bool bool_1 = true;

	internal bool bool_2 = true;

	internal bool bool_3;

	public Exception Exception => exception_0;

	public bool CanDebug => bool_0;

	public bool CanSendReport => bool_1;

	public bool ShowContinueCheckbox => bool_2;

	[Obsolete("Use ShowContinueCheckbox instead, as this is now also false when the builder has chosen not to show the checkbox.")]
	public bool CanContinue => bool_2;

	public bool TryToContinue
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	public void method_0()
	{
		if (bool_0)
		{
			Class42.smethod_85(class29_0);
		}
	}

	internal EventArgs1(Class29 reportSender, Exception exception)
	{
		class29_0 = reportSender;
		exception_0 = exception;
	}

	internal static bool W3UpncKz8hjkSY5CBJy()
	{
		return true;
	}

	internal static bool I3Q8JA4NJlkXmUbQwVS()
	{
		return false;
	}
}
