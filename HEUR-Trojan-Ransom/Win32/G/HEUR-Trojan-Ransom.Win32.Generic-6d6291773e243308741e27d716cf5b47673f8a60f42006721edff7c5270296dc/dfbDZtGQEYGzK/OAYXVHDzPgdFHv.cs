using System;
using System.Security.Cryptography;

namespace dfbDZtGQEYGzK;

public class OAYXVHDzPgdFHv
{
	private static int zSKclxBQjISd = 8;

	public static string XHZvUIhBlcoaY(int aEzbkJPQWDkQH)
	{
		try
		{
			byte[] array = new byte[aEzbkJPQWDkQH];
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

	public static int MrEYMwzvqJwjazxt(byte[] EQqhPNkypCf)
	{
		return EQqhPNkypCf.Length;
	}

	public static string aGpKMVzkfPuon(string sptyZRNsJRMmvK)
	{
		return sptyZRNsJRMmvK.Substring(0, 32);
	}

	public static byte[] fsmyjvUGcQlbRzWQ(string vjsapRbzBXjCh)
	{
		string s = vjsapRbzBXjCh.Substring(32, 12);
		return Convert.FromBase64String(s);
	}

	public static string fgkxLlsGJGdNCsVK(string YSufafJwjTsfPSJ, string UklhUrmqVqTQBh)
	{
		return YSufafJwjTsfPSJ + UklhUrmqVqTQBh;
	}

	public static string WsldrQcqYAlmUzOPt()
	{
		byte[] inArray = jfJMVLjICBj(8);
		return Convert.ToBase64String(inArray);
	}

	public static byte[] VttUQYgQXWS()
	{
		return jfJMVLjICBj(zSKclxBQjISd);
	}

	private static byte[] jfJMVLjICBj(int tiGRxckkbDFv)
	{
		byte[] array = new byte[tiGRxckkbDFv];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}

	public static byte[] dYGyxyrYSsFJCmkOB()
	{
		Random random = new Random(Environment.TickCount);
		byte[] array = new byte[8];
		random.NextBytes(array);
		return array;
	}

	public static string aySnOighNh()
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
