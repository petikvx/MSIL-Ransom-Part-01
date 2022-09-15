using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsECDsaVerifier : BcTlsDssVerifier
{
	protected override short SignatureAlgorithm => 3;

	public BcTlsECDsaVerifier(BcTlsCrypto crypto, ECPublicKeyParameters publicKey)
		: base(crypto, publicKey)
	{
	}

	protected override IDsa CreateDsaImpl(int cryptoHashAlgorithm)
	{
		return new ECDsaSigner(new HMacDsaKCalculator(m_crypto.CreateDigest(cryptoHashAlgorithm)));
	}
}
