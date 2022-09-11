using System;
using System.Security.Cryptography;

namespace Complex;

public class RandomIV
{
	private static int saltLengthLimit = 8;

	public static string GetRandomBytes(int byteCount)
	{
		try
		{
			byte[] array = new byte[byteCount];
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

	public static int GetLength(byte[] array)
	{
		return array.Length;
	}

	public static string GetPasswordFromCombined(string CombineKeyAndSalt)
	{
		return CombineKeyAndSalt.Substring(0, 32);
	}

	public static byte[] GetSaltFromCombined(string CombineKeyAndSalt)
	{
		string s = CombineKeyAndSalt.Substring(32, 12);
		return Convert.FromBase64String(s);
	}

	public static string CombineKeyAndSalt(string key, string salt)
	{
		return key + salt;
	}

	public static string GetRandomSaltAsString()
	{
		byte[] salt = GetSalt(8);
		return Convert.ToBase64String(salt);
	}

	public static byte[] GetSalt()
	{
		return GetSalt(saltLengthLimit);
	}

	private static byte[] GetSalt(int maximumSaltLength)
	{
		byte[] array = new byte[maximumSaltLength];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetNonZeroBytes(array);
		}
		return array;
	}

	public static byte[] GetRandomIV()
	{
		Random random = new Random(Environment.TickCount);
		byte[] array = new byte[8];
		random.NextBytes(array);
		return array;
	}

	public static string RandomPass()
	{
		try
		{
			using Rijndael rijndael = Rijndael.Create();
			rijndael.GenerateKey();
			string text = Convert.ToBase64String(rijndael.Key);
			return text.Remove(32, 12);
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}
}
