using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace esImVhYKuzS;

public static class vZEdgQdbRkK
{
	private static bool aZhRBOYsRQE;

	private static readonly string WMXhkEuWsJZyIu;

	[NonSerialized]
	internal static GetString getString_0;

	public static string YyRgcNaxySQrynRj(string string_0)
	{
		int raBHMEfzuztm = 0;
		string rJpOsuAntGYPG = getString_0(107389286);
		lTWHtNDyarmue(WMXhkEuWsJZyIu, out raBHMEfzuztm, out rJpOsuAntGYPG);
		byte[] inArray = GMsOXmFOTRdW(Encoding.UTF8.GetBytes(string_0), raBHMEfzuztm, rJpOsuAntGYPG);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] GMsOXmFOTRdW(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = LrLDCazoFVIt(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107402777), num), getString_0(107402786));
			}
			if (!LBhqcPWOpNi(int_0))
			{
				throw new ArgumentException(getString_0(107402740), getString_0(107402711));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107402730), getString_0(107402189));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, aZhRBOYsRQE);
		}
		throw new ArgumentException(getString_0(107402807), getString_0(107402786));
	}

	private static int LrLDCazoFVIt(int int_0)
	{
		if (aZhRBOYsRQE)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool LBhqcPWOpNi(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void lTWHtNDyarmue(string bZJzqCPlrsbU, out int raBHMEfzuztm, out string rJpOsuAntGYPG)
	{
		raBHMEfzuztm = 0;
		rJpOsuAntGYPG = getString_0(107389286);
		if (bZJzqCPlrsbU == null || bZJzqCPlrsbU.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(bZJzqCPlrsbU);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107402140)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				raBHMEfzuztm = int.Parse(array[0]);
				rJpOsuAntGYPG = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static vZEdgQdbRkK()
	{
		Strings.CreateGetStringDelegate(typeof(vZEdgQdbRkK));
		aZhRBOYsRQE = false;
		WMXhkEuWsJZyIu = getString_0(107402135);
	}
}
