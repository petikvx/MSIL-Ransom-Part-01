using System;
using System.Security.Cryptography;

namespace PbjBzLsVOvNrzQ;

public class SPzjvsBNRyMii
{
	private static int NuqAUhPwnscCl = 8;

	public static int RUFrpwhFjH(byte[] WlTRVOHGOqaDTq)
	{
		return WlTRVOHGOqaDTq.Length;
	}

	public static string JkOSyNcbwrPbaD(string gKxVzAEhxWokf)
	{
		return gKxVzAEhxWokf.Substring(0, 32);
	}

	public static byte[] bFhbciuwlVu(string HaIvtNGuQSXFG)
	{
		string s = HaIvtNGuQSXFG.Substring(32, 12);
		return Convert.FromBase64String(s);
	}

	public static string NkwHyIyfXweNegR(string uKgwaIhgXofXFV, string MchjWkafaWHsfzMIN)
	{
		return uKgwaIhgXofXFV + MchjWkafaWHsfzMIN;
	}

	public static string eellOqVcBhYqD()
	{
		byte[] inArray = pZmxACkdLC();
		return Convert.ToBase64String(inArray);
	}

	public static byte[] fkXYaPJqRmNicQk()
	{
		return ddWjpcxsxobSPI(NuqAUhPwnscCl);
	}

	private static byte[] ddWjpcxsxobSPI(int lZKNlsuylca)
	{
		byte[] array = new byte[lZKNlsuylca];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetNonZeroBytes(array);
		return array;
	}

	public static byte[] pZmxACkdLC()
	{
		Random random = new Random(Environment.TickCount);
		byte[] array = new byte[8];
		random.NextBytes(array);
		return array;
	}

	public static string VkYksqNsvrIw(int GyEgCEejXgTK)
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
