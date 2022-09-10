using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class ImportException : InfoCardBaseException
{
	private const int HRESULT = -1073413884;

	public ImportException()
		: base(-1073413884)
	{
	}

	public ImportException(string message)
		: base(-1073413884, message)
	{
	}

	public ImportException(string message, Exception inner)
		: base(-1073413884, message, inner)
	{
	}

	protected ImportException(SerializationInfo si, StreamingContext sc)
		: base(-1073413884, si, sc)
	{
	}
}
