using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class UntrustedRecipientException : InfoCardBaseException
{
	private const int HRESULT = -1073413870;

	public UntrustedRecipientException()
		: base(-1073413870)
	{
	}

	public UntrustedRecipientException(string message)
		: base(-1073413870, message)
	{
	}

	public UntrustedRecipientException(string message, Exception inner)
		: base(-1073413870, message, inner)
	{
	}

	protected UntrustedRecipientException(SerializationInfo si, StreamingContext sc)
		: base(-1073413870, si, sc)
	{
	}
}
