using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib;

[Serializable]
public class SharpZipBaseException : ApplicationException
{
	public SharpZipBaseException()
	{
	}

	public SharpZipBaseException(string message)
		: base(message)
	{
	}

	protected SharpZipBaseException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public SharpZipBaseException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
