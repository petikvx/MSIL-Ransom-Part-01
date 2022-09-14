using System;
using System.Security.Cryptography;

namespace wmzoZRdMaf;

public sealed class mPZHeAmBXOW
{
	private static int zgPKnLqVmmCqa = 8;

	public static string NknwnSRhtiQplA(int int_0)
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

	public static string IDARSyoZrvbC()
	{
		byte[] inArray = iuAYgkQSzKNH(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] iuAYgkQSzKNH(int int_0)
	{
		byte[] array = new byte[int_0];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}
}
