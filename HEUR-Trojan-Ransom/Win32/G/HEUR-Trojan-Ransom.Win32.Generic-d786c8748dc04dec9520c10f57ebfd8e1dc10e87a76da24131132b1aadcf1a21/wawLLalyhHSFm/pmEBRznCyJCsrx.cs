using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

public static class pmEBRznCyJCsrx
{
	private static bool JFdutHWmsoKWZKZ;

	private static readonly string LpArVtmJqJ;

	[NonSerialized]
	internal static GetString getString_0;

	public static string otEPbnvZbIA(string string_0)
	{
		int csEjkAxVhVTdP = 0;
		string QpiCPdUFPGYl = getString_0(107390447);
		rmazDGPcTII(LpArVtmJqJ, out csEjkAxVhVTdP, out QpiCPdUFPGYl);
		byte[] inArray = UDLPkDrHwqNZ(Encoding.UTF8.GetBytes(string_0), csEjkAxVhVTdP, QpiCPdUFPGYl);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] UDLPkDrHwqNZ(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = jmLsQeTarh(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107401138), num), getString_0(107401115));
			}
			if (!HYSnSxxZXGdxyqKo(int_0))
			{
				throw new ArgumentException(getString_0(107401101), getString_0(107401072));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107401027), getString_0(107401030));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, JFdutHWmsoKWZKZ);
		}
		throw new ArgumentException(getString_0(107401168), getString_0(107401115));
	}

	private static int jmLsQeTarh(int int_0)
	{
		if (JFdutHWmsoKWZKZ)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool HYSnSxxZXGdxyqKo(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void rmazDGPcTII(string cdopTyvxyhiGmC, out int csEjkAxVhVTdP, out string QpiCPdUFPGYl)
	{
		csEjkAxVhVTdP = 0;
		QpiCPdUFPGYl = getString_0(107390447);
		if (cdopTyvxyhiGmC == null || cdopTyvxyhiGmC.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(cdopTyvxyhiGmC);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107400981)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				csEjkAxVhVTdP = int.Parse(array[0]);
				QpiCPdUFPGYl = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static pmEBRznCyJCsrx()
	{
		Strings.CreateGetStringDelegate(typeof(pmEBRznCyJCsrx));
		JFdutHWmsoKWZKZ = false;
		LpArVtmJqJ = getString_0(107401008);
	}
}
