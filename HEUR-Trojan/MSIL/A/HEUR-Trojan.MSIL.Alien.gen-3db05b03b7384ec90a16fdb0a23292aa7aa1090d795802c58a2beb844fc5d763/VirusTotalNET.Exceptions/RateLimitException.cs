using System;

namespace VirusTotalNET.Exceptions;

public class RateLimitException : Exception
{
	public RateLimitException(string message)
		: base(message)
	{
	}
}
