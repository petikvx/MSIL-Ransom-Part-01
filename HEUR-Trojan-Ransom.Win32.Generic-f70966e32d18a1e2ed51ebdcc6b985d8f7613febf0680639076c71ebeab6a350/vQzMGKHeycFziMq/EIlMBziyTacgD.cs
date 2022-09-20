using System;
using System.Security.Cryptography;

namespace vQzMGKHeycFziMq;

public class EIlMBziyTacgD
{
	public static string IMtpAyFmtQIHMV(int vlqACLXZzMvi)
	{
		Random random = new Random();
		string text = null;
		for (int i = 0; i < 32; i++)
		{
			char value = (char)(random.Next(33, 127) % 255);
			if (Convert.ToInt32(value) != 34 && Convert.ToInt32(value) != 92)
			{
				text += Convert.ToChar(value);
			}
			else
			{
				i--;
			}
		}
		return text;
	}

	public static string enUPmNvrfrVwQWu()
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
