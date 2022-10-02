using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UmXkJLRjSLdPF;

public static class oZiYINTVbfPwf
{
	private static bool LpklwDHtDREH;

	private static readonly string ykuzjVnQWOwMg;

	[NonSerialized]
	internal static GetString getString_0;

	public static string YdOLahNiCvL(string string_0)
	{
		int pAXfJIuQtxBpR = 0;
		string WrmYBJvOxCpG = getString_0(107359762);
		XXXXMoglZwM(ykuzjVnQWOwMg, out pAXfJIuQtxBpR, out WrmYBJvOxCpG);
		byte[] inArray = hEuJmXnTYAnSf(Encoding.UTF8.GetBytes(string_0), pAXfJIuQtxBpR, WrmYBJvOxCpG);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] hEuJmXnTYAnSf(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = LhBsLudbTSvttO(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107368190), num), getString_0(107368231));
			}
			if (!TkkMlDEndgjxEsK(int_0))
			{
				throw new ArgumentException(getString_0(107368153), getString_0(107368636));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107368655), getString_0(107368626));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, LpklwDHtDREH);
		}
		throw new ArgumentException(getString_0(107368220), getString_0(107368231));
	}

	private static int LhBsLudbTSvttO(int int_0)
	{
		if (LpklwDHtDREH)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool TkkMlDEndgjxEsK(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void XXXXMoglZwM(string JHucujarsuPvsc, out int pAXfJIuQtxBpR, out string WrmYBJvOxCpG)
	{
		pAXfJIuQtxBpR = 0;
		WrmYBJvOxCpG = getString_0(107359762);
		if (JHucujarsuPvsc == null || JHucujarsuPvsc.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(JHucujarsuPvsc);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107368577)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				pAXfJIuQtxBpR = int.Parse(array[0]);
				WrmYBJvOxCpG = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static oZiYINTVbfPwf()
	{
		Strings.CreateGetStringDelegate(typeof(oZiYINTVbfPwf));
		LpklwDHtDREH = false;
		ykuzjVnQWOwMg = getString_0(107368572);
	}
}
