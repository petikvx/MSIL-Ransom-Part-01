using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class IdentityValidationException : InfoCardBaseException
{
	private const int HRESULT = -1073413885;

	public IdentityValidationException()
		: base(-1073413885)
	{
	}

	public IdentityValidationException(string message)
		: base(-1073413885, message)
	{
	}

	public IdentityValidationException(string message, Exception inner)
		: base(-1073413885, message, inner)
	{
	}

	protected IdentityValidationException(SerializationInfo si, StreamingContext sc)
		: base(-1073413885, si, sc)
	{
	}
}
