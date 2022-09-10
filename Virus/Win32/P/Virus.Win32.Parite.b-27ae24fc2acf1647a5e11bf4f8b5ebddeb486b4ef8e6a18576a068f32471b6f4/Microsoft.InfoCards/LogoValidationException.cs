using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class LogoValidationException : InfoCardBaseException
{
	private const int HRESULT = -1073413879;

	public LogoValidationException()
		: base(-1073413879)
	{
	}

	public LogoValidationException(string message)
		: base(-1073413879, message)
	{
	}

	public LogoValidationException(string message, Exception inner)
		: base(-1073413879, message, inner)
	{
	}

	protected LogoValidationException(SerializationInfo si, StreamingContext sc)
		: base(-1073413879, si, sc)
	{
	}
}
