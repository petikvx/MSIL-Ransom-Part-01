using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsDsaVerifier : BcTlsDssVerifier
{
	protected override short SignatureAlgorithm => 2;

	public BcTlsDsaVerifier(BcTlsCrypto crypto, DsaPublicKeyParameters publicKey)
		: base(crypto, publicKey)
	{
	}

	protected override IDsa CreateDsaImpl(int cryptoHashAlgorithm)
	{
		return new DsaSigner(new HMacDsaKCalculator(m_crypto.CreateDigest(cryptoHashAlgorithm)));
	}
}
