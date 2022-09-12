using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace sWduCclqEzKrM;

public static class PmmjrDLLHGk
{
	private static bool KLYtNlyEWvd;

	private static readonly string VZFMqwnhbLIxe;

	[NonSerialized]
	internal static GetString getString_0;

	public static string kPAAXvpwzUaT(string string_0)
	{
		int xtLUEoVLTDOI = 0;
		string AlliZrTFaaO = getString_0(107400745);
		chwqsPFQodYB(VZFMqwnhbLIxe, out xtLUEoVLTDOI, out AlliZrTFaaO);
		byte[] inArray = BnGiQrAdRQ(Encoding.UTF8.GetBytes(string_0), xtLUEoVLTDOI, AlliZrTFaaO);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] BnGiQrAdRQ(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = hbJdjLPTzAoe(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107379026), num), getString_0(107379035));
			}
			if (!cotQoyCawQgfWo(int_0))
			{
				throw new ArgumentException(getString_0(107379021), getString_0(107378992));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107378979), getString_0(107378950));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, KLYtNlyEWvd);
		}
		throw new ArgumentException(getString_0(107379088), getString_0(107379035));
	}

	private static int hbJdjLPTzAoe(int int_0)
	{
		if (KLYtNlyEWvd)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool cotQoyCawQgfWo(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void chwqsPFQodYB(string TjvhwFxboWMGquui, out int xtLUEoVLTDOI, out string AlliZrTFaaO)
	{
		xtLUEoVLTDOI = 0;
		AlliZrTFaaO = getString_0(107400745);
		if (TjvhwFxboWMGquui == null || TjvhwFxboWMGquui.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(TjvhwFxboWMGquui);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107378901)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				xtLUEoVLTDOI = int.Parse(array[0]);
				AlliZrTFaaO = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static PmmjrDLLHGk()
	{
		Strings.CreateGetStringDelegate(typeof(PmmjrDLLHGk));
		KLYtNlyEWvd = false;
		VZFMqwnhbLIxe = getString_0(107378928);
	}
}
