using System;
using ns7;

namespace ns8;

internal sealed class EventArgs1 : EventArgs
{
	internal Class35 class35_0;

	private Exception exception_0;

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

	internal EventArgs1(Class35 reportSender, Exception exception)
	{
		class35_0 = reportSender;
		exception_0 = exception;
	}
}
