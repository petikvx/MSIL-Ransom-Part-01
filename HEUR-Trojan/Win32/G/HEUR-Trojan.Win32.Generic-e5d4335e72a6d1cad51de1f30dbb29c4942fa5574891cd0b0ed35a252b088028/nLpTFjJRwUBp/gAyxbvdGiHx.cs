using System;
using System.Security.Cryptography;

namespace nLpTFjJRwUBp;

public class gAyxbvdGiHx
{
	private static int azPdNRRNzkYpy = 8;

	public static int UPDtUWJCqciMah(byte[] XGPFJQJpUMHuwNi)
	{
		return XGPFJQJpUMHuwNi.Length;
	}

	public static string QLwDLqJHKKmtyJ(string yhlRtBKrYef)
	{
		return yhlRtBKrYef.Substring(0, 32);
	}

	public static byte[] hJSUVwrHVzIPp(string QGKpEHLPszrK)
	{
		string s = QGKpEHLPszrK.Substring(32, 12);
		return Convert.FromBase64String(s);
	}

	public static string XdoqudLFSVzhLLqP(string JUTxikZTyRNx, string EgPvQgBKlFWy)
	{
		return JUTxikZTyRNx + EgPvQgBKlFWy;
	}

	public static string XuPEOARWYjn()
	{
		byte[] inArray = yTluvrzLGsWrj();
		return Convert.ToBase64String(inArray);
	}

	public static byte[] DUUFTqOjLRt()
	{
		return GdCHSloJnmtOY(azPdNRRNzkYpy);
	}

	private static byte[] GdCHSloJnmtOY(int nCuCTeVreVG)
	{
		byte[] array = new byte[nCuCTeVreVG];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}

	public static byte[] yTluvrzLGsWrj()
	{
		Random random = new Random(Environment.TickCount);
		byte[] array = new byte[8];
		random.NextBytes(array);
		return array;
	}

	public static string UPGGQTYqsnnr(int EhjABJmXqAPFHPkc)
	{
		Random random = new Random(Environment.TickCount);
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
}
