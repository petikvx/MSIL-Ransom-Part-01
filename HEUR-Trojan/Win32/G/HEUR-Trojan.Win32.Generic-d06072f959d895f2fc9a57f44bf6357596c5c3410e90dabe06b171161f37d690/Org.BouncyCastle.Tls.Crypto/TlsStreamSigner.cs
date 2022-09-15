using System.IO;

namespace Org.BouncyCastle.Tls.Crypto;

public interface TlsStreamSigner
{
	Stream GetOutputStream();

	byte[] GetSignature();
}
