using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class DataAccessException : InfoCardBaseException
{
	private const int HRESULT = -1073413887;

	public DataAccessException()
		: base(-1073413887)
	{
	}

	public DataAccessException(string message)
		: base(-1073413887, message)
	{
	}

	public DataAccessException(string message, Exception inner)
		: base(-1073413887, message, inner)
	{
	}

	protected DataAccessException(SerializationInfo si, StreamingContext sc)
		: base(-1073413887, si, sc)
	{
	}
}
