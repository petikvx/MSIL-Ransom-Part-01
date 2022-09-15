using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

internal class BcSsl3Hmac : TlsHmac, TlsMac
{
	private const byte IPAD_BYTE = 54;

	private const byte OPAD_BYTE = 92;

	private static readonly byte[] IPAD = GenPad(54, 48);

	private static readonly byte[] OPAD = GenPad(92, 48);

	private readonly IDigest m_digest;

	private readonly int m_padLength;

	private byte[] m_secret;

	public virtual int InternalBlockSize => m_digest.GetByteLength();

	public virtual int MacLength => m_digest.GetDigestSize();

	internal BcSsl3Hmac(IDigest digest)
	{
		m_digest = digest;
		if (digest.GetDigestSize() == 20)
		{
			m_padLength = 40;
		}
		else
		{
			m_padLength = 48;
		}
	}

	public virtual void SetKey(byte[] key, int keyOff, int keyLen)
	{
		m_secret = TlsUtilities.CopyOfRangeExact(key, keyOff, keyOff + keyLen);
		Reset();
	}

	public virtual void Update(byte[] input, int inOff, int len)
	{
		m_digest.BlockUpdate(input, inOff, len);
	}

	public virtual byte[] CalculateMac()
	{
		byte[] array = new byte[m_digest.GetDigestSize()];
		DoFinal(array, 0);
		return array;
	}

	public virtual void CalculateMac(byte[] output, int outOff)
	{
		DoFinal(output, outOff);
	}

	public virtual void Reset()
	{
		m_digest.Reset();
		m_digest.BlockUpdate(m_secret, 0, m_secret.Length);
		m_digest.BlockUpdate(IPAD, 0, m_padLength);
	}

	private void DoFinal(byte[] output, int outOff)
	{
		byte[] array = new byte[m_digest.GetDigestSize()];
		m_digest.DoFinal(array, 0);
		m_digest.BlockUpdate(m_secret, 0, m_secret.Length);
		m_digest.BlockUpdate(OPAD, 0, m_padLength);
		m_digest.BlockUpdate(array, 0, array.Length);
		m_digest.DoFinal(output, outOff);
		Reset();
	}

	private static byte[] GenPad(byte b, int count)
	{
		byte[] array = new byte[count];
		Arrays.Fill(array, b);
		return array;
	}
}
