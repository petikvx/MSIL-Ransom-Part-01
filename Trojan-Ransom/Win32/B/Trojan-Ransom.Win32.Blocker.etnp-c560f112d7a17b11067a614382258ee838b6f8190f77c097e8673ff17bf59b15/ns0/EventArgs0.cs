using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal sealed class EventArgs0 : EventArgs
{
	private Exception exception_0;

	internal EventArgs0(Exception CO_)
	{
		exception_0 = CO_;
	}

	[SpecialName]
	public Exception method_0()
	{
		return exception_0;
	}
}
