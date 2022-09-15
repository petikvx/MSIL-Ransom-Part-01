using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public interface TlsDHGroupVerifier
{
	bool Accept(DHGroup dhGroup);
}
