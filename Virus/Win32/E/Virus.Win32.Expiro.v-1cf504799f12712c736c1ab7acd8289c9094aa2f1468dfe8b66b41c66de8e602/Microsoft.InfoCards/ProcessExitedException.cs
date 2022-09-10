using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class ProcessExitedException : InfoCardBaseException
{
	private const int HRESULT = -1073413876;

	public ProcessExitedException()
		: base(-1073413876)
	{
	}

	public ProcessExitedException(string message)
		: base(-1073413876, message)
	{
	}

	public ProcessExitedException(string message, Exception inner)
		: base(-1073413876, message, inner)
	{
	}

	protected ProcessExitedException(SerializationInfo si, StreamingContext sc)
		: base(-1073413876, si, sc)
	{
	}
}
