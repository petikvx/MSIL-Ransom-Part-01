using System;

namespace Gecko;

public class GeckoException : Exception
{
	internal GeckoException()
	{
	}

	internal GeckoException(string message)
		: base(message)
	{
	}

	internal GeckoException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
