using System;

namespace Org.BouncyCastle.Tls.Crypto;

public class TlsCryptoException : TlsException
{
	public TlsCryptoException(string msg)
		: base(msg)
	{
	}

	public TlsCryptoException(string msg, Exception cause)
		: base(msg, cause)
	{
	}
}
