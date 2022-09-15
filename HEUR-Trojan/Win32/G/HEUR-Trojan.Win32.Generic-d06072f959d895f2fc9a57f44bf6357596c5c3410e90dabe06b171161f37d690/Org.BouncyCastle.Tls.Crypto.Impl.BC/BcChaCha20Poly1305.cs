using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public sealed class BcChaCha20Poly1305 : TlsAeadCipherImpl
{
	private static readonly byte[] Zeroes = new byte[15];

	private readonly ChaCha7539Engine m_cipher = new ChaCha7539Engine();

	private readonly Poly1305 m_mac = new Poly1305();

	private readonly bool m_isEncrypting;

	private int m_additionalDataLength;

	public BcChaCha20Poly1305(bool isEncrypting)
	{
		m_isEncrypting = isEncrypting;
	}

	public int DoFinal(byte[] input, int inputOffset, int inputLength, byte[] output, int outputOffset)
	{
		if (m_isEncrypting)
		{
			m_cipher.ProcessBytes(input, inputOffset, inputLength, output, outputOffset);
			UpdateMac(output, outputOffset, inputLength);
			byte[] array = new byte[16];
			Pack.UInt64_To_LE((ulong)m_additionalDataLength, array, 0);
			Pack.UInt64_To_LE((ulong)inputLength, array, 8);
			m_mac.BlockUpdate(array, 0, 16);
			m_mac.DoFinal(output, outputOffset + inputLength);
			return inputLength + 16;
		}
		int num = inputLength - 16;
		UpdateMac(input, inputOffset, num);
		byte[] array2 = new byte[16];
		Pack.UInt64_To_LE((ulong)m_additionalDataLength, array2, 0);
		Pack.UInt64_To_LE((ulong)num, array2, 8);
		m_mac.BlockUpdate(array2, 0, 16);
		m_mac.DoFinal(array2, 0);
		if (!TlsUtilities.ConstantTimeAreEqual(16, array2, 0, input, inputOffset + num))
		{
			throw new TlsFatalAlert(20);
		}
		m_cipher.ProcessBytes(input, inputOffset, num, output, outputOffset);
		return num;
	}

	public int GetOutputSize(int inputLength)
	{
		if (!m_isEncrypting)
		{
			return inputLength - 16;
		}
		return inputLength + 16;
	}

	public void Init(byte[] nonce, int macSize, byte[] additionalData)
	{
		if (nonce != null && nonce.Length == 12 && macSize == 16)
		{
			m_cipher.Init(m_isEncrypting, new ParametersWithIV(null, nonce));
			InitMac();
			if (additionalData == null)
			{
				m_additionalDataLength = 0;
				return;
			}
			m_additionalDataLength = additionalData.Length;
			UpdateMac(additionalData, 0, additionalData.Length);
			return;
		}
		throw new TlsFatalAlert(80);
	}

	public void SetKey(byte[] key, int keyOff, int keyLen)
	{
		KeyParameter parameters = new KeyParameter(key, keyOff, keyLen);
		m_cipher.Init(m_isEncrypting, new ParametersWithIV(parameters, Zeroes, 0, 12));
	}

	private void InitMac()
	{
		byte[] array = new byte[64];
		m_cipher.ProcessBytes(array, 0, 64, array, 0);
		m_mac.Init(new KeyParameter(array, 0, 32));
		Array.Clear(array, 0, array.Length);
	}

	private void UpdateMac(byte[] buf, int off, int len)
	{
		m_mac.BlockUpdate(buf, off, len);
		int num = len % 16;
		if (num != 0)
		{
			m_mac.BlockUpdate(Zeroes, 0, 16 - num);
		}
	}
}
