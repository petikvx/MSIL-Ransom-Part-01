using System;

namespace SmartAssembly.SmartExceptionsCore;

public class FatalExceptionEventArgs : EventArgs
{
	internal Exception exception_0;

	public Exception FatalException => exception_0;

	internal FatalExceptionEventArgs(Exception exception_1)
	{
		Exception ex = (exception_0 = exception_1);
	}
}
