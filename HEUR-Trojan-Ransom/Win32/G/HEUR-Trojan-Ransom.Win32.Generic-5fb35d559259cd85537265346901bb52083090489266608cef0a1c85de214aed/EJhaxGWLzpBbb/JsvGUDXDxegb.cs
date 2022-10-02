using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace EJhaxGWLzpBbb;

public static class JsvGUDXDxegb
{
	private static bool NyUHeDpqOAtvCJvN;

	private static readonly string GyfJIvUCNGOl;

	[NonSerialized]
	internal static GetString getString_0;

	public static string IZZvLHDYDcwVFv(string string_0)
	{
		int bnRENaQkicUo = 0;
		string DNpoWxECFF = getString_0(107088076);
		PpPtpwMNfljUlZK(GyfJIvUCNGOl, out bnRENaQkicUo, out DNpoWxECFF);
		byte[] inArray = VHazsqigIEP(Encoding.UTF8.GetBytes(string_0), bnRENaQkicUo, DNpoWxECFF);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] VHazsqigIEP(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = WgirPffrOVusw(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107198247), num), getString_0(107198256));
			}
			if (!rASOzfBXgtH(int_0))
			{
				throw new ArgumentException(getString_0(107198178), getString_0(107198661));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107198648), getString_0(107198619));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, NyUHeDpqOAtvCJvN);
		}
		throw new ArgumentException(getString_0(107198245), getString_0(107198256));
	}

	private static int WgirPffrOVusw(int int_0)
	{
		if (NyUHeDpqOAtvCJvN)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool rASOzfBXgtH(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void PpPtpwMNfljUlZK(string FbRCCitbZafMesK, out int bnRENaQkicUo, out string DNpoWxECFF)
	{
		bnRENaQkicUo = 0;
		DNpoWxECFF = getString_0(107088076);
		if (FbRCCitbZafMesK == null || FbRCCitbZafMesK.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(FbRCCitbZafMesK);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107198634)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				bnRENaQkicUo = int.Parse(array[0]);
				DNpoWxECFF = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static JsvGUDXDxegb()
	{
		Strings.CreateGetStringDelegate(typeof(JsvGUDXDxegb));
		NyUHeDpqOAtvCJvN = false;
		GyfJIvUCNGOl = getString_0(107198597);
	}
}
