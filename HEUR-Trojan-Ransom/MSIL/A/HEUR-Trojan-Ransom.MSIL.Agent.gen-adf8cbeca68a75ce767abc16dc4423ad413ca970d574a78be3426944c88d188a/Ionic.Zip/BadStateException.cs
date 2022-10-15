using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip;

[Serializable]
[Guid("ebc25cf6-9120-4283-b972-0e5520d00007")]
public class BadStateException : ZipException
{
	public BadStateException()
	{
	}

	public BadStateException(string message)
		: base(message)
	{
	}

	public BadStateException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected BadStateException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
