using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class FailedToStartupUIException : InfoCardBaseException
{
	private const int HRESULT = -1073413867;

	public FailedToStartupUIException()
		: base(-1073413867)
	{
	}

	public FailedToStartupUIException(string message, Exception inner)
		: base(-1073413867, message, inner)
	{
	}

	protected FailedToStartupUIException(SerializationInfo si, StreamingContext sc)
		: base(-1073413867, si, sc)
	{
	}
}
