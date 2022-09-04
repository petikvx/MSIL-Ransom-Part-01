using System;

namespace ns0;

internal sealed class EventArgs2 : EventArgs
{
	internal bool bool_0;

	internal Exception exception_0;

	public bool Boolean_0 => bool_0;

	public Exception Exception_0 => exception_0;

	public EventArgs2(bool bool_1, Exception exception_1)
	{
		bool_0 = bool_1;
		exception_0 = exception_1;
	}
}
