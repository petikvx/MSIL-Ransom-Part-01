using Org.BouncyCastle.Crypto.Prng;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsNonceGenerator : TlsNonceGenerator
{
	private readonly IRandomGenerator m_randomGenerator;

	internal BcTlsNonceGenerator(IRandomGenerator randomGenerator)
	{
		m_randomGenerator = randomGenerator;
	}

	public byte[] GenerateNonce(int size)
	{
		byte[] array = new byte[size];
		m_randomGenerator.NextBytes(array);
		return array;
	}
}
