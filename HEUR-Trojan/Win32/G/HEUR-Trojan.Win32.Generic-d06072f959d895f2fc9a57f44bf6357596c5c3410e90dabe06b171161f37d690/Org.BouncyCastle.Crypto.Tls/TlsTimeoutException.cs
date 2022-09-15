using System;

namespace Org.BouncyCastle.Crypto.Tls;

public class TlsTimeoutException : TlsException
{
	public TlsTimeoutException()
	{
	}

	public TlsTimeoutException(string message)
		: base(message)
	{
	}

	public TlsTimeoutException(string message, Exception cause)
		: base(message, cause)
	{
	}
}
