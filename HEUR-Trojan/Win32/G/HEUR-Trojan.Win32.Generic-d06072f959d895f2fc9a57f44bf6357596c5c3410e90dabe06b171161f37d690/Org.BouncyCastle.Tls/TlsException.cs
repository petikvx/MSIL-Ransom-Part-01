using System;
using System.IO;

namespace Org.BouncyCastle.Tls;

public class TlsException : IOException
{
	public TlsException()
	{
	}

	public TlsException(string message)
		: base(message)
	{
	}

	public TlsException(string message, Exception cause)
		: base(message, cause)
	{
	}
}
