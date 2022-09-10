using System;

namespace Microsoft.Build.Shared;

internal sealed class InternalErrorException : Exception
{
	internal InternalErrorException()
	{
	}

	internal InternalErrorException(string message)
		: base("Internal MSBuild Error: " + message)
	{
		ShowAssertDialog(showAssert: true);
	}

	internal InternalErrorException(string message, bool showAssert)
		: base("Internal MSBuild Error: " + message)
	{
		ShowAssertDialog(showAssert);
	}

	internal InternalErrorException(string message, Exception innerException)
		: base("Internal MSBuild Error: " + message, innerException)
	{
	}

	private void ShowAssertDialog(bool showAssert)
	{
	}
}
