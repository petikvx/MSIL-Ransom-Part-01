namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsHmac : TlsMac
{
	int InternalBlockSize { get; }
}
