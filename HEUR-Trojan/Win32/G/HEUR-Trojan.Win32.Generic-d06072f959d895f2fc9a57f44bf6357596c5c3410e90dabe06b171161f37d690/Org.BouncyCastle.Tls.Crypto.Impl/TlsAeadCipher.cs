using System;
using System.IO;

namespace Org.BouncyCastle.Tls.Crypto.Impl;

public class TlsAeadCipher : TlsCipher
{
	public const int AEAD_CCM = 1;

	public const int AEAD_CHACHA20_POLY1305 = 2;

	public const int AEAD_GCM = 3;

	private const int NONCE_RFC5288 = 1;

	private const int NONCE_RFC7905 = 2;

	protected readonly TlsCryptoParameters m_cryptoParams;

	protected readonly int m_keySize;

	protected readonly int m_macSize;

	protected readonly int m_fixed_iv_length;

	protected readonly int m_record_iv_length;

	protected readonly TlsAeadCipherImpl m_decryptCipher;

	protected readonly TlsAeadCipherImpl m_encryptCipher;

	protected readonly byte[] m_decryptNonce;

	protected readonly byte[] m_encryptNonce;

	protected readonly bool m_isTlsV13;

	protected readonly int m_nonceMode;

	public virtual bool UsesOpaqueRecordType => m_isTlsV13;

	public TlsAeadCipher(TlsCryptoParameters cryptoParams, TlsAeadCipherImpl encryptCipher, TlsAeadCipherImpl decryptCipher, int keySize, int macSize, int aeadType)
	{
		SecurityParameters securityParameters = cryptoParams.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		if (!TlsImplUtilities.IsTlsV12(negotiatedVersion))
		{
			throw new TlsFatalAlert(80);
		}
		m_isTlsV13 = TlsImplUtilities.IsTlsV13(negotiatedVersion);
		m_nonceMode = GetNonceMode(m_isTlsV13, aeadType);
		switch (m_nonceMode)
		{
		default:
			throw new TlsFatalAlert(80);
		case 2:
			m_fixed_iv_length = 12;
			m_record_iv_length = 0;
			break;
		case 1:
			m_fixed_iv_length = 4;
			m_record_iv_length = 8;
			break;
		}
		m_cryptoParams = cryptoParams;
		m_keySize = keySize;
		m_macSize = macSize;
		m_decryptCipher = decryptCipher;
		m_encryptCipher = encryptCipher;
		m_decryptNonce = new byte[m_fixed_iv_length];
		m_encryptNonce = new byte[m_fixed_iv_length];
		bool isServer = cryptoParams.IsServer;
		if (m_isTlsV13)
		{
			RekeyCipher(securityParameters, decryptCipher, m_decryptNonce, !isServer);
			RekeyCipher(securityParameters, encryptCipher, m_encryptNonce, isServer);
			return;
		}
		int num = 2 * keySize + 2 * m_fixed_iv_length;
		byte[] array = TlsImplUtilities.CalculateKeyBlock(cryptoParams, num);
		int num2 = 0;
		if (isServer)
		{
			decryptCipher.SetKey(array, num2, keySize);
			num2 += keySize;
			encryptCipher.SetKey(array, num2, keySize);
			num2 += keySize;
			Array.Copy(array, num2, m_decryptNonce, 0, m_fixed_iv_length);
			num2 += m_fixed_iv_length;
			Array.Copy(array, num2, m_encryptNonce, 0, m_fixed_iv_length);
			num2 += m_fixed_iv_length;
		}
		else
		{
			encryptCipher.SetKey(array, num2, keySize);
			num2 += keySize;
			decryptCipher.SetKey(array, num2, keySize);
			num2 += keySize;
			Array.Copy(array, num2, m_encryptNonce, 0, m_fixed_iv_length);
			num2 += m_fixed_iv_length;
			Array.Copy(array, num2, m_decryptNonce, 0, m_fixed_iv_length);
			num2 += m_fixed_iv_length;
		}
		if (num != num2)
		{
			throw new TlsFatalAlert(80);
		}
		byte[] array2 = new byte[m_fixed_iv_length + m_record_iv_length];
		array2[0] = (byte)(~m_encryptNonce[0]);
		array2[1] = (byte)(~m_decryptNonce[1]);
		encryptCipher.Init(array2, macSize, null);
		decryptCipher.Init(array2, macSize, null);
	}

	public virtual int GetCiphertextDecodeLimit(int plaintextLimit)
	{
		return plaintextLimit + m_macSize + m_record_iv_length + (m_isTlsV13 ? 1 : 0);
	}

	public virtual int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
	{
		int num = plaintextLength;
		if (m_isTlsV13)
		{
			num = 1 + System.Math.Min(plaintextLimit, plaintextLength + 0);
		}
		return num + m_macSize + m_record_iv_length;
	}

	public virtual int GetPlaintextLimit(int ciphertextLimit)
	{
		return ciphertextLimit - m_macSize - m_record_iv_length - (m_isTlsV13 ? 1 : 0);
	}

	public virtual TlsEncodeResult EncodePlaintext(long seqNo, short contentType, ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int plaintextOffset, int plaintextLength)
	{
		byte[] array = new byte[m_encryptNonce.Length + m_record_iv_length];
		switch (m_nonceMode)
		{
		default:
			throw new TlsFatalAlert(80);
		case 2:
		{
			TlsUtilities.WriteUint64(seqNo, array, array.Length - 8);
			for (int i = 0; i < m_encryptNonce.Length; i++)
			{
				array[i] ^= m_encryptNonce[i];
			}
			break;
		}
		case 1:
			Array.Copy(m_encryptNonce, 0, array, 0, m_encryptNonce.Length);
			TlsUtilities.WriteUint64(seqNo, array, m_encryptNonce.Length);
			break;
		}
		int num = (m_isTlsV13 ? 1 : 0);
		int outputSize = m_encryptCipher.GetOutputSize(plaintextLength + num);
		int num2 = m_record_iv_length + outputSize;
		byte[] array2 = new byte[headerAllocation + num2];
		int num3 = headerAllocation;
		if (m_record_iv_length != 0)
		{
			Array.Copy(array, array.Length - m_record_iv_length, array2, num3, m_record_iv_length);
			num3 += m_record_iv_length;
		}
		short recordType = (short)(m_isTlsV13 ? 23 : contentType);
		byte[] additionalData = GetAdditionalData(seqNo, recordType, recordVersion, num2, plaintextLength);
		try
		{
			m_encryptCipher.Init(array, m_macSize, additionalData);
			Array.Copy(plaintext, plaintextOffset, array2, num3, plaintextLength);
			if (m_isTlsV13)
			{
				array2[num3 + plaintextLength] = (byte)contentType;
			}
			num3 += m_encryptCipher.DoFinal(array2, num3, plaintextLength + num, array2, num3);
		}
		catch (IOException ex)
		{
			throw ex;
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(80, alertCause);
		}
		if (num3 != array2.Length)
		{
			throw new TlsFatalAlert(80);
		}
		return new TlsEncodeResult(array2, 0, array2.Length, recordType);
	}

	public virtual TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int ciphertextOffset, int ciphertextLength)
	{
		if (GetPlaintextLimit(ciphertextLength) < 0)
		{
			throw new TlsFatalAlert(50);
		}
		byte[] array = new byte[m_decryptNonce.Length + m_record_iv_length];
		switch (m_nonceMode)
		{
		default:
			throw new TlsFatalAlert(80);
		case 2:
		{
			TlsUtilities.WriteUint64(seqNo, array, array.Length - 8);
			for (int i = 0; i < m_decryptNonce.Length; i++)
			{
				array[i] ^= m_decryptNonce[i];
			}
			break;
		}
		case 1:
			Array.Copy(m_decryptNonce, 0, array, 0, m_decryptNonce.Length);
			Array.Copy(ciphertext, ciphertextOffset, array, array.Length - m_record_iv_length, m_record_iv_length);
			break;
		}
		int num = ciphertextOffset + m_record_iv_length;
		int inputLength = ciphertextLength - m_record_iv_length;
		int num2 = m_decryptCipher.GetOutputSize(inputLength);
		byte[] additionalData = GetAdditionalData(seqNo, recordType, recordVersion, ciphertextLength, num2);
		int num3;
		try
		{
			m_decryptCipher.Init(array, m_macSize, additionalData);
			num3 = m_decryptCipher.DoFinal(ciphertext, num, inputLength, ciphertext, num);
		}
		catch (IOException ex)
		{
			throw ex;
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(20, alertCause);
		}
		if (num3 != num2)
		{
			throw new TlsFatalAlert(80);
		}
		short contentType = recordType;
		if (m_isTlsV13)
		{
			int num4 = num2;
			byte b;
			do
			{
				if (--num4 >= 0)
				{
					b = ciphertext[num + num4];
					continue;
				}
				throw new TlsFatalAlert(10);
			}
			while (b == 0);
			contentType = (short)(b & 0xFF);
			num2 = num4;
		}
		return new TlsDecodeResult(ciphertext, num, num2, contentType);
	}

	public virtual void RekeyDecoder()
	{
		RekeyCipher(m_cryptoParams.SecurityParameters, m_decryptCipher, m_decryptNonce, !m_cryptoParams.IsServer);
	}

	public virtual void RekeyEncoder()
	{
		RekeyCipher(m_cryptoParams.SecurityParameters, m_encryptCipher, m_encryptNonce, m_cryptoParams.IsServer);
	}

	protected virtual byte[] GetAdditionalData(long seqNo, short recordType, ProtocolVersion recordVersion, int ciphertextLength, int plaintextLength)
	{
		if (m_isTlsV13)
		{
			byte[] array = new byte[5];
			TlsUtilities.WriteUint8(recordType, array, 0);
			TlsUtilities.WriteVersion(recordVersion, array, 1);
			TlsUtilities.WriteUint16(ciphertextLength, array, 3);
			return array;
		}
		byte[] array2 = new byte[13];
		TlsUtilities.WriteUint64(seqNo, array2, 0);
		TlsUtilities.WriteUint8(recordType, array2, 8);
		TlsUtilities.WriteVersion(recordVersion, array2, 9);
		TlsUtilities.WriteUint16(plaintextLength, array2, 11);
		return array2;
	}

	protected virtual void RekeyCipher(SecurityParameters securityParameters, TlsAeadCipherImpl cipher, byte[] nonce, bool serverSecret)
	{
		if (!m_isTlsV13)
		{
			throw new TlsFatalAlert(80);
		}
		TlsSecret tlsSecret = (serverSecret ? securityParameters.TrafficSecretServer : securityParameters.TrafficSecretClient);
		if (tlsSecret == null)
		{
			throw new TlsFatalAlert(80);
		}
		Setup13Cipher(cipher, nonce, tlsSecret, securityParameters.PrfCryptoHashAlgorithm);
	}

	protected virtual void Setup13Cipher(TlsAeadCipherImpl cipher, byte[] nonce, TlsSecret secret, int cryptoHashAlgorithm)
	{
		byte[] key = TlsCryptoUtilities.HkdfExpandLabel(secret, cryptoHashAlgorithm, "key", TlsUtilities.EmptyBytes, m_keySize).Extract();
		byte[] array = TlsCryptoUtilities.HkdfExpandLabel(secret, cryptoHashAlgorithm, "iv", TlsUtilities.EmptyBytes, m_fixed_iv_length).Extract();
		cipher.SetKey(key, 0, m_keySize);
		Array.Copy(array, 0, nonce, 0, m_fixed_iv_length);
		array[0] ^= 128;
		cipher.Init(array, m_macSize, null);
	}

	private static int GetNonceMode(bool isTLSv13, int aeadType)
	{
		switch (aeadType)
		{
		default:
			throw new TlsFatalAlert(80);
		case 2:
			return 2;
		case 1:
		case 3:
			if (!isTLSv13)
			{
				return 1;
			}
			return 2;
		}
	}
}
