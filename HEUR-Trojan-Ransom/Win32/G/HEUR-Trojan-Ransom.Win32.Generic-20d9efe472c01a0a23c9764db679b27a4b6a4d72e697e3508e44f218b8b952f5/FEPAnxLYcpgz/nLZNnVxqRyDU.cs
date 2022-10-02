using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

public static class nLZNnVxqRyDU
{
	private static bool evtBTwRVSlWd;

	private static readonly string pIKzJPPOeQ;

	[NonSerialized]
	internal static GetString getString_0;

	public static string rfAqHmOOmjC(string string_0)
	{
		int NMNukOrlMglP = 0;
		string CLqDRgOeRbkl = getString_0(107368333);
		zErAcTkPxlRh(pIKzJPPOeQ, out NMNukOrlMglP, out CLqDRgOeRbkl);
		byte[] inArray = hmfSxnsRfChQR(Encoding.UTF8.GetBytes(string_0), NMNukOrlMglP, CLqDRgOeRbkl);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] hmfSxnsRfChQR(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = OxfDHAWwIzJwtdecq(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107478931), num), getString_0(107478908));
			}
			if (!QvRWOvfrIpDP(int_0))
			{
				throw new ArgumentException(getString_0(107478894), getString_0(107478865));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107478820), getString_0(107478791));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, evtBTwRVSlWd);
		}
		throw new ArgumentException(getString_0(107446705), getString_0(107478908));
	}

	private static int OxfDHAWwIzJwtdecq(int int_0)
	{
		if (evtBTwRVSlWd)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool QvRWOvfrIpDP(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void zErAcTkPxlRh(string aBtWVouJhtExFz, out int NMNukOrlMglP, out string CLqDRgOeRbkl)
	{
		NMNukOrlMglP = 0;
		CLqDRgOeRbkl = getString_0(107368333);
		if (aBtWVouJhtExFz == null || aBtWVouJhtExFz.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(aBtWVouJhtExFz);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107478806)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				NMNukOrlMglP = int.Parse(array[0]);
				CLqDRgOeRbkl = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static nLZNnVxqRyDU()
	{
		Strings.CreateGetStringDelegate(typeof(nLZNnVxqRyDU));
		evtBTwRVSlWd = false;
		pIKzJPPOeQ = getString_0(107478801);
	}
}
