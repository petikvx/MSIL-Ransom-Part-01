using System;
using System.Security;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class FatalExceptionEventArgs : EventArgs
{
	internal Exception exception_0;

	public Exception FatalException => exception_0;

	internal FatalExceptionEventArgs(Exception exception_1)
	{
		Exception ex = (exception_0 = exception_1);
	}

	[SecuritySafeCritical]
	static FatalExceptionEventArgs()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static bool smethod_0(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 85:
				return type_0.HasElementType;
			}
		}
	}
}
