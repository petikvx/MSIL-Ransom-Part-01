using System;
using System.Security.Cryptography;

namespace VyjVuXvolaw;

public sealed class xgcaYSxbaKKYuMD
{
	private static int AxPBpsFfYRgQ = 8;

	public static string WocDKMFkPpSXo(int int_0)
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

	public static string YKhjYVOWMHQY()
	{
		byte[] inArray = tihxhcjoHdKV(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] tihxhcjoHdKV(int int_0)
	{
		byte[] array = new byte[int_0];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}
}
