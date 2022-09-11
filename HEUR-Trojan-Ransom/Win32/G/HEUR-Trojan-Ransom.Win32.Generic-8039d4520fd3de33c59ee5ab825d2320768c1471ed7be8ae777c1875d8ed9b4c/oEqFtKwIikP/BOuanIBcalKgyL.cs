using System;
using System.Security.Cryptography;

namespace oEqFtKwIikP;

public class BOuanIBcalKgyL
{
	public static string xzEJZEYlMEoWeQrO(int RezUsBzXrmND)
	{
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		int num = RezUsBzXrmND * 6;
		int num2 = (num + 7) / 8;
		byte[] array = new byte[num2];
		rNGCryptoServiceProvider.GetBytes(array);
		return Convert.ToBase64String(array);
	}
}
