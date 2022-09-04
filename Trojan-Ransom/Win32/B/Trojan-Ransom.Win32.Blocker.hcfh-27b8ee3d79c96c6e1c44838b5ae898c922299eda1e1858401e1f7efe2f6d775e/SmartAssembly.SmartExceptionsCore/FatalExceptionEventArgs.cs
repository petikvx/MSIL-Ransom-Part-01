using System;

namespace SmartAssembly.SmartExceptionsCore;

public sealed class FatalExceptionEventArgs : EventArgs
{
	private Exception fatalException;

	public Exception FatalException => fatalException;

	internal FatalExceptionEventArgs(Exception fatalException)
	{
		this.fatalException = fatalException;
	}
}
