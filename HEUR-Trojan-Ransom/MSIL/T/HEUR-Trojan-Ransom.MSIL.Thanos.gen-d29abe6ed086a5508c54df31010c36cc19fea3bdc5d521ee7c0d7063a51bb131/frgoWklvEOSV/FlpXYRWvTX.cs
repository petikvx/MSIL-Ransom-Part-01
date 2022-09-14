using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public static class FlpXYRWvTX
{
	private static bool QHqhUxmYNLgFw;

	private static readonly string XLDTHwKdmajt;

	[NonSerialized]
	internal static GetString getString_0;

	public static string ZTvekdOmyg(string string_0)
	{
		int OPfmSiyNGzFxTlOi = 0;
		string fPzbhtlmbDZXN = getString_0(107388735);
		MkdigCRsEEMOX(XLDTHwKdmajt, out OPfmSiyNGzFxTlOi, out fPzbhtlmbDZXN);
		byte[] inArray = YEURKxvgnTup(Encoding.UTF8.GetBytes(string_0), OPfmSiyNGzFxTlOi, fPzbhtlmbDZXN);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] YEURKxvgnTup(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = NmEJfVQfRMcT(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107402553), num), getString_0(107402562));
			}
			if (!KNJuZPxStl(int_0))
			{
				throw new ArgumentException(getString_0(107402548), getString_0(107402487));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107402506), getString_0(107402477));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, QHqhUxmYNLgFw);
		}
		throw new ArgumentException(getString_0(107402583), getString_0(107402562));
	}

	private static int NmEJfVQfRMcT(int int_0)
	{
		if (QHqhUxmYNLgFw)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool KNJuZPxStl(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void MkdigCRsEEMOX(string IZpTbvGgqiuQ, out int OPfmSiyNGzFxTlOi, out string fPzbhtlmbDZXN)
	{
		OPfmSiyNGzFxTlOi = 0;
		fPzbhtlmbDZXN = getString_0(107388735);
		if (IZpTbvGgqiuQ == null || IZpTbvGgqiuQ.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(IZpTbvGgqiuQ);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107402428)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				OPfmSiyNGzFxTlOi = int.Parse(array[0]);
				fPzbhtlmbDZXN = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static FlpXYRWvTX()
	{
		Strings.CreateGetStringDelegate(typeof(FlpXYRWvTX));
		QHqhUxmYNLgFw = false;
		XLDTHwKdmajt = getString_0(107402423);
	}
}
