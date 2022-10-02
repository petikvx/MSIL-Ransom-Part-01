using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GlIxuPPoosXGy;

public static class NkovHMVDww
{
	private static bool QLrzPFQdnagy;

	private static readonly string TUrZzxmdAJF;

	[NonSerialized]
	internal static GetString getString_0;

	public static string EAiaLHGuShXIai(string string_0)
	{
		int dXWtRWRobtth = 0;
		string oOtJWVXjtJrGmL = getString_0(107394136);
		mbYLUNLvxjbAq(TUrZzxmdAJF, out dXWtRWRobtth, out oOtJWVXjtJrGmL);
		byte[] inArray = zXewLZTlFKTP(Encoding.UTF8.GetBytes(string_0), dXWtRWRobtth, oOtJWVXjtJrGmL);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] zXewLZTlFKTP(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = jGMwWOjUByEb(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107404582), num), getString_0(107404559));
			}
			if (!KraJcrDfxQwT(int_0))
			{
				throw new ArgumentException(getString_0(107404545), getString_0(107404516));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107404983), getString_0(107404954));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, QLrzPFQdnagy);
		}
		throw new ArgumentException(getString_0(107404612), getString_0(107404559));
	}

	private static int jGMwWOjUByEb(int int_0)
	{
		if (QLrzPFQdnagy)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool KraJcrDfxQwT(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void mbYLUNLvxjbAq(string EyksQRggwVW, out int dXWtRWRobtth, out string oOtJWVXjtJrGmL)
	{
		dXWtRWRobtth = 0;
		oOtJWVXjtJrGmL = getString_0(107394136);
		if (EyksQRggwVW == null || EyksQRggwVW.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(EyksQRggwVW);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107404969)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				dXWtRWRobtth = int.Parse(array[0]);
				oOtJWVXjtJrGmL = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static NkovHMVDww()
	{
		Strings.CreateGetStringDelegate(typeof(NkovHMVDww));
		QLrzPFQdnagy = false;
		TUrZzxmdAJF = getString_0(107404964);
	}
}
