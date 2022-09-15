using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Signers;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsDsaSigner : BcTlsDssSigner
{
	protected override short SignatureAlgorithm => 2;

	public BcTlsDsaSigner(BcTlsCrypto crypto, DsaPrivateKeyParameters privateKey)
		: base(crypto, privateKey)
	{
	}

	protected override IDsa CreateDsaImpl(int cryptoHashAlgorithm)
	{
		return new DsaSigner(new HMacDsaKCalculator(m_crypto.CreateDigest(cryptoHashAlgorithm)));
	}
}
