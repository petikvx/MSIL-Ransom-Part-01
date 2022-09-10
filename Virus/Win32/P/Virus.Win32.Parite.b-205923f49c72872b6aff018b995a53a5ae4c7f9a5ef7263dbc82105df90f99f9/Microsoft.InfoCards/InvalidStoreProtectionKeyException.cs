using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class InvalidStoreProtectionKeyException : InfoCardBaseException
{
	private const int HRESULT = -1073413880;

	public InvalidStoreProtectionKeyException()
		: base(-1073413880)
	{
	}

	public InvalidStoreProtectionKeyException(string message)
		: base(-1073413880, message)
	{
	}

	public InvalidStoreProtectionKeyException(string message, Exception inner)
		: base(-1073413880, message, inner)
	{
	}

	protected InvalidStoreProtectionKeyException(SerializationInfo si, StreamingContext sc)
		: base(-1073413880, si, sc)
	{
	}
}
