using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class CommunicationException : InfoCardBaseException
{
	private const int HRESULT = -1073413888;

	public CommunicationException()
		: base(-1073413888)
	{
	}

	public CommunicationException(string message)
		: base(-1073413888, message)
	{
	}

	public CommunicationException(string message, Exception inner)
		: base(-1073413888, message, inner)
	{
	}

	protected CommunicationException(SerializationInfo si, StreamingContext sc)
		: base(-1073413888, si, sc)
	{
	}
}
