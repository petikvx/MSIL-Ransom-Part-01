using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class TrustExchangeException : InfoCardBaseException
{
	private const int HRESULT = -1073413871;

	public TrustExchangeException()
		: base(-1073413871)
	{
	}

	public TrustExchangeException(string message)
		: base(-1073413871, message)
	{
	}

	public TrustExchangeException(string message, Exception inner)
		: base(-1073413871, message, inner)
	{
	}

	protected TrustExchangeException(SerializationInfo si, StreamingContext sc)
		: base(-1073413871, si, sc)
	{
	}
}
