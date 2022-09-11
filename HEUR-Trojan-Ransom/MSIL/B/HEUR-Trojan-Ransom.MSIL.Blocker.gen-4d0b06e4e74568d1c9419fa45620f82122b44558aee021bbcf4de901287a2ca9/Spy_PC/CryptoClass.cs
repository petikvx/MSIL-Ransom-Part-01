using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Spy_PC;

internal class CryptoClass
{
	protected RijndaelManaged myRijndael;

	private static string encryptionKey = "142eb4a7ab52dbfb971e18daed7056488446b4b2167cf61187f4bbc60fc9d96d";

	private static string initialisationVector = "26744a68b53dd87bb395584c00f7290a";

	protected static readonly CryptoClass _instance = new CryptoClass();

	public static CryptoClass Instance => _instance;

	public string DecryptText(string encryptedString)
	{
		using (myRijndael = new RijndaelManaged())
		{
			myRijndael.Key = HexStringToByte(encryptionKey);
			myRijndael.IV = HexStringToByte(initialisationVector);
			myRijndael.Mode = CipherMode.CBC;
			myRijndael.Padding = PaddingMode.PKCS7;
			byte[] cipherText = Convert.FromBase64String(encryptedString);
			return DecryptStringFromBytes(cipherText, myRijndael.Key, myRijndael.IV);
		}
	}

	public string EncryptText(string plainText)
	{
		using (myRijndael = new RijndaelManaged())
		{
			myRijndael.Key = HexStringToByte(encryptionKey);
			myRijndael.IV = HexStringToByte(initialisationVector);
			myRijndael.Mode = CipherMode.CBC;
			myRijndael.Padding = PaddingMode.PKCS7;
			return Convert.ToBase64String(EncryptStringToBytes(plainText, myRijndael.Key, myRijndael.IV));
		}
	}

	protected byte[] EncryptStringToBytes(string plainText, byte[] Key, byte[] IV)
	{
		if (plainText != null && plainText.Length > 0)
		{
			if (Key != null && Key.Length != 0)
			{
				if (IV != null && IV.Length != 0)
				{
					using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
					{
						rijndaelManaged.Key = Key;
						rijndaelManaged.IV = IV;
						ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
						using MemoryStream memoryStream = new MemoryStream();
						using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						using (StreamWriter streamWriter = new StreamWriter(stream))
						{
							streamWriter.Write(plainText);
						}
						return memoryStream.ToArray();
					}
				}
				throw new ArgumentNullException("Key");
			}
			throw new ArgumentNullException("Key");
		}
		throw new ArgumentNullException("plainText");
	}

	protected string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
	{
		if (cipherText != null && cipherText.Length != 0)
		{
			if (Key != null && Key.Length != 0)
			{
				if (IV != null && IV.Length != 0)
				{
					string text = null;
					using RijndaelManaged rijndaelManaged = new RijndaelManaged();
					rijndaelManaged.Key = Key;
					rijndaelManaged.IV = IV;
					ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
					using MemoryStream stream = new MemoryStream(cipherText);
					using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
					using StreamReader streamReader = new StreamReader(stream2);
					return streamReader.ReadToEnd();
				}
				throw new ArgumentNullException("Key");
			}
			throw new ArgumentNullException("Key");
		}
		throw new ArgumentNullException("cipherText");
	}

	public static void GenerateKeyAndIV()
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Mode = CipherMode.CBC;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		rijndaelManaged.GenerateIV();
		rijndaelManaged.GenerateKey();
		ByteArrayToHexString(rijndaelManaged.Key);
		ByteArrayToHexString(rijndaelManaged.IV);
	}

	protected static byte[] HexStringToByte(string hexString)
	{
		try
		{
			int num = hexString.Length / 2;
			byte[] array = new byte[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
			}
			return array;
		}
		catch
		{
			throw;
		}
	}

	public static string ByteArrayToHexString(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
		foreach (byte b in ba)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}
}
