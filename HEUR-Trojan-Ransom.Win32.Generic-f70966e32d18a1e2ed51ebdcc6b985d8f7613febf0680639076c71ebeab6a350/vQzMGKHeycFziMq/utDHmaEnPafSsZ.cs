using System;
using System.Security.Cryptography;

namespace vQzMGKHeycFziMq;

public class utDHmaEnPafSsZ
{
	private static int kSrjQEgkIrTF = 8;

	public static string zXqCMkpXvvDkS(int CnhvreeDUa)
	{
		try
		{
			byte[] array = new byte[CnhvreeDUa];
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

	public static int KGvmtmMYTDQFi(byte[] MAWrLDoojJ)
	{
		return MAWrLDoojJ.Length;
	}

	public static string iebAHqQaCmCKoJ(string bjiYsXthJbYRuz)
	{
		return bjiYsXthJbYRuz.Substring(0, 32);
	}

	public static byte[] OQuWSISXRAyBz(string ganbsMPegzASJF)
	{
		string s = ganbsMPegzASJF.Substring(32, 12);
		return Convert.FromBase64String(s);
	}

	public static string CMjPZhidLG(string PMkhPWsstWTI, string RnNMtYQILzVz)
	{
		return PMkhPWsstWTI + RnNMtYQILzVz;
	}

	public static string GdIXFYPygrqzMs()
	{
		byte[] inArray = PrUulWHPXKKTq(8);
		return Convert.ToBase64String(inArray);
	}

	public static byte[] AYxwcBrsRnsHcp()
	{
		return PrUulWHPXKKTq(kSrjQEgkIrTF);
	}

	private static byte[] PrUulWHPXKKTq(int LeMzEyPeZpH)
	{
		byte[] array = new byte[LeMzEyPeZpH];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}

	public static byte[] WlWjUwPbkuam()
	{
		Random random = new Random(Environment.TickCount);
		byte[] array = new byte[8];
		random.NextBytes(array);
		return array;
	}

	public static string HAKdtaYnTXJVxMM()
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
