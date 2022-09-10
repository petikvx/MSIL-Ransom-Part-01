using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class PolicyValidationException : InfoCardBaseException
{
	private const int HRESULT = -1073413877;

	public PolicyValidationException()
		: base(-1073413877)
	{
	}

	public PolicyValidationException(string message)
		: base(-1073413877, message)
	{
	}

	public PolicyValidationException(string message, Exception inner)
		: base(-1073413877, message, inner)
	{
	}

	protected PolicyValidationException(SerializationInfo si, StreamingContext sc)
		: base(-1073413877, si, sc)
	{
	}
}
