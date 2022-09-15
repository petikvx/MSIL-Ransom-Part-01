using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls;

internal class TlsClientContextImpl : AbstractTlsContext, TlsClientContext, TlsContext
{
	public override bool IsServer => false;

	internal TlsClientContextImpl(TlsCrypto crypto)
		: base(crypto, 1)
	{
	}
}
