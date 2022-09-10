using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class SystemShuttingDownException : InfoCardBaseException
{
	private const int HRESULT = -1073413873;

	public SystemShuttingDownException()
		: base(-1073413873)
	{
	}

	public SystemShuttingDownException(string message)
		: base(-1073413873, message)
	{
	}

	public SystemShuttingDownException(string message, Exception inner)
		: base(-1073413873, message, inner)
	{
	}

	protected SystemShuttingDownException(SerializationInfo si, StreamingContext sc)
		: base(-1073413873, si, sc)
	{
	}
}
