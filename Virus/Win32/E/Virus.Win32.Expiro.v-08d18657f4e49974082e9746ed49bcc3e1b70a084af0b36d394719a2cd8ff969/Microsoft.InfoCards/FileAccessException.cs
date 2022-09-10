using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class FileAccessException : InfoCardBaseException
{
	private const int HRESULT = -1073413864;

	public FileAccessException()
		: base(-1073413864)
	{
	}

	public FileAccessException(string message)
		: base(-1073413864, message)
	{
	}

	public FileAccessException(string message, Exception inner)
		: base(-1073413864, message, inner)
	{
	}

	protected FileAccessException(SerializationInfo si, StreamingContext sc)
		: base(-1073413864, si, sc)
	{
	}
}
