using System;

namespace SmartAssembly.SmartExceptionsCore;

public class FatalExceptionEventArgs1 : EventArgs
{
	private Exception fatalException;

	public Exception FatalException => fatalException;

	internal FatalExceptionEventArgs1(Exception fatalException)
	{
		this.fatalException = fatalException;
	}
}
