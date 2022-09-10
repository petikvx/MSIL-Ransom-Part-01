using System;
using System.Security.Cryptography;
using System.Text;

public class SSTCryptographer
{
	private static string _key;

	public static string Key
	{
		set
		{
			_key = value;
		}
	}

	public static string Encrypt(string strToEncrypt)
	{
		try
		{
			return Encrypt(strToEncrypt, _key);
		}
		catch (Exception ex)
		{
			return "Wrong Input. " + ex.Message;
		}
	}

	public static string Decrypt(string strEncrypted)
	{
		try
		{
			return Decrypt(strEncrypted, _key);
		}
		catch (Exception ex)
		{
			return "Wrong Input. " + ex.Message;
		}
	}

	public static string Encrypt(string strToEncrypt, string strKey)
	{
		try
		{
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(strKey));
			mD5CryptoServiceProvider = null;
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			byte[] bytes = Encoding.ASCII.GetBytes(strToEncrypt);
			return Convert.ToBase64String(tripleDESCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
		}
		catch (Exception ex)
		{
			return "Wrong Input. " + ex.Message;
		}
	}

	public static string Decrypt(string strEncrypted, string strKey)
	{
		try
		{
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(strKey));
			mD5CryptoServiceProvider = null;
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			byte[] array = Convert.FromBase64String(strEncrypted);
			string @string = Encoding.ASCII.GetString(tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 0, array.Length));
			tripleDESCryptoServiceProvider = null;
			return @string;
		}
		catch (Exception ex)
		{
			return "Wrong Input. " + ex.Message;
		}
	}
}
