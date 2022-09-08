using System;
using System.Security.Cryptography;

namespace YzTymtbtgFABHvJvj;

public class PKwivSqSMWQMr
{
	private static int fniXtYfYuUO = 8;

	public static string VDTfUZkrNQelgE(int auerotJwMfH)
	{
		try
		{
			byte[] array = new byte[auerotJwMfH];
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

	public static int EggZANJDovQF(byte[] khgBIKQJoDOz)
	{
		return khgBIKQJoDOz.Length;
	}

	public static string tzdtEuTpfpmsW(string qnznzBbFKPNJe)
	{
		return qnznzBbFKPNJe.Substring(0, 32);
	}

	public static byte[] vsPrUJWsbFiAVF(string RtAFJQAZCnGy)
	{
		string s = RtAFJQAZCnGy.Substring(32, 12);
		return Convert.FromBase64String(s);
	}

	public static string aSJuUMTeIqkYl(string hONAljbzrhjf, string titmiOLVkvUKzV)
	{
		return hONAljbzrhjf + titmiOLVkvUKzV;
	}

	public static string zrnFDusRyLnSH()
	{
		byte[] inArray = taiSzxFzWuKa(8);
		return Convert.ToBase64String(inArray);
	}

	public static byte[] azNyNvuhcWfd()
	{
		return taiSzxFzWuKa(fniXtYfYuUO);
	}

	private static byte[] taiSzxFzWuKa(int jgfVaFzlwYsu)
	{
		byte[] array = new byte[jgfVaFzlwYsu];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetNonZeroBytes(array);
		}
		return array;
	}

	public static byte[] DumnMAUIdha()
	{
		Random random = new Random(Environment.TickCount);
		byte[] array = new byte[8];
		random.NextBytes(array);
		return array;
	}

	public static string FJYoxvsWWZqfUbyE()
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
