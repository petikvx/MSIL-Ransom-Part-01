using System;
using System.Security.Cryptography;

namespace fAuBSMaVICral;

public sealed class lOiJKLXYNaE
{
	private static int ySlRCqYwxwh = 8;

	public static string EUcJjWziQBK(int int_0)
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

	public static string sKpHBCLYxr()
	{
		byte[] inArray = OpQwPhZTUfi(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] OpQwPhZTUfi(int int_0)
	{
		byte[] array = new byte[int_0];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}
}
