using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip;

[Serializable]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000A")]
public class BadReadException : ZipException
{
	public BadReadException()
	{
	}

	public BadReadException(string message)
		: base(message)
	{
	}

	public BadReadException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected BadReadException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
