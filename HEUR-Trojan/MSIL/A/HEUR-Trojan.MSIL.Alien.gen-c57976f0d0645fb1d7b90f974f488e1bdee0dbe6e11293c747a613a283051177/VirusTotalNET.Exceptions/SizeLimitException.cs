using System;

namespace VirusTotalNET.Exceptions;

public class SizeLimitException : Exception
{
	public SizeLimitException(string message)
		: base(message)
	{
	}
}
