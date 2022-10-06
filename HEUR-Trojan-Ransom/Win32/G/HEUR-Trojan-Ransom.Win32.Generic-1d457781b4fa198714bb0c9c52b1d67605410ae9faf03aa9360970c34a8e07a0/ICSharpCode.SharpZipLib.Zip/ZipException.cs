using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Zip;

[Serializable]
public class ZipException : SharpZipBaseException
{
	protected ZipException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	public ZipException()
	{
	}

	public ZipException(string message)
		: base(message)
	{
	}

	public ZipException(string message, Exception exception)
		: base(message, exception)
	{
	}
}
