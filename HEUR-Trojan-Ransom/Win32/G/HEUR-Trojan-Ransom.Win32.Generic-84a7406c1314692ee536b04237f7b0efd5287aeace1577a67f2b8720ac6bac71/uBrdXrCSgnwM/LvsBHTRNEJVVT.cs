using System;
using System.Security.Cryptography;

namespace uBrdXrCSgnwM;

public sealed class LvsBHTRNEJVVT
{
	private static int haGnbtuvSxg = 8;

	public static string CuYVABsgDAuzvtB(int int_0)
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

	public static string NVvkzdoIwRWjWo()
	{
		byte[] inArray = QhntiKDrZautPz(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] QhntiKDrZautPz(int int_0)
	{
		byte[] array = new byte[int_0];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetNonZeroBytes(array);
		}
		return array;
	}
}
