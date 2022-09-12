using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls;

internal class TlsServerContextImpl : AbstractTlsContext, TlsContext, TlsServerContext
{
	public override bool IsServer => true;

	internal TlsServerContextImpl(SecureRandom secureRandom, SecurityParameters securityParameters)
		: base(secureRandom, securityParameters)
	{
	}
}
