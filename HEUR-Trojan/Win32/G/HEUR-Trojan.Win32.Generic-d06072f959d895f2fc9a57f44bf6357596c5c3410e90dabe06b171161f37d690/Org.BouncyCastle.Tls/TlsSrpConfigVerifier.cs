using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

public interface TlsSrpConfigVerifier
{
	bool Accept(TlsSrpConfig srpConfig);
}
