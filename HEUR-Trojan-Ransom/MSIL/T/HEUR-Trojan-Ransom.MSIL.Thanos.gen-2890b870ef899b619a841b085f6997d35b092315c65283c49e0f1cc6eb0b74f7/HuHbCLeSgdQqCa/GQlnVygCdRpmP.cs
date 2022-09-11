using System;
using System.Security.Cryptography;

namespace HuHbCLeSgdQqCa;

public sealed class GQlnVygCdRpmP
{
	public static string qVmZqPZzCiOa(int int_0)
	{
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		int num = int_0 * 6;
		int num2 = (num + 7) / 8;
		byte[] array = new byte[num2];
		rNGCryptoServiceProvider.GetBytes(array);
		return Convert.ToBase64String(array);
	}
}
