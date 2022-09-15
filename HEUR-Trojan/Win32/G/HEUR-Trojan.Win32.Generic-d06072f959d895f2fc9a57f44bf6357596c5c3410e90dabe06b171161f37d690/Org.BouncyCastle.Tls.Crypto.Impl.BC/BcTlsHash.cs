using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsHash : TlsHash
{
	private readonly BcTlsCrypto m_crypto;

	private readonly int m_cryptoHashAlgorithm;

	private readonly IDigest m_digest;

	internal BcTlsHash(BcTlsCrypto crypto, int cryptoHashAlgorithm)
		: this(crypto, cryptoHashAlgorithm, crypto.CreateDigest(cryptoHashAlgorithm))
	{
	}

	private BcTlsHash(BcTlsCrypto crypto, int cryptoHashAlgorithm, IDigest digest)
	{
		m_crypto = crypto;
		m_cryptoHashAlgorithm = cryptoHashAlgorithm;
		m_digest = digest;
	}

	public void Update(byte[] data, int offSet, int length)
	{
		m_digest.BlockUpdate(data, offSet, length);
	}

	public byte[] CalculateHash()
	{
		byte[] array = new byte[m_digest.GetDigestSize()];
		m_digest.DoFinal(array, 0);
		return array;
	}

	public TlsHash CloneHash()
	{
		IDigest digest = m_crypto.CloneDigest(m_cryptoHashAlgorithm, m_digest);
		return new BcTlsHash(m_crypto, m_cryptoHashAlgorithm, digest);
	}

	public void Reset()
	{
		m_digest.Reset();
	}
}
