using System;
using System.Security.Cryptography;

namespace PMpBbYpvEb;

public sealed class ynyhEGlCIJnfcaD
{
	private static int RJKvrFkOTROU = 8;

	public static string QwIgDgKzjcsoDE(int int_0)
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

	public static string WTEHzpQRSAZmw()
	{
		byte[] inArray = iixeRpoypSmVxn(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] iixeRpoypSmVxn(int int_0)
	{
		byte[] array = new byte[int_0];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetNonZeroBytes(array);
		}
		return array;
	}
}
