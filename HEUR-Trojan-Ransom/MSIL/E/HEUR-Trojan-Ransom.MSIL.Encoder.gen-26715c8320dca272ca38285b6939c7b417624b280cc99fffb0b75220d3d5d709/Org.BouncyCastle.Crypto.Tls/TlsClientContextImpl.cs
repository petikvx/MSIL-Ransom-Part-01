using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls;

internal class TlsClientContextImpl : AbstractTlsContext, TlsContext, TlsClientContext
{
	public override bool IsServer => false;

	internal TlsClientContextImpl(SecureRandom secureRandom, SecurityParameters securityParameters)
		: base(secureRandom, securityParameters)
	{
	}
}
