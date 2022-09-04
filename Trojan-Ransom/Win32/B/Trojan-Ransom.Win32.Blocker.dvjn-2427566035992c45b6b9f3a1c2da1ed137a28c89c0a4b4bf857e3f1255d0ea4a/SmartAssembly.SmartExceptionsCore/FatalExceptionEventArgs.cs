using System;

namespace SmartAssembly.SmartExceptionsCore;

public class FatalExceptionEventArgs : EventArgs
{
	private Exception fatalException;

	public Exception FatalException => fatalException;

	internal FatalExceptionEventArgs(Exception fatalException)
	{
		Class2.l4t8M9wzGUypc();
		base._002Ector();
		this.fatalException = fatalException;
	}
}
