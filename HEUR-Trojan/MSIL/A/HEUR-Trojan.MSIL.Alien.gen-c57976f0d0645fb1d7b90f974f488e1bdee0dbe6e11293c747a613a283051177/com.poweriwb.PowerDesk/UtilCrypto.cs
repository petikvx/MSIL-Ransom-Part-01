using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace com.poweriwb.PowerDesk;

internal class UtilCrypto
{
	private static byte[] _salt = Encoding.ASCII.GetBytes("605C9CC5-2527-4108-A548-173967538E7A");

	public static string EncryptStringAES(string plainText, string sharedSecret)
	{
		if (string.IsNullOrEmpty(plainText))
		{
			throw new ArgumentNullException("plainText");
		}
		if (string.IsNullOrEmpty(sharedSecret))
		{
			throw new ArgumentNullException("sharedSecret");
		}
		string result = null;
		RijndaelManaged rijndaelManaged = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(sharedSecret, _salt);
			rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			ICryptoTransform transform = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			using MemoryStream memoryStream = new MemoryStream();
			memoryStream.Write(BitConverter.GetBytes(rijndaelManaged.IV.Length), 0, 4);
			memoryStream.Write(rijndaelManaged.IV, 0, rijndaelManaged.IV.Length);
			using (CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
			{
				using StreamWriter streamWriter = new StreamWriter(stream);
				streamWriter.Write(plainText);
			}
			result = Convert.ToBase64String(memoryStream.ToArray());
		}
		finally
		{
			rijndaelManaged?.Clear();
		}
		return result;
	}

	public static string DecryptStringAES(string cipherText, string sharedSecret)
	{
		if (string.IsNullOrEmpty(cipherText))
		{
			throw new ArgumentNullException("cipherText");
		}
		if (string.IsNullOrEmpty(sharedSecret))
		{
			throw new ArgumentNullException("sharedSecret");
		}
		RijndaelManaged rijndaelManaged = null;
		string result = null;
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(sharedSecret, _salt);
			byte[] buffer = Convert.FromBase64String(cipherText);
			using MemoryStream memoryStream = new MemoryStream(buffer);
			rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = ReadByteArray(memoryStream);
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
			using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
			using StreamReader streamReader = new StreamReader(stream);
			try
			{
				result = streamReader.ReadToEnd();
			}
			catch (CryptographicException)
			{
				result = "";
			}
			catch (Exception)
			{
				result = "";
			}
		}
		catch (FormatException)
		{
			result = "";
		}
		finally
		{
			rijndaelManaged?.Clear();
		}
		return result;
	}

	private static byte[] ReadByteArray(Stream s)
	{
		byte[] array = new byte[4];
		if (s.Read(array, 0, array.Length) != array.Length)
		{
			throw new SystemException("Stream did not contain properly formatted byte array");
		}
		byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
		if (s.Read(array2, 0, array2.Length) != array2.Length)
		{
			throw new SystemException("Did not read byte array properly");
		}
		return array2;
	}
}
