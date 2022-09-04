using System.Security.Cryptography;
using System.Text;

namespace WindowsFormsApp30;

internal class Lady
{
	internal static byte[] Buffer(byte[] data)
	{
		byte[] bytes = Encoding.UTF8.GetBytes("Bkvmsbq");
		using TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array2 = (tripleDESCryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(bytes));
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		return tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(data, 0, data.Length);
	}
}
