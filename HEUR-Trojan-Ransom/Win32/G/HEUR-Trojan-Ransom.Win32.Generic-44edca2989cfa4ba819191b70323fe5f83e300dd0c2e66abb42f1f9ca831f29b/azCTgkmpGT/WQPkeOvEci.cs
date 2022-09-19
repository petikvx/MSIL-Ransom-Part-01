using System;
using System.Security.Cryptography;

namespace azCTgkmpGT;

public sealed class WQPkeOvEci
{
	private static int QSHpeZouad = 8;

	public static string SBPfmWOaNeINeU(int int_0)
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

	public static string JZQcnaocigGbMUm()
	{
		byte[] inArray = jHMOwtxBBKyYT(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] jHMOwtxBBKyYT(int int_0)
	{
		byte[] array = new byte[int_0];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}
}
