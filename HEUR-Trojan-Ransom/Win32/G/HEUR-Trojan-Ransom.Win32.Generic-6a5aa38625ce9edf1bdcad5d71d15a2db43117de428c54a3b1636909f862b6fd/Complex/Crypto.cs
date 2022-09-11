using System;
using System.Security.Cryptography;

namespace Complex;

public class Crypto
{
	public static string RandomPass(int number)
	{
		Random random = new Random();
		string text = null;
		for (int i = 0; i < 32; i++)
		{
			char value = (char)(random.Next(33, 127) % 255);
			if (Convert.ToInt32(value) == 34 || Convert.ToInt32(value) == 92)
			{
				i--;
			}
			else
			{
				text += Convert.ToChar(value);
			}
		}
		return text;
	}

	public static string GenerateRandomAesPass()
	{
		try
		{
			using Rijndael rijndael = Rijndael.Create();
			rijndael.GenerateKey();
			return Convert.ToBase64String(rijndael.Key);
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}
}
