using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class ExportException : InfoCardBaseException
{
	private const int HRESULT = -1073413886;

	public ExportException()
		: base(-1073413886)
	{
	}

	public ExportException(string message)
		: base(-1073413886, message)
	{
	}

	public ExportException(string message, Exception inner)
		: base(-1073413886, message, inner)
	{
	}

	protected ExportException(SerializationInfo si, StreamingContext sc)
		: base(-1073413886, si, sc)
	{
	}
}
