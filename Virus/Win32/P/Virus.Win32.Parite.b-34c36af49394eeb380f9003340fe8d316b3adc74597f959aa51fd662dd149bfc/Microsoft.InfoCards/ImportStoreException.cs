using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class ImportStoreException : InfoCardBaseException
{
	private const int HRESULT = -1073413868;

	public ImportStoreException()
		: base(-1073413868)
	{
	}

	public ImportStoreException(string message)
		: base(-1073413868, message)
	{
	}

	public ImportStoreException(string message, Exception inner)
		: base(-1073413868, message, inner)
	{
	}

	protected ImportStoreException(SerializationInfo si, StreamingContext sc)
		: base(-1073413868, si, sc)
	{
	}
}
