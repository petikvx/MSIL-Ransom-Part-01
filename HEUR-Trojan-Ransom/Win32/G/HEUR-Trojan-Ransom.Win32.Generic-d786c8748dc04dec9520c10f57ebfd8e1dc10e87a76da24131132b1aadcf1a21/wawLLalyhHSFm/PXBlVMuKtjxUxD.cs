using System;
using System.Security.Cryptography;

namespace wawLLalyhHSFm;

public sealed class PXBlVMuKtjxUxD
{
	private static int LdNCKjCJLZR = 8;

	public static string bQxbGMQPqE(int int_0)
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

	public static string NKBPlLpLanL()
	{
		byte[] inArray = IHbtqjCJRLuY(8);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] IHbtqjCJRLuY(int int_0)
	{
		byte[] array = new byte[int_0];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}
}
