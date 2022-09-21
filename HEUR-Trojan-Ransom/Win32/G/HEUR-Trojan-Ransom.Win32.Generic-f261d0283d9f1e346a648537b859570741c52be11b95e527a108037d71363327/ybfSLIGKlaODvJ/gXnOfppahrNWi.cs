using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ybfSLIGKlaODvJ;

public static class gXnOfppahrNWi
{
	private static bool sDoKJrPgxwJplGZ;

	private static readonly string TAdsLsUjlJoy;

	[NonSerialized]
	internal static GetString getString_0;

	public static string sBDlGorhadqnmxr(string string_0)
	{
		int PWMwEGUAYLmsMzE = 0;
		string SZxiOYqKlDFAg = getString_0(107390173);
		JDGIbZTAgKdylUQG(TAdsLsUjlJoy, out PWMwEGUAYLmsMzE, out SZxiOYqKlDFAg);
		byte[] inArray = HNlVqAvARs(Encoding.UTF8.GetBytes(string_0), PWMwEGUAYLmsMzE, SZxiOYqKlDFAg);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] HNlVqAvARs(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = ZCuArYhcQJrN(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107402740), num), getString_0(107402749));
			}
			if (!EskisMMuHd(int_0))
			{
				throw new ArgumentException(getString_0(107402735), getString_0(107402194));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107402181), getString_0(107402152));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, sDoKJrPgxwJplGZ);
		}
		throw new ArgumentException(getString_0(107402802), getString_0(107402749));
	}

	private static int ZCuArYhcQJrN(int int_0)
	{
		if (sDoKJrPgxwJplGZ)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool EskisMMuHd(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void JDGIbZTAgKdylUQG(string zThZcPBkMaTE, out int PWMwEGUAYLmsMzE, out string SZxiOYqKlDFAg)
	{
		PWMwEGUAYLmsMzE = 0;
		SZxiOYqKlDFAg = getString_0(107390173);
		if (zThZcPBkMaTE == null || zThZcPBkMaTE.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(zThZcPBkMaTE);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107402103)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				PWMwEGUAYLmsMzE = int.Parse(array[0]);
				SZxiOYqKlDFAg = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static gXnOfppahrNWi()
	{
		Strings.CreateGetStringDelegate(typeof(gXnOfppahrNWi));
		sDoKJrPgxwJplGZ = false;
		TAdsLsUjlJoy = getString_0(107402130);
	}
}
