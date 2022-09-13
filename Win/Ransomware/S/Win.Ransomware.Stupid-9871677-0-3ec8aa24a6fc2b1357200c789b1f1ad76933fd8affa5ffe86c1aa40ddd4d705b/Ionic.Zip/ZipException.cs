using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Ionic.Zip;

[Serializable]
[Guid("ebc25cf6-9120-4283-b972-0e5520d00006")]
public class ZipException : Exception
{
	public ZipException()
	{
	}

	public ZipException(string message)
		: base(message)
	{
	}

	public ZipException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected ZipException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
