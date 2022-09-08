using System.Security.Cryptography;
using System.Text;

internal class rhpx
{
	internal static byte[] brqu(byte[] chvr)
	{
		using TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array2 = (tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes("Fnonuqpysrzdbrotqtqffezr")));
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		return tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(chvr, 0, chvr.Length);
	}
}
