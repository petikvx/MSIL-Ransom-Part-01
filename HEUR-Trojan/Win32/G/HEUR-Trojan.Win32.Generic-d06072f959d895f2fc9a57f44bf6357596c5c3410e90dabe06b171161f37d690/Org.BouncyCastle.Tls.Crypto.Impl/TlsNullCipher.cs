using System;

namespace Org.BouncyCastle.Tls.Crypto.Impl;

public class TlsNullCipher : TlsCipher
{
	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly TlsSuiteHmac m_readMac;

	protected readonly TlsSuiteHmac m_writeMac;

	public virtual bool UsesOpaqueRecordType => false;

	public TlsNullCipher(TlsCryptoParameters cryptoParams, TlsHmac clientMac, TlsHmac serverMac)
	{
		if (TlsImplUtilities.IsTlsV13(cryptoParams))
		{
			throw new TlsFatalAlert(80);
		}
		m_cryptoParams = cryptoParams;
		int num = clientMac.MacLength + serverMac.MacLength;
		byte[] key = TlsImplUtilities.CalculateKeyBlock(cryptoParams, num);
		int num2 = 0;
		clientMac.SetKey(key, 0, clientMac.MacLength);
		num2 = 0 + clientMac.MacLength;
		serverMac.SetKey(key, num2, serverMac.MacLength);
		num2 += serverMac.MacLength;
		if (num2 != num)
		{
			throw new TlsFatalAlert(80);
		}
		if (cryptoParams.IsServer)
		{
			m_writeMac = new TlsSuiteHmac(cryptoParams, serverMac);
			m_readMac = new TlsSuiteHmac(cryptoParams, clientMac);
		}
		else
		{
			m_writeMac = new TlsSuiteHmac(cryptoParams, clientMac);
			m_readMac = new TlsSuiteHmac(cryptoParams, serverMac);
		}
	}

	public virtual int GetCiphertextDecodeLimit(int plaintextLimit)
	{
		return plaintextLimit + m_writeMac.Size;
	}

	public virtual int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
	{
		return plaintextLength + m_writeMac.Size;
	}

	public virtual int GetPlaintextLimit(int ciphertextLimit)
	{
		return ciphertextLimit - m_writeMac.Size;
	}

	public virtual TlsEncodeResult EncodePlaintext(long seqNo, short contentType, ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int offset, int len)
	{
		byte[] array = m_writeMac.CalculateMac(seqNo, contentType, plaintext, offset, len);
		byte[] array2 = new byte[headerAllocation + len + array.Length];
		Array.Copy(plaintext, offset, array2, headerAllocation, len);
		Array.Copy(array, 0, array2, headerAllocation + len, array.Length);
		return new TlsEncodeResult(array2, 0, array2.Length, contentType);
	}

	public virtual TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int offset, int len)
	{
		int size = m_readMac.Size;
		if (len < size)
		{
			throw new TlsFatalAlert(50);
		}
		int num = len - size;
		byte[] a = m_readMac.CalculateMac(seqNo, recordType, ciphertext, offset, num);
		if (!TlsUtilities.ConstantTimeAreEqual(size, a, 0, ciphertext, offset + num))
		{
			throw new TlsFatalAlert(20);
		}
		return new TlsDecodeResult(ciphertext, offset, num, recordType);
	}

	public virtual void RekeyDecoder()
	{
		throw new TlsFatalAlert(80);
	}

	public virtual void RekeyEncoder()
	{
		throw new TlsFatalAlert(80);
	}
}
