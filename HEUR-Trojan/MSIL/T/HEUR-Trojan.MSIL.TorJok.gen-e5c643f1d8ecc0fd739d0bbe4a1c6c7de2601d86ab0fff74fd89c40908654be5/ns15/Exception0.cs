using System;

namespace ns15;

internal sealed class Exception0 : Exception
{
	public Exception0()
		: this("An error occured while talking to the proxy server.")
	{
	}

	public Exception0(string string_0)
		: base(string_0)
	{
	}
}
