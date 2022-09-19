using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public static class pEVoDrneEBXda
{
	private static bool Eorvrievuggubr;

	private static readonly string BETBdTfbMNCv;

	[NonSerialized]
	internal static GetString getString_0;

	public static string qxtPYzjMemryI(string string_0)
	{
		int jBbcYwlitJfBr = 0;
		string pyjJwnglvnuQ = getString_0(107401385);
		pNSjnBwiCCZ(BETBdTfbMNCv, out jBbcYwlitJfBr, out pyjJwnglvnuQ);
		byte[] inArray = AkwdJTXFmUolhQn(Encoding.UTF8.GetBytes(string_0), jBbcYwlitJfBr, pyjJwnglvnuQ);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] AkwdJTXFmUolhQn(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = OYIBLguQVezTPU(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107348910), num), getString_0(107348919));
			}
			if (!bvvTvFCeuPKZc(int_0))
			{
				throw new ArgumentException(getString_0(107348329), getString_0(107348332));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107348287), getString_0(107348258));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, Eorvrievuggubr);
		}
		throw new ArgumentException(getString_0(107348940), getString_0(107348919));
	}

	private static int OYIBLguQVezTPU(int int_0)
	{
		if (Eorvrievuggubr)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool bvvTvFCeuPKZc(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void pNSjnBwiCCZ(string xcodNNQPVJyuK, out int jBbcYwlitJfBr, out string pyjJwnglvnuQ)
	{
		jBbcYwlitJfBr = 0;
		pyjJwnglvnuQ = getString_0(107401385);
		if (xcodNNQPVJyuK == null || xcodNNQPVJyuK.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(xcodNNQPVJyuK);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107348273)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				jBbcYwlitJfBr = int.Parse(array[0]);
				pyjJwnglvnuQ = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static pEVoDrneEBXda()
	{
		Strings.CreateGetStringDelegate(typeof(pEVoDrneEBXda));
		Eorvrievuggubr = false;
		BETBdTfbMNCv = getString_0(107348268);
	}
}
