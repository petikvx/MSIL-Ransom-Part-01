using System;

namespace ns7;

internal sealed class EventArgs0 : EventArgs
{
	internal Exception exception_0;

	public Exception FatalException => exception_0;

	internal EventArgs0(Exception fatalException)
	{
		exception_0 = fatalException;
	}
}
