using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

public static class GzxfJecXtrCbXb
{
	private static bool tGJzxFXklmK;

	private static readonly string aHioULHQmSWGlBdo;

	[NonSerialized]
	internal static GetString getString_0;

	public static string kbfqQxGdxRHX(string string_0)
	{
		int thcKfPkmwNBu = 0;
		string jdEwHGUEylOF = getString_0(107391597);
		UIvlYDvuCaxYZ(aHioULHQmSWGlBdo, out thcKfPkmwNBu, out jdEwHGUEylOF);
		byte[] inArray = amXhfReyqy(Encoding.UTF8.GetBytes(string_0), thcKfPkmwNBu, jdEwHGUEylOF);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] amXhfReyqy(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = oXHJbbIWxFfjzk(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107404091), num), getString_0(107404132));
			}
			if (!gbYLAQMlVOYagip(int_0))
			{
				throw new ArgumentException(getString_0(107404054), getString_0(107404025));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107404044), getString_0(107404015));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, tGJzxFXklmK);
		}
		throw new ArgumentException(getString_0(107404121), getString_0(107404132));
	}

	private static int oXHJbbIWxFfjzk(int int_0)
	{
		if (tGJzxFXklmK)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool gbYLAQMlVOYagip(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void UIvlYDvuCaxYZ(string ZihXJwKhgUDU, out int thcKfPkmwNBu, out string jdEwHGUEylOF)
	{
		thcKfPkmwNBu = 0;
		jdEwHGUEylOF = getString_0(107391597);
		if (ZihXJwKhgUDU == null || ZihXJwKhgUDU.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(ZihXJwKhgUDU);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107404478)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				thcKfPkmwNBu = int.Parse(array[0]);
				jdEwHGUEylOF = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static GzxfJecXtrCbXb()
	{
		Strings.CreateGetStringDelegate(typeof(GzxfJecXtrCbXb));
		tGJzxFXklmK = false;
		aHioULHQmSWGlBdo = getString_0(107404473);
	}
}
