using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class TokenCreationException : InfoCardBaseException
{
	private const int HRESULT = -1073413872;

	public TokenCreationException()
		: base(-1073413872)
	{
	}

	public TokenCreationException(string message)
		: base(-1073413872, message)
	{
	}

	public TokenCreationException(string message, Exception inner)
		: base(-1073413872, message, inner)
	{
	}

	protected TokenCreationException(SerializationInfo si, StreamingContext sc)
		: base(-1073413872, si, sc)
	{
	}
}
