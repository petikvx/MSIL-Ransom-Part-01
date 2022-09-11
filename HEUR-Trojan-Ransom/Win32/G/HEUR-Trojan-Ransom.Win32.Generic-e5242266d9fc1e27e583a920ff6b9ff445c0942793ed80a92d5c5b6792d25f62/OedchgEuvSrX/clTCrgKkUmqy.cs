using System;
using System.Security.Cryptography;

namespace OedchgEuvSrX;

public class clTCrgKkUmqy
{
	public static string QglWefldbmhy(int OemxlnDJFd)
	{
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		int num = OemxlnDJFd * 6;
		int num2 = (num + 7) / 8;
		byte[] array = new byte[num2];
		rNGCryptoServiceProvider.GetBytes(array);
		return Convert.ToBase64String(array);
	}
}
