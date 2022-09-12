using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace InTDhhOfzy;

public static class BAWbbIGcEbbh
{
	private static bool WqKFAfaHUUc;

	private static readonly string pGRhuApHKDGfXW;

	[NonSerialized]
	internal static GetString getString_0;

	public static string BsLVCxQmQh(string string_0)
	{
		int PuvQplKsoPqGP = 0;
		string FFrdLKHmvbtik = getString_0(107395197);
		RzbONKbukBgtSS(pGRhuApHKDGfXW, out PuvQplKsoPqGP, out FFrdLKHmvbtik);
		byte[] inArray = eNVqHuScKJGA(Encoding.UTF8.GetBytes(string_0), PuvQplKsoPqGP, FFrdLKHmvbtik);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] eNVqHuScKJGA(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = swfIUmFPbhSD(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107409074), num), getString_0(107409051));
			}
			if (!VkulywvKImJoU(int_0))
			{
				throw new ArgumentException(getString_0(107409549), getString_0(107409520));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107409507), getString_0(107409478));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, WqKFAfaHUUc);
		}
		throw new ArgumentException(getString_0(107409104), getString_0(107409051));
	}

	private static int swfIUmFPbhSD(int int_0)
	{
		if (WqKFAfaHUUc)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool VkulywvKImJoU(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void RzbONKbukBgtSS(string LKXoFFZofzqpUN, out int PuvQplKsoPqGP, out string FFrdLKHmvbtik)
	{
		PuvQplKsoPqGP = 0;
		FFrdLKHmvbtik = getString_0(107395197);
		if (LKXoFFZofzqpUN == null || LKXoFFZofzqpUN.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(LKXoFFZofzqpUN);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107409429)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				PuvQplKsoPqGP = int.Parse(array[0]);
				FFrdLKHmvbtik = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static BAWbbIGcEbbh()
	{
		Strings.CreateGetStringDelegate(typeof(BAWbbIGcEbbh));
		WqKFAfaHUUc = false;
		pGRhuApHKDGfXW = getString_0(107409456);
	}
}
