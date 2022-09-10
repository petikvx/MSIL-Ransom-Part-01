using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class MaxSessionCountExceededException : InfoCardBaseException
{
	private const int HRESULT = -1073413865;

	public MaxSessionCountExceededException()
		: base(-1073413865)
	{
	}

	public MaxSessionCountExceededException(string message)
		: base(-1073413865, message)
	{
	}

	public MaxSessionCountExceededException(string message, Exception inner)
		: base(-1073413865, message, inner)
	{
	}

	protected MaxSessionCountExceededException(SerializationInfo si, StreamingContext sc)
		: base(-1073413865, si, sc)
	{
	}
}
