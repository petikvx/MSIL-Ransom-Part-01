using System;

namespace ns0;

internal sealed class Exception1 : ApplicationException
{
	public Exception1()
		: base("Invalid Parameter")
	{
	}
}
