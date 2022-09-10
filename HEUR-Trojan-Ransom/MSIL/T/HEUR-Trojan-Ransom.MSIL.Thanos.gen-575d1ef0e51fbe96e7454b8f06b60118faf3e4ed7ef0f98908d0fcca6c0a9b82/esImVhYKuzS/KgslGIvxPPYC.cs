using System;
using System.Security.Cryptography;

namespace esImVhYKuzS;

public sealed class KgslGIvxPPYC
{
	private static int wGQKrOWtyZyud = 8;

	public static string ukGooAVIEftF(int int_0)
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

	public static string nmusDcUUsKC()
	{
		byte[] inArray = zPHdJTvRbZV(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] zPHdJTvRbZV(int int_0)
	{
		byte[] array = new byte[int_0];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}
}
