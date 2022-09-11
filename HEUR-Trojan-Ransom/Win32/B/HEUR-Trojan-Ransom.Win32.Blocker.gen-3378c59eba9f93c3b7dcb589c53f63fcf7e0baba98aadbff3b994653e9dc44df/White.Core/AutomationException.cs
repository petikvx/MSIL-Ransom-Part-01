using System;

namespace White.Core;

public class AutomationException : Exception
{
	public virtual string DebugDetails { get; private set; }

	public AutomationException(string message, string debugDetails)
		: base(message)
	{
		DebugDetails = debugDetails;
	}

	public AutomationException(string message, string debugDetails, Exception innerException)
		: base(message, innerException)
	{
		DebugDetails = debugDetails;
	}
}
