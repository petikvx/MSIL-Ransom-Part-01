using System;

namespace ns11;

internal class EventArgs1 : EventArgs
{
	internal Class46 class46_0;

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
			Class21.smethod_3(class46_0);
		}
	}

	internal EventArgs1(Class46 reportSender, Exception exception)
	{
		class46_0 = reportSender;
		exception_0 = exception;
	}

	internal static bool DU2EMusBKBCtQV1v8xI()
	{
		return true;
	}

	internal static bool HaUr4tsEH8dUXVmWOkM()
	{
		return false;
	}
}
