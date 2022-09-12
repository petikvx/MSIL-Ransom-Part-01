using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MeMbmuKeumkr;

public static class ECenXESGSbtpC
{
	private static bool EYNeyWxwoRoAyc;

	private static readonly string uvHxPYoplvtwQ;

	[NonSerialized]
	internal static GetString getString_0;

	public static string aRsolJTJRQeClRd(string string_0)
	{
		int DvKnCdcxZRZlir = 0;
		string iDDRaWKjNnT = getString_0(107360130);
		mgUzsJBhYHcUUK(uvHxPYoplvtwQ, out DvKnCdcxZRZlir, out iDDRaWKjNnT);
		byte[] inArray = mMsmsALBeONnz(Encoding.UTF8.GetBytes(string_0), DvKnCdcxZRZlir, iDDRaWKjNnT);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] mMsmsALBeONnz(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException(getString_0(107368666), getString_0(107369157));
		}
		int num = UpjUqbTjbiKYW(int_0);
		if (byte_0.Length > num)
		{
			throw new ArgumentException(string.Format(getString_0(107369148), num), getString_0(107369157));
		}
		if (!tKAIcUPlWHgQs(int_0))
		{
			throw new ArgumentException(getString_0(107369079), getString_0(107369082));
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException(getString_0(107369037), getString_0(107369008));
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, EYNeyWxwoRoAyc);
	}

	private static int UpjUqbTjbiKYW(int int_0)
	{
		if (EYNeyWxwoRoAyc)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool tKAIcUPlWHgQs(int int_0)
	{
		return int_0 >= 384 && int_0 <= 16384 && int_0 % 8 == 0;
	}

	private static void mgUzsJBhYHcUUK(string RoUWtwRpilXq, out int DvKnCdcxZRZlir, out string iDDRaWKjNnT)
	{
		DvKnCdcxZRZlir = 0;
		iDDRaWKjNnT = getString_0(107360130);
		if (RoUWtwRpilXq == null || RoUWtwRpilXq.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(RoUWtwRpilXq);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107369023)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				DvKnCdcxZRZlir = int.Parse(array[0]);
				iDDRaWKjNnT = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static ECenXESGSbtpC()
	{
		Strings.CreateGetStringDelegate(typeof(ECenXESGSbtpC));
		EYNeyWxwoRoAyc = false;
		uvHxPYoplvtwQ = getString_0(107369018);
	}
}
