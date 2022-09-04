using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace winini;

public class _3des
{
	[DebuggerNonUserCode]
	public _3des()
	{
	}

	public static string a(string b, string c, bool d)
	{
		byte[] array = Convert.FromBase64String(b);
		byte[] key;
		if (d)
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(c));
		}
		else
		{
			key = Encoding.UTF8.GetBytes(c);
		}
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
		byte[] bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		return Encoding.UTF8.GetString(bytes);
	}
}
