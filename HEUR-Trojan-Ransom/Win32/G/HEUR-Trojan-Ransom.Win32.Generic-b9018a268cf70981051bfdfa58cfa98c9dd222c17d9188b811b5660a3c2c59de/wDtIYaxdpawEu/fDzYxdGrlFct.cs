using System;
using System.Security.Cryptography;

namespace wDtIYaxdpawEu;

public sealed class fDzYxdGrlFct
{
	private static int RMCQUYYznQA = 8;

	public static string LiytReEiZfhPA(int int_0)
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

	public static string rrVuhdVHDJo()
	{
		byte[] inArray = arVoPAvEBPK(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] arVoPAvEBPK(int int_0)
	{
		byte[] array = new byte[int_0];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}
}
