using System;
using System.Diagnostics;
using SmartAssembly.Zip;

namespace SmartAssembly.SmartExceptionsCore;

public class FatalExceptionEventArgs : EventArgs
{
	internal Exception exception_0;

	public Exception FatalException => exception_0;

	internal FatalExceptionEventArgs(Exception exception_1)
	{
		Exception ex = (exception_0 = exception_1);
	}

	static FatalExceptionEventArgs()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static object smethod_0(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 6:
				return Activator.CreateInstance(type_0);
			}
		}
	}

	internal static Process smethod_1(int int_0, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 18:
				return Process.GetProcessById(int_0);
			}
		}
	}

	internal static int smethod_2(ref DateTime dateTime_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 72:
				return dateTime_0.Month;
			case 73:
				return dateTime_0.Day;
			case 74:
				return dateTime_0.Second;
			}
		}
	}
}
