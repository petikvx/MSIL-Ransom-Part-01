using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

internal class TlsServerContextImpl : AbstractTlsContext, TlsContext, TlsServerContext
{
	public override bool IsServer => true;

	internal TlsServerContextImpl(TlsCrypto crypto)
		: base(crypto, 0)
	{
	}
}
