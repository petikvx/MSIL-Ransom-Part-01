using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class InfoCardRequestException : InfoCardBaseException
{
	private const int HRESULT = -1073413882;

	public InfoCardRequestException()
		: base(-1073413882)
	{
	}

	public InfoCardRequestException(string message)
		: base(-1073413882, message)
	{
	}

	public InfoCardRequestException(string message, Exception inner)
		: base(-1073413882, message, inner)
	{
	}

	protected InfoCardRequestException(SerializationInfo si, StreamingContext sc)
		: base(-1073413882, si, sc)
	{
	}
}
