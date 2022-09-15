using System.IO;

namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsStreamVerifier
{
	Stream GetOutputStream();

	bool IsVerified();
}
