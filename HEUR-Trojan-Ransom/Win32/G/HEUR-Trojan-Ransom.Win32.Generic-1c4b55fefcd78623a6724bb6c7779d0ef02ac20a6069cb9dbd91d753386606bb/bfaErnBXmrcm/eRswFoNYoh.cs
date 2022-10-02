using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bfaErnBXmrcm;

public static class eRswFoNYoh
{
	private static bool kgpKqHhEuwwNvK;

	private static readonly string JZmrrbPbSDNqiW;

	[NonSerialized]
	internal static GetString getString_0;

	public static string PROnJShPzChUEjYf(string string_0)
	{
		int iAbPOBfIRLXkxaf = 0;
		string LjbQsDgLBfxRA = getString_0(107361193);
		LfGfCjEVnIcHU(JZmrrbPbSDNqiW, out iAbPOBfIRLXkxaf, out LjbQsDgLBfxRA);
		byte[] inArray = YeuYcOyTfTjqKXXp(Encoding.UTF8.GetBytes(string_0), iAbPOBfIRLXkxaf, LjbQsDgLBfxRA);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] YeuYcOyTfTjqKXXp(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = lkwYxSKuxxpJLCv(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107369806), num), getString_0(107369815));
			}
			if (!NPqPxBdaoAkjwswo(int_0))
			{
				throw new ArgumentException(getString_0(107369801), getString_0(107369740));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107369759), getString_0(107369730));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, kgpKqHhEuwwNvK);
		}
		throw new ArgumentException(getString_0(107369836), getString_0(107369815));
	}

	private static int lkwYxSKuxxpJLCv(int int_0)
	{
		if (kgpKqHhEuwwNvK)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool NPqPxBdaoAkjwswo(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void LfGfCjEVnIcHU(string QNhnTwRXlZeNuY, out int iAbPOBfIRLXkxaf, out string LjbQsDgLBfxRA)
	{
		iAbPOBfIRLXkxaf = 0;
		LjbQsDgLBfxRA = getString_0(107361193);
		if (QNhnTwRXlZeNuY == null || QNhnTwRXlZeNuY.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(QNhnTwRXlZeNuY);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107369681)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				iAbPOBfIRLXkxaf = int.Parse(array[0]);
				LjbQsDgLBfxRA = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static eRswFoNYoh()
	{
		Strings.CreateGetStringDelegate(typeof(eRswFoNYoh));
		kgpKqHhEuwwNvK = false;
		JZmrrbPbSDNqiW = getString_0(107369676);
	}
}
