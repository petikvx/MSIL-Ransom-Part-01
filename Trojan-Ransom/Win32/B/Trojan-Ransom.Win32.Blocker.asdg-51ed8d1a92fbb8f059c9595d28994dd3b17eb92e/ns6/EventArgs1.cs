using System;
using System.Runtime.CompilerServices;

namespace ns6;

internal sealed class EventArgs1 : EventArgs
{
	private Exception exception_0;

	[SpecialName]
	public Exception method_0()
	{
		return exception_0;
	}

	internal EventArgs1(Exception exception_1)
	{
		exception_0 = exception_1;
	}
}
