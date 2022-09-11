using System.Security.Cryptography;
using System.Text;

namespace Badboymnb;

public class KeyGenerator
{
	public static string GetUniqueKey(int maxSize)
	{
		char[] array = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
		byte[] array2 = new byte[1];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetNonZeroBytes(array2);
			array2 = new byte[maxSize];
			rNGCryptoServiceProvider.GetNonZeroBytes(array2);
		}
		StringBuilder stringBuilder = new StringBuilder(maxSize);
		byte[] array3 = array2;
		foreach (byte b in array3)
		{
			stringBuilder.Append(array[(int)b % array.Length]);
		}
		return stringBuilder.ToString();
	}
}
