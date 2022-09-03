using System;
using System.Security.Cryptography;
using System.Text;

internal class Class8
{
	public static string smethod_0(string string_0, string string_1)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		byte[] inArray;
		using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
		{
			byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(string_1));
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			using TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider2 = tripleDESCryptoServiceProvider;
			byte[] bytes = uTF8Encoding.GetBytes(string_0);
			try
			{
				ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider2.CreateEncryptor();
				inArray = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
			}
			finally
			{
				tripleDESCryptoServiceProvider2.Clear();
				mD5CryptoServiceProvider.Clear();
			}
		}
		return Convert.ToBase64String(inArray);
	}

	public static string smethod_1(string string_0, string string_1)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		byte[] bytes;
		using (MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider())
		{
			byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes(string_1));
			TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
			tripleDESCryptoServiceProvider.Key = key;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			using TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider2 = tripleDESCryptoServiceProvider;
			byte[] array = Convert.FromBase64String(string_0);
			try
			{
				ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider2.CreateDecryptor();
				bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
			}
			finally
			{
				tripleDESCryptoServiceProvider2.Clear();
				mD5CryptoServiceProvider.Clear();
			}
		}
		return uTF8Encoding.GetString(bytes);
	}
}
