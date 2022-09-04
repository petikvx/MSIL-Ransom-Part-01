using System;

namespace SmartAssembly.SmartExceptionsCore;

public sealed class FatalExceptionEventArgs : EventArgs
{
	private Exception exception_0;

	public Exception FatalException => exception_0;

	internal FatalExceptionEventArgs(Exception exception_1)
	{
		exception_0 = exception_1;
	}
}
