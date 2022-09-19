using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

public static class ooALNlRpqMWnp
{
	private static bool UrNeEIDpbSP;

	private static readonly string jjKZhzAfEGkO;

	[NonSerialized]
	internal static GetString getString_0;

	public static string oXJvdDupCCWESvWS(string string_0)
	{
		int NVuWrqczBYFVt = 0;
		string RJDpioqJltArIuv = getString_0(107408515);
		qNzoxeOqjnyC(jjKZhzAfEGkO, out NVuWrqczBYFVt, out RJDpioqJltArIuv);
		byte[] inArray = BiLZFnDMLzL(Encoding.UTF8.GetBytes(string_0), NVuWrqczBYFVt, RJDpioqJltArIuv);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] BiLZFnDMLzL(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = AxYtZoZYOyL(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107355155), num), getString_0(107355132));
			}
			if (!qFFZssBuqhbe(int_0))
			{
				throw new ArgumentException(getString_0(107355118), getString_0(107354577));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107354532), getString_0(107354535));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, UrNeEIDpbSP);
		}
		throw new ArgumentException(getString_0(107355185), getString_0(107355132));
	}

	private static int AxYtZoZYOyL(int int_0)
	{
		if (UrNeEIDpbSP)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool qFFZssBuqhbe(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void qNzoxeOqjnyC(string hcFaByGYLlmp, out int NVuWrqczBYFVt, out string RJDpioqJltArIuv)
	{
		NVuWrqczBYFVt = 0;
		RJDpioqJltArIuv = getString_0(107408515);
		if (hcFaByGYLlmp == null || hcFaByGYLlmp.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(hcFaByGYLlmp);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107354486)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				NVuWrqczBYFVt = int.Parse(array[0]);
				RJDpioqJltArIuv = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static ooALNlRpqMWnp()
	{
		Strings.CreateGetStringDelegate(typeof(ooALNlRpqMWnp));
		UrNeEIDpbSP = false;
		jjKZhzAfEGkO = getString_0(107354513);
	}
}
