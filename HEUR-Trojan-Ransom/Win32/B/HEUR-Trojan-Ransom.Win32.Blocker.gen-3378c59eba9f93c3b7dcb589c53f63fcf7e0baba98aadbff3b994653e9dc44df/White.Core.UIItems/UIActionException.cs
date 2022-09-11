using System;

namespace White.Core.UIItems;

[Serializable]
public class UIActionException : Exception
{
	public UIActionException(string message)
		: base(message)
	{
	}

	public UIActionException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
