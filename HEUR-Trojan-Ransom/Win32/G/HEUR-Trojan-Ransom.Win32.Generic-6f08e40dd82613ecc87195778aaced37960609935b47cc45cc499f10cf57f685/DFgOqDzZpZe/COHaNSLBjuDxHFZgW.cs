using System;
using System.Security.Cryptography;

namespace DFgOqDzZpZe;

public sealed class COHaNSLBjuDxHFZgW
{
	private static int CIukpLuvEnqZ = 8;

	public static string zPVjtudhZgOqH(int int_0)
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

	public static string POLqBalRuwH()
	{
		byte[] inArray = AiiwBlIDuurc(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] AiiwBlIDuurc(int int_0)
	{
		byte[] array = new byte[int_0];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}
}
