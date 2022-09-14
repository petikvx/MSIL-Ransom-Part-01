using System;
using System.Security.Cryptography;

namespace nVxbvhuaKzC;

public sealed class xOLdYONpbhA
{
	private static int yuPQZVWInZx = 8;

	public static string aIfVeJYRUUj(int int_0)
	{
		try
		{
			byte[] array = new byte[int_0];
			using (RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider())
			{
				randomNumberGenerator.GetBytes(array);
			}
			return Convert.ToBase64String(array);
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static string NCcryFGogVGp()
	{
		byte[] inArray = wmWrPjVAWzqvSQ(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] wmWrPjVAWzqvSQ(int int_0)
	{
		byte[] array = new byte[int_0];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetNonZeroBytes(array);
		}
		return array;
	}
}
