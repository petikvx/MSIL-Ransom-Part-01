using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class InvalidCardException : InfoCardBaseException
{
	private const int HRESULT = -1073413881;

	public InvalidCardException()
		: base(-1073413881)
	{
	}

	public InvalidCardException(string message)
		: base(-1073413881, message)
	{
	}

	public InvalidCardException(string message, Exception inner)
		: base(-1073413881, message, inner)
	{
	}

	protected InvalidCardException(SerializationInfo si, StreamingContext sc)
		: base(-1073413881, si, sc)
	{
	}
}
