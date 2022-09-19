using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace VyjVuXvolaw;

public static class FNswwgGAUxLCaAC
{
	private static bool jVojALsFeeUHp;

	private static readonly string QWrLtmdossPyC;

	[NonSerialized]
	internal static GetString getString_0;

	public static string ahNxsEtgrSV(string string_0)
	{
		int pmiqYPhZcHLkMr = 0;
		string LiMhKuLkMlhI = getString_0(107389226);
		TNGbTsbopGKhgda(QWrLtmdossPyC, out pmiqYPhZcHLkMr, out LiMhKuLkMlhI);
		byte[] inArray = zLcAYeHNWGv(Encoding.UTF8.GetBytes(string_0), pmiqYPhZcHLkMr, LiMhKuLkMlhI);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] zLcAYeHNWGv(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = KPPrXfBMIUQ(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107402717), num), getString_0(107402758));
			}
			if (!ZnIsIQivisgrr(int_0))
			{
				throw new ArgumentException(getString_0(107402168), getString_0(107402139));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107402158), getString_0(107402097));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, jVojALsFeeUHp);
		}
		throw new ArgumentException(getString_0(107402747), getString_0(107402758));
	}

	private static int KPPrXfBMIUQ(int int_0)
	{
		if (jVojALsFeeUHp)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool ZnIsIQivisgrr(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void TNGbTsbopGKhgda(string ggxMRaFJLlJ, out int pmiqYPhZcHLkMr, out string LiMhKuLkMlhI)
	{
		pmiqYPhZcHLkMr = 0;
		LiMhKuLkMlhI = getString_0(107389226);
		if (ggxMRaFJLlJ == null || ggxMRaFJLlJ.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(ggxMRaFJLlJ);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107402112)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				pmiqYPhZcHLkMr = int.Parse(array[0]);
				LiMhKuLkMlhI = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static FNswwgGAUxLCaAC()
	{
		Strings.CreateGetStringDelegate(typeof(FNswwgGAUxLCaAC));
		jVojALsFeeUHp = false;
		QWrLtmdossPyC = getString_0(107402075);
	}
}
