using System;
using System.Security.Cryptography;

namespace coxZRmDhvSAWo;

public sealed class OgnUgpogJqEQzj
{
	private static int TgToKlVoHnnQD = 8;

	public static string m000032(int p0)
	{
		try
		{
			byte[] array = new byte[p0];
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

	public static string vYlLBcysurxM()
	{
		byte[] inArray = KKjLlcRKEfWLff(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] KKjLlcRKEfWLff(int p0)
	{
		byte[] array = new byte[p0];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetNonZeroBytes(array);
		}
		return array;
	}
}
