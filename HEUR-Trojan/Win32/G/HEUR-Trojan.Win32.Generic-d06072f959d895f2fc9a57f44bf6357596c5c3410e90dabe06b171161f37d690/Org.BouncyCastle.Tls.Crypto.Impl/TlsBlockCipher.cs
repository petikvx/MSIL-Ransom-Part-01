using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl;

public class TlsBlockCipher : TlsCipher
{
	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly byte[] m_randomData;

	protected readonly bool m_encryptThenMac;

	protected readonly bool m_useExplicitIV;

	protected readonly bool m_acceptExtraPadding;

	protected readonly bool m_useExtraPadding;

	protected readonly TlsBlockCipherImpl m_decryptCipher;

	protected readonly TlsBlockCipherImpl m_encryptCipher;

	protected readonly TlsSuiteMac m_readMac;

	protected readonly TlsSuiteMac m_writeMac;

	public virtual bool UsesOpaqueRecordType => false;

	public TlsBlockCipher(TlsCryptoParameters cryptoParams, TlsBlockCipherImpl encryptCipher, TlsBlockCipherImpl decryptCipher, TlsHmac clientMac, TlsHmac serverMac, int cipherKeySize)
	{
		SecurityParameters securityParameters = cryptoParams.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		if (TlsImplUtilities.IsTlsV13(negotiatedVersion))
		{
			throw new TlsFatalAlert(80);
		}
		m_cryptoParams = cryptoParams;
		m_randomData = cryptoParams.NonceGenerator.GenerateNonce(256);
		m_encryptThenMac = securityParameters.IsEncryptThenMac;
		m_useExplicitIV = TlsImplUtilities.IsTlsV11(negotiatedVersion);
		m_acceptExtraPadding = !negotiatedVersion.IsSsl;
		m_useExtraPadding = securityParameters.IsExtendedPadding && ProtocolVersion.TLSv10.IsEqualOrEarlierVersionOf(negotiatedVersion) && (m_encryptThenMac || !securityParameters.IsTruncatedHmac);
		m_encryptCipher = encryptCipher;
		m_decryptCipher = decryptCipher;
		TlsBlockCipherImpl tlsBlockCipherImpl;
		TlsBlockCipherImpl tlsBlockCipherImpl2;
		if (cryptoParams.IsServer)
		{
			tlsBlockCipherImpl = decryptCipher;
			tlsBlockCipherImpl2 = encryptCipher;
		}
		else
		{
			tlsBlockCipherImpl = encryptCipher;
			tlsBlockCipherImpl2 = decryptCipher;
		}
		int num = 2 * cipherKeySize + clientMac.MacLength + serverMac.MacLength;
		if (!m_useExplicitIV)
		{
			num += tlsBlockCipherImpl.GetBlockSize() + tlsBlockCipherImpl2.GetBlockSize();
		}
		byte[] array = TlsImplUtilities.CalculateKeyBlock(cryptoParams, num);
		int num2 = 0;
		clientMac.SetKey(array, 0, clientMac.MacLength);
		num2 = 0 + clientMac.MacLength;
		serverMac.SetKey(array, num2, serverMac.MacLength);
		num2 += serverMac.MacLength;
		tlsBlockCipherImpl.SetKey(array, num2, cipherKeySize);
		num2 += cipherKeySize;
		tlsBlockCipherImpl2.SetKey(array, num2, cipherKeySize);
		num2 += cipherKeySize;
		int blockSize = tlsBlockCipherImpl.GetBlockSize();
		int blockSize2 = tlsBlockCipherImpl2.GetBlockSize();
		if (m_useExplicitIV)
		{
			tlsBlockCipherImpl.Init(new byte[blockSize], 0, blockSize);
			tlsBlockCipherImpl2.Init(new byte[blockSize2], 0, blockSize2);
		}
		else
		{
			tlsBlockCipherImpl.Init(array, num2, blockSize);
			num2 += blockSize;
			tlsBlockCipherImpl2.Init(array, num2, blockSize2);
			num2 += blockSize2;
		}
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
		int blockSize = m_decryptCipher.GetBlockSize();
		int size = m_readMac.Size;
		return GetCiphertextLength(blockSize, size, 256, plaintextLimit);
	}

	public virtual int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
	{
		int blockSize = m_encryptCipher.GetBlockSize();
		int size = m_writeMac.Size;
		int maxPadding = (m_useExtraPadding ? 256 : blockSize);
		return GetCiphertextLength(blockSize, size, maxPadding, plaintextLength);
	}

	public virtual int GetPlaintextLimit(int ciphertextLimit)
	{
		int blockSize = m_encryptCipher.GetBlockSize();
		int size = m_writeMac.Size;
		int num = ciphertextLimit;
		if (m_encryptThenMac)
		{
			num -= size;
			num -= num % blockSize;
		}
		else
		{
			num -= num % blockSize;
			num -= size;
		}
		num--;
		if (m_useExplicitIV)
		{
			num -= blockSize;
		}
		return num;
	}

	public virtual TlsEncodeResult EncodePlaintext(long seqNo, short contentType, ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int offset, int len)
	{
		int blockSize = m_encryptCipher.GetBlockSize();
		int size = m_writeMac.Size;
		int num = len;
		if (!m_encryptThenMac)
		{
			num += size;
		}
		int num2 = blockSize - num % blockSize;
		if (m_useExtraPadding)
		{
			int max = (256 - num2) / blockSize;
			int num3 = ChooseExtraPadBlocks(max);
			num2 += num3 * blockSize;
		}
		int num4 = len + size + num2;
		if (m_useExplicitIV)
		{
			num4 += blockSize;
		}
		byte[] array = new byte[headerAllocation + num4];
		int num5 = headerAllocation;
		if (m_useExplicitIV)
		{
			Array.Copy(m_cryptoParams.NonceGenerator.GenerateNonce(blockSize), 0, array, num5, blockSize);
			num5 += blockSize;
		}
		Array.Copy(plaintext, offset, array, num5, len);
		num5 += len;
		if (!m_encryptThenMac)
		{
			byte[] array2 = m_writeMac.CalculateMac(seqNo, contentType, plaintext, offset, len);
			Array.Copy(array2, 0, array, num5, array2.Length);
			num5 += array2.Length;
		}
		byte b = (byte)(num2 - 1);
		for (int i = 0; i < num2; i++)
		{
			array[num5++] = b;
		}
		m_encryptCipher.DoFinal(array, headerAllocation, num5 - headerAllocation, array, headerAllocation);
		if (m_encryptThenMac)
		{
			byte[] array3 = m_writeMac.CalculateMac(seqNo, contentType, array, headerAllocation, num5 - headerAllocation);
			Array.Copy(array3, 0, array, num5, array3.Length);
			num5 += array3.Length;
		}
		if (num5 != array.Length)
		{
			throw new TlsFatalAlert(80);
		}
		return new TlsEncodeResult(array, 0, array.Length, contentType);
	}

	public virtual TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int offset, int len)
	{
		int blockSize = m_decryptCipher.GetBlockSize();
		int size = m_readMac.Size;
		int num = blockSize;
		num = ((!m_encryptThenMac) ? System.Math.Max(num, size + 1) : (num + size));
		if (m_useExplicitIV)
		{
			num += blockSize;
		}
		if (len < num)
		{
			throw new TlsFatalAlert(50);
		}
		int num2 = len;
		if (m_encryptThenMac)
		{
			num2 -= size;
		}
		if (num2 % blockSize != 0)
		{
			throw new TlsFatalAlert(21);
		}
		if (m_encryptThenMac)
		{
			byte[] a = m_readMac.CalculateMac(seqNo, recordType, ciphertext, offset, len - size);
			if (!TlsUtilities.ConstantTimeAreEqual(size, a, 0, ciphertext, offset + len - size))
			{
				throw new TlsFatalAlert(20);
			}
		}
		m_decryptCipher.DoFinal(ciphertext, offset, num2, ciphertext, offset);
		if (m_useExplicitIV)
		{
			offset += blockSize;
			num2 -= blockSize;
		}
		int num3 = CheckPaddingConstantTime(ciphertext, offset, num2, blockSize, (!m_encryptThenMac) ? size : 0);
		bool flag = num3 == 0;
		int num4 = num2 - num3;
		if (!m_encryptThenMac)
		{
			num4 -= size;
			byte[] a2 = m_readMac.CalculateMacConstantTime(seqNo, recordType, ciphertext, offset, num4, num2 - size, m_randomData);
			flag |= !TlsUtilities.ConstantTimeAreEqual(size, a2, 0, ciphertext, offset + num4);
		}
		if (flag)
		{
			throw new TlsFatalAlert(20);
		}
		return new TlsDecodeResult(ciphertext, offset, num4, recordType);
	}

	public virtual void RekeyDecoder()
	{
		throw new TlsFatalAlert(80);
	}

	public virtual void RekeyEncoder()
	{
		throw new TlsFatalAlert(80);
	}

	protected virtual int CheckPaddingConstantTime(byte[] buf, int off, int len, int blockSize, int macSize)
	{
		int num = off + len;
		byte b = buf[num - 1];
		int num2 = (b & 0xFF) + 1;
		int num3 = 0;
		byte b2 = 0;
		int num4 = System.Math.Min(m_acceptExtraPadding ? 256 : blockSize, len - macSize);
		if (num2 > num4)
		{
			num2 = 0;
		}
		else
		{
			int num5 = num - num2;
			do
			{
				b2 = (byte)(b2 | (byte)(buf[num5++] ^ b));
			}
			while (num5 < num);
			num3 = num2;
			if (b2 != 0)
			{
				num2 = 0;
			}
		}
		byte[] randomData = m_randomData;
		while (num3 < 256)
		{
			b2 = (byte)(b2 | (byte)(randomData[num3++] ^ b));
		}
		randomData[0] ^= b2;
		return num2;
	}

	protected virtual int ChooseExtraPadBlocks(int max)
	{
		return System.Math.Min(Integers.NumberOfTrailingZeros((int)Pack.LE_To_UInt32(m_cryptoParams.NonceGenerator.GenerateNonce(4), 0)), max);
	}

	protected virtual int GetCiphertextLength(int blockSize, int macSize, int maxPadding, int plaintextLength)
	{
		int num = plaintextLength;
		if (m_useExplicitIV)
		{
			num += blockSize;
		}
		num += maxPadding;
		if (m_encryptThenMac)
		{
			num -= num % blockSize;
			return num + macSize;
		}
		num += macSize;
		return num - num % blockSize;
	}
}
