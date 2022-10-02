using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nZBhTHSmQawuU;

public static class YqurPBxWfAEq
{
	private static bool vGSuAaFeQxvvVBG;

	private static readonly string NnwIrGyYEmBMw;

	[NonSerialized]
	internal static GetString getString_0;

	public static string WmMFQfcANmV(string string_0)
	{
		int OHwzDVIYaHKZ = 0;
		string eYHTlFBLgSMm = getString_0(107358995);
		CDKaEuqwDF(NnwIrGyYEmBMw, out OHwzDVIYaHKZ, out eYHTlFBLgSMm);
		byte[] inArray = PcXgfZDvmdWp(Encoding.UTF8.GetBytes(string_0), OHwzDVIYaHKZ, eYHTlFBLgSMm);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] PcXgfZDvmdWp(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = azhjgsiItFxlsKdR(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107367472), num), getString_0(107367481));
			}
			if (!AYNWQLFXCFCm(int_0))
			{
				throw new ArgumentException(getString_0(107367435), getString_0(107367406));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107367425), getString_0(107367396));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, vGSuAaFeQxvvVBG);
		}
		throw new ArgumentException(getString_0(107367502), getString_0(107367481));
	}

	private static int azhjgsiItFxlsKdR(int int_0)
	{
		if (vGSuAaFeQxvvVBG)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool AYNWQLFXCFCm(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void CDKaEuqwDF(string zrMSrsokJDVUyl, out int OHwzDVIYaHKZ, out string eYHTlFBLgSMm)
	{
		OHwzDVIYaHKZ = 0;
		eYHTlFBLgSMm = getString_0(107358995);
		if (zrMSrsokJDVUyl == null || zrMSrsokJDVUyl.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(zrMSrsokJDVUyl);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107367347)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				OHwzDVIYaHKZ = int.Parse(array[0]);
				eYHTlFBLgSMm = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static YqurPBxWfAEq()
	{
		Strings.CreateGetStringDelegate(typeof(YqurPBxWfAEq));
		vGSuAaFeQxvvVBG = false;
		NnwIrGyYEmBMw = getString_0(107367342);
	}
}
