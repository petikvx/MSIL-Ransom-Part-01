using System;

namespace ns5;

internal sealed class EventArgs0 : EventArgs
{
	private Exception exception_0;

	public Exception FatalException => exception_0;

	internal EventArgs0(Exception fatalException)
	{
		exception_0 = fatalException;
	}
}
