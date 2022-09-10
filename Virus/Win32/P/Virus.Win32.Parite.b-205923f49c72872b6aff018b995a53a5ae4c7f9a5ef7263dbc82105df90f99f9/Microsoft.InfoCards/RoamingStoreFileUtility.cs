using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal sealed class RoamingStoreFileUtility
{
	private const int ENCRYPTIONKEYBUFFERSIZE = 32;

	private const int ENCRYPTIONKEYBITLENGTH = 256;

	private const int ENCRYPTIONIVBUFFERSIZE = 16;

	private const int ENCRYPTIONIVBITLENGTH = 128;

	private const int ITERATIONCOUNT = 1000;

	private const int SHA256_BUFFERSIZE = 32;

	private static readonly byte[] DerivedKeySignatureEntropy = new byte[16]
	{
		196, 1, 123, 241, 107, 173, 47, 66, 175, 244,
		151, 125, 4, 104, 3, 219
	};

	private static readonly byte[] DerivedKeyEncryptionEntropy = new byte[16]
	{
		217, 89, 123, 38, 30, 216, 179, 68, 147, 35,
		179, 150, 133, 222, 149, 252
	};

	public static int SaltLength => 16;

	private RoamingStoreFileUtility()
	{
	}

	public static int CalculateEncryptedSize(int decryptedLength)
	{
		int num = decryptedLength;
		num += 16 - num % 16;
		return num + 48;
	}

	public static int CalculateDecryptedSize(int encryptedLength)
	{
		return encryptedLength - 48;
	}

	public static void Decrypt(Stream source, Stream destination, string passwordString, byte[] salt)
	{
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		byte[] bytes = Encoding.Unicode.GetBytes(passwordString);
		byte[] encryptionKey;
		byte[] signatureKey;
		try
		{
			CreateKeyPair(bytes, salt, out encryptionKey, out signatureKey);
		}
		finally
		{
			Array.Clear(bytes, 0, bytes.Length);
		}
		try
		{
			byte[] array = new byte[16];
			if (array.Length != source.Read(array, 0, array.Length))
			{
				throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile")));
			}
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.BlockSize = array.Length * 8;
			rijndaelManaged.KeySize = encryptionKey.Length * 8;
			RijndaelManagedTransform val = (RijndaelManagedTransform)rijndaelManaged.CreateDecryptor(encryptionKey, array);
			try
			{
				using SHA256Managed sHA256Managed = new SHA256Managed();
				byte[] array2 = new byte[val.get_InputBlockSize()];
				byte[] array3 = null;
				byte[] array4 = new byte[val.get_OutputBlockSize()];
				byte[] array5 = null;
				byte[] array6 = new byte[sHA256Managed.HashSize / 8];
				using MemoryStream memoryStream = new MemoryStream(new byte[array.Length + encryptionKey.Length + val.get_OutputBlockSize()]);
				if (array6.Length != source.Read(array6, 0, array6.Length))
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile")));
				}
				memoryStream.Write(array, 0, array.Length);
				memoryStream.Write(signatureKey, 0, signatureKey.Length);
				int num = 0;
				int num2 = 0;
				while (source.Position < source.Length - array2.Length)
				{
					try
					{
						num = source.Read(array2, 0, array2.Length);
						num2 = val.TransformBlock(array2, 0, num, array4, 0);
						if (num2 > 0)
						{
							destination.Write(array4, 0, num2);
						}
					}
					finally
					{
						Array.Clear(array4, 0, array4.Length);
						Array.Clear(array2, 0, array2.Length);
					}
				}
				num = source.Read(array2, 0, array2.Length);
				array3 = val.TransformFinalBlock(array2, 0, num);
				destination.Write(array3, 0, array3.Length);
				memoryStream.Write(array3, array3.Length - val.get_OutputBlockSize(), val.get_OutputBlockSize());
				memoryStream.Flush();
				memoryStream.Seek(0L, SeekOrigin.Begin);
				array5 = sHA256Managed.ComputeHash(memoryStream);
				if (!CompareSignature(array5, array6))
				{
					throw InfoCardTrace.ThrowHelperError((Exception)(object)new ImportException(SR.GetString("InvalidImportFile")));
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		finally
		{
			Array.Clear(encryptionKey, 0, encryptionKey.Length);
			Array.Clear(signatureKey, 0, signatureKey.Length);
		}
	}

	public static void Encrypt(Stream source, Stream destination, string passwordString, out byte[] salt)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		salt = new byte[16];
		randomNumberGenerator.GetBytes(salt);
		byte[] bytes = Encoding.Unicode.GetBytes(passwordString);
		byte[] encryptionKey;
		byte[] signatureKey;
		try
		{
			CreateKeyPair(bytes, salt, out encryptionKey, out signatureKey);
		}
		finally
		{
			Array.Clear(bytes, 0, bytes.Length);
		}
		try
		{
			byte[] array = new byte[16];
			randomNumberGenerator.GetBytes(array);
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.BlockSize = array.Length * 8;
			rijndaelManaged.KeySize = encryptionKey.Length * 8;
			RijndaelManagedTransform val = (RijndaelManagedTransform)rijndaelManaged.CreateEncryptor(encryptionKey, array);
			try
			{
				using SHA256Managed sHA256Managed = new SHA256Managed();
				byte[] array2 = new byte[val.get_InputBlockSize()];
				byte[] array3 = null;
				byte[] array4 = new byte[val.get_OutputBlockSize()];
				byte[] array5 = null;
				byte[] array6 = new byte[array.Length + sHA256Managed.HashSize / 8];
				using MemoryStream memoryStream = new MemoryStream(new byte[array.Length + signatureKey.Length + val.get_InputBlockSize()]);
				memoryStream.Write(array, 0, array.Length);
				memoryStream.Write(signatureKey, 0, signatureKey.Length);
				try
				{
					destination.Write(array6, 0, array6.Length);
					int num = 0;
					int num2 = 0;
					while (source.Position < source.Length - array2.Length)
					{
						num = source.Read(array2, 0, array2.Length);
						try
						{
							num2 = val.TransformBlock(array2, 0, array2.Length, array4, 0);
							destination.Write(array4, 0, num2);
						}
						finally
						{
							Array.Clear(array2, 0, array2.Length);
							Array.Clear(array4, 0, array4.Length);
						}
					}
					num = source.Read(array2, 0, array2.Length);
					if (num != array2.Length)
					{
						byte[] array7 = new byte[array2.Length];
						source.Seek(source.Length - array2.Length, SeekOrigin.Begin);
						int num3 = source.Read(array7, 0, array7.Length);
						InfoCardTrace.Assert(num3 == array7.Length && array7.Length == array2.Length, "Should have read exactly 0x20 bytes", new object[0]);
						memoryStream.Write(array7, 0, array7.Length);
					}
					else
					{
						memoryStream.Write(array2, 0, array2.Length);
					}
					array3 = val.TransformFinalBlock(array2, 0, num);
					destination.Write(array3, 0, array3.Length);
					destination.Flush();
					memoryStream.Flush();
					memoryStream.Seek(0L, SeekOrigin.Begin);
					array5 = sHA256Managed.ComputeHash(memoryStream);
					Array.Copy(array, 0, array6, 0, array.Length);
					Array.Copy(array5, 0, array6, array.Length, array5.Length);
					destination.Seek(0L, SeekOrigin.Begin);
					destination.Write(array6, 0, array6.Length);
					destination.Flush();
					destination.Seek(0L, SeekOrigin.End);
				}
				finally
				{
					Array.Clear(array2, 0, array2.Length);
					Array.Clear(array4, 0, array4.Length);
					Array.Clear(array6, 0, array6.Length);
					if (array3 != null)
					{
						Array.Clear(array3, 0, array3.Length);
					}
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		finally
		{
			Array.Clear(encryptionKey, 0, encryptionKey.Length);
			Array.Clear(signatureKey, 0, signatureKey.Length);
		}
	}

	private static void CreateKeyPair(byte[] password, byte[] salt, out byte[] encryptionKey, out byte[] signatureKey)
	{
		byte[] sourceArray = DoPkcs5(password, salt);
		using SHA256Managed sHA256Managed = new SHA256Managed();
		byte[] array = new byte[32 + DerivedKeyEncryptionEntropy.Length];
		byte[] array2 = new byte[32 + DerivedKeySignatureEntropy.Length];
		Array.Copy(DerivedKeyEncryptionEntropy, 0, array, 0, DerivedKeyEncryptionEntropy.Length);
		Array.Copy(DerivedKeySignatureEntropy, 0, array2, 0, DerivedKeySignatureEntropy.Length);
		Array.Copy(sourceArray, 0, array, DerivedKeyEncryptionEntropy.Length, 32);
		Array.Copy(sourceArray, 0, array2, DerivedKeySignatureEntropy.Length, 32);
		encryptionKey = sHA256Managed.ComputeHash(array);
		signatureKey = sHA256Managed.ComputeHash(array2);
	}

	private static byte[] DoPkcs5(byte[] password, byte[] salt)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(password, salt, "SHA256", 1000);
		return passwordDeriveBytes.GetBytes(32);
	}

	internal static bool CompareSignature(byte[] input, byte[] expected)
	{
		if (input.Length == 0)
		{
			return false;
		}
		if (input.Length != expected.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < input.Length)
			{
				if (expected[num] != input[num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}
}
