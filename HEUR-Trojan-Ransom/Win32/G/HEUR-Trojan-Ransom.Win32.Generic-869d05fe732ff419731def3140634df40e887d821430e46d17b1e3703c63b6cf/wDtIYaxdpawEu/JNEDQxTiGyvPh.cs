using System;
using System.Security.Cryptography;

namespace wDtIYaxdpawEu;

public sealed class JNEDQxTiGyvPh
{
	private static int RMCQUYYznQA = 8;

	public static string XoKGyJzEnHtiLD(int int_0)
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

	public static string QdOxughxMncJD()
	{
		byte[] inArray = ecrZwlYvReT(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] ecrZwlYvReT(int int_0)
	{
		byte[] array = new byte[int_0];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}
}
