using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public static class pIZzeIXAyyFSd
{
	private static bool Eorvrievuggubr;

	private static readonly string BETBdTfbMNCv;

	[NonSerialized]
	internal static GetString getString_0;

	public static string QFUlfCNJcrFHq(string string_0)
	{
		int ooKjkPczTXaaacQ = 0;
		string wZJkZpoRsyjxa = getString_0(107401673);
		cfXRkkaWser(BETBdTfbMNCv, out ooKjkPczTXaaacQ, out wZJkZpoRsyjxa);
		byte[] inArray = oNlBjZhYjqUus(Encoding.UTF8.GetBytes(string_0), ooKjkPczTXaaacQ, wZJkZpoRsyjxa);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] oNlBjZhYjqUus(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = aIdxzCqfCVTQW(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107380827), num), getString_0(107380836));
			}
			if (!xdfKStHTtefq(int_0))
			{
				throw new ArgumentException(getString_0(107380790), getString_0(107380761));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107380780), getString_0(107380751));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, Eorvrievuggubr);
		}
		throw new ArgumentException(getString_0(107380857), getString_0(107380836));
	}

	private static int aIdxzCqfCVTQW(int int_0)
	{
		if (Eorvrievuggubr)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool xdfKStHTtefq(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void cfXRkkaWser(string ussXKPPfPmGoL, out int ooKjkPczTXaaacQ, out string wZJkZpoRsyjxa)
	{
		ooKjkPczTXaaacQ = 0;
		wZJkZpoRsyjxa = getString_0(107401673);
		if (ussXKPPfPmGoL == null || ussXKPPfPmGoL.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(ussXKPPfPmGoL);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107380702)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				ooKjkPczTXaaacQ = int.Parse(array[0]);
				wZJkZpoRsyjxa = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static pIZzeIXAyyFSd()
	{
		Strings.CreateGetStringDelegate(typeof(pIZzeIXAyyFSd));
		Eorvrievuggubr = false;
		BETBdTfbMNCv = getString_0(107380697);
	}
}
