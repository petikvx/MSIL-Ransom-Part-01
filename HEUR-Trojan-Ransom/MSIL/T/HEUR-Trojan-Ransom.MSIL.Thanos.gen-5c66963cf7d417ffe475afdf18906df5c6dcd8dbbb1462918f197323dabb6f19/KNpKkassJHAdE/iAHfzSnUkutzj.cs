using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KNpKkassJHAdE;

public static class iAHfzSnUkutzj
{
	private static bool MJURrUTJcTBg;

	private static readonly string BEqXnfkIvpsC;

	[NonSerialized]
	internal static GetString getString_0;

	public static string JugqgFJafiYWrN(string string_0)
	{
		int OHtBipkAmO = 0;
		string SugtJczjELyGM = getString_0(107352661);
		pIbusnbzHyLI(BEqXnfkIvpsC, out OHtBipkAmO, out SugtJczjELyGM);
		byte[] inArray = oMvmaacZLacNV(Encoding.UTF8.GetBytes(string_0), OHtBipkAmO, SugtJczjELyGM);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] oMvmaacZLacNV(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = ocJNzcvaJHWMUx(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107364822), num), getString_0(107364831));
			}
			if (!rSqKnQfevSGR(int_0))
			{
				throw new ArgumentException(getString_0(107364817), getString_0(107364756));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107364775), getString_0(107462538));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, MJURrUTJcTBg);
		}
		throw new ArgumentException(getString_0(107364852), getString_0(107364831));
	}

	private static int ocJNzcvaJHWMUx(int int_0)
	{
		if (MJURrUTJcTBg)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool rSqKnQfevSGR(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void pIbusnbzHyLI(string FUVHOgtMREIC, out int OHtBipkAmO, out string SugtJczjELyGM)
	{
		OHtBipkAmO = 0;
		SugtJczjELyGM = getString_0(107352661);
		if (FUVHOgtMREIC == null || FUVHOgtMREIC.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(FUVHOgtMREIC);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107462489)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				OHtBipkAmO = int.Parse(array[0]);
				SugtJczjELyGM = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static iAHfzSnUkutzj()
	{
		Strings.CreateGetStringDelegate(typeof(iAHfzSnUkutzj));
		MJURrUTJcTBg = false;
		BEqXnfkIvpsC = getString_0(107462484);
	}
}
