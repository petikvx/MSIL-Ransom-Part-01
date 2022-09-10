using System;
using System.Runtime.CompilerServices;
using ns4;

namespace ns2;

[GAttribute0(13)]
public class GEventArgs0 : EventArgs
{
	private Exception exception_0 = null;

	[SpecialName]
	public Exception method_0()
	{
		return exception_0;
	}

	internal GEventArgs0(Exception exception_1)
	{
		exception_0 = exception_1;
	}
}
