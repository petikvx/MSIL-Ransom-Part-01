using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsECDsaSigner : BcTlsDssSigner
{
	protected override short SignatureAlgorithm => 3;

	public BcTlsECDsaSigner(BcTlsCrypto crypto, ECPrivateKeyParameters privateKey)
		: base(crypto, privateKey)
	{
	}

	protected override IDsa CreateDsaImpl(int cryptoHashAlgorithm)
	{
		return new ECDsaSigner(new HMacDsaKCalculator(m_crypto.CreateDigest(cryptoHashAlgorithm)));
	}
}
