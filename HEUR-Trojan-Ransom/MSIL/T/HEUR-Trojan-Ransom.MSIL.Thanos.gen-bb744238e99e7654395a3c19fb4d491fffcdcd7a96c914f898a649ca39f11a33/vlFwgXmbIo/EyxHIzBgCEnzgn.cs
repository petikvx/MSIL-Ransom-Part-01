using System;
using System.Security.Cryptography;

namespace vlFwgXmbIo;

public sealed class EyxHIzBgCEnzgn
{
	private static int sezESoIbnQNAlA = 8;

	public static string JXgFRQquWqtcRNm(int int_0)
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

	public static string tpIepiJRhhm()
	{
		byte[] inArray = AkRCWiHxbnXA(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] AkRCWiHxbnXA(int int_0)
	{
		byte[] array = new byte[int_0];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}
}
