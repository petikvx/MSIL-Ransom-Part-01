using System;
using System.IO;
using System.Security.Cryptography;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class PinProtectionHelper
{
	private const int InfoCardPKCS5IterationCount = 1000;

	public const int SaltSize = 16;

	private const int AESBlockByteLength = 16;

	private const int AESKeyByteLength = 32;

	private const byte EncryptForPinProtectionVersion = 2;

	private const int VersionOffset = 0;

	private const int SaltOffset = 1;

	private const int IterationsOffset = 17;

	private const int IVOffset = 21;

	private const int EncryptedDataOffset = 37;

	private PasswordDeriveBytes m_pkcs5;

	private byte[] m_key;

	private RijndaelManaged m_aes = new RijndaelManaged();

	public static int EncryptedMasterKeySize => 85;

	public PinProtectionHelper(string pin)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[16];
		rNGCryptoServiceProvider.GetBytes(array);
		m_pkcs5 = new PasswordDeriveBytes(pin, array, "SHA256", 1000);
		m_key = m_pkcs5.GetBytes(32);
		m_aes.Padding = PaddingMode.PKCS7;
		m_aes.Mode = CipherMode.CBC;
		m_aes.BlockSize = 128;
		m_aes.KeySize = m_key.Length * 8;
		m_aes.GenerateIV();
	}

	public PinProtectionHelper(string pin, byte[] serializedParameters)
	{
		if (2 != serializedParameters[0])
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceCardDecryptionFailed")));
		}
		byte[] array = new byte[16];
		Array.Copy(serializedParameters, 1, array, 0, 16);
		uint iterations = BitConverter.ToUInt32(serializedParameters, 17);
		m_pkcs5 = new PasswordDeriveBytes(pin, array, "SHA256", (int)iterations);
		m_key = m_pkcs5.GetBytes(32);
		m_aes.Padding = PaddingMode.PKCS7;
		m_aes.Mode = CipherMode.CBC;
		m_aes.BlockSize = 128;
		m_aes.KeySize = m_key.Length * 8;
		byte[] array2 = new byte[16];
		Array.Copy(serializedParameters, 21, array2, 0, array2.Length);
		m_aes.IV = array2;
	}

	public byte[] EncryptMasterKey(byte[] toEncrypt)
	{
		byte[] array = Encrypt(toEncrypt);
		using MemoryStream memoryStream = new MemoryStream();
		memoryStream.WriteByte(2);
		memoryStream.Write(m_pkcs5.Salt, 0, m_pkcs5.Salt!.Length);
		memoryStream.Write(BitConverter.GetBytes((uint)m_pkcs5.IterationCount), 0, 4);
		memoryStream.Write(m_aes.IV, 0, m_aes.IV.Length);
		memoryStream.Write(array, 0, array.Length);
		return memoryStream.ToArray();
	}

	public byte[] Encrypt(byte[] toEncrypt)
	{
		using ICryptoTransform transform = m_aes.CreateEncryptor(m_key, m_aes.IV);
		using MemoryStream memoryStream = new MemoryStream();
		try
		{
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(toEncrypt, 0, toEncrypt.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch (CryptographicException inner)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceCardEncryptionFailed"), inner));
		}
	}

	public byte[] DecryptMasterKey(byte[] toDecrypt)
	{
		byte[] array = new byte[toDecrypt.Length - 37];
		Array.Copy(toDecrypt, 37, array, 0, toDecrypt.Length - 37);
		return Decrypt(array);
	}

	public byte[] Decrypt(byte[] encrypted)
	{
		using ICryptoTransform transform = m_aes.CreateDecryptor(m_key, m_aes.IV);
		using MemoryStream stream = new MemoryStream(encrypted);
		try
		{
			using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			byte[] array = new byte[encrypted.Length];
			int num = cryptoStream.Read(array, 0, array.Length);
			byte[] array2 = new byte[num];
			Array.Copy(array, array2, num);
			return array2;
		}
		catch (CryptographicException inner)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new InvalidCardException(SR.GetString("ServiceCardDecryptionFailed"), inner));
		}
	}
}
