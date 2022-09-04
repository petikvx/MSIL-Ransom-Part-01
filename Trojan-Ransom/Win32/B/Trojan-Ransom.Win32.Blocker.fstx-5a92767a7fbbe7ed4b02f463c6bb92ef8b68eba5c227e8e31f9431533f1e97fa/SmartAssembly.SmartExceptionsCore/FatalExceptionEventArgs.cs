using System;

namespace SmartAssembly.SmartExceptionsCore;

public class FatalExceptionEventArgs : EventArgs
{
	private Exception fatalException;

	public Exception FatalException => fatalException;

	internal FatalExceptionEventArgs(Exception exception_0)
	{
		fatalException = exception_0;
	}
}
