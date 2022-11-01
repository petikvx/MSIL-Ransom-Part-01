using System;

namespace VirusTotalNET.Exceptions;

public class AccessDeniedException : Exception
{
	public AccessDeniedException(string message)
		: base(message)
	{
	}
}
