using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

internal sealed class BcTlsHmac : TlsHmac, TlsMac
{
	private readonly HMac m_hmac;

	public int InternalBlockSize => m_hmac.GetUnderlyingDigest().GetByteLength();

	public int MacLength => m_hmac.GetMacSize();

	internal BcTlsHmac(HMac hmac)
	{
		m_hmac = hmac;
	}

	public void SetKey(byte[] key, int keyOff, int keyLen)
	{
		m_hmac.Init(new KeyParameter(key, keyOff, keyLen));
	}

	public void Update(byte[] input, int inOff, int length)
	{
		m_hmac.BlockUpdate(input, inOff, length);
	}

	public byte[] CalculateMac()
	{
		byte[] array = new byte[m_hmac.GetMacSize()];
		m_hmac.DoFinal(array, 0);
		return array;
	}

	public void CalculateMac(byte[] output, int outOff)
	{
		m_hmac.DoFinal(output, outOff);
	}

	public void Reset()
	{
		m_hmac.Reset();
	}
}
