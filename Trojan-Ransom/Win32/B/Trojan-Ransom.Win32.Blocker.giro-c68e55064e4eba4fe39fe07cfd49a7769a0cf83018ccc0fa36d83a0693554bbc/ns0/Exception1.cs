using System;

namespace ns0;

internal class Exception1 : ApplicationException
{
	public Exception1()
		: base("Invalid Parameter")
	{
	}
}
