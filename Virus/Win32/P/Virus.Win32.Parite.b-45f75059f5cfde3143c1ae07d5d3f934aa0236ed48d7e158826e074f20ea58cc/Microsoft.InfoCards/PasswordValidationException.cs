using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class PasswordValidationException : InfoCardBaseException
{
	private const int HRESULT = -1073413878;

	public PasswordValidationException()
		: base(-1073413878)
	{
	}

	public PasswordValidationException(string message)
		: base(-1073413878, message)
	{
	}

	public PasswordValidationException(string message, Exception inner)
		: base(-1073413878, message, inner)
	{
	}

	protected PasswordValidationException(SerializationInfo si, StreamingContext sc)
		: base(-1073413878, si, sc)
	{
	}
}
