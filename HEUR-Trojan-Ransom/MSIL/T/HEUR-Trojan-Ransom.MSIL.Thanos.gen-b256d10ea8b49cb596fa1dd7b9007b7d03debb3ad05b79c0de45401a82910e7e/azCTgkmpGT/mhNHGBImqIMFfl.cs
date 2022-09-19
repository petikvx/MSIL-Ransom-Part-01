using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public static class mhNHGBImqIMFfl
{
	private static bool Eorvrievuggubr;

	private static readonly string BETBdTfbMNCv;

	[NonSerialized]
	internal static GetString getString_0;

	public static string QNVOHiUyNEwNRw(string string_0)
	{
		int djFtpWyjXbz = 0;
		string kjtLsqFAFB = getString_0(107400960);
		lQKOhvufBchwG(BETBdTfbMNCv, out djFtpWyjXbz, out kjtLsqFAFB);
		byte[] inArray = LAfmgwezIidwpPD(Encoding.UTF8.GetBytes(string_0), djFtpWyjXbz, kjtLsqFAFB);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] LAfmgwezIidwpPD(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = OXuTfsmvFpHx(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107348453), num), getString_0(107348494));
			}
			if (!JsvnYTvMeJv(int_0))
			{
				throw new ArgumentException(getString_0(107348416), getString_0(107348387));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107348406), getString_0(107380633));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, Eorvrievuggubr);
		}
		throw new ArgumentException(getString_0(107348483), getString_0(107348494));
	}

	private static int OXuTfsmvFpHx(int int_0)
	{
		if (Eorvrievuggubr)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool JsvnYTvMeJv(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void lQKOhvufBchwG(string duYEFefNSPew, out int djFtpWyjXbz, out string kjtLsqFAFB)
	{
		djFtpWyjXbz = 0;
		kjtLsqFAFB = getString_0(107400960);
		if (duYEFefNSPew == null || duYEFefNSPew.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(duYEFefNSPew);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107380584)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				djFtpWyjXbz = int.Parse(array[0]);
				kjtLsqFAFB = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static mhNHGBImqIMFfl()
	{
		Strings.CreateGetStringDelegate(typeof(mhNHGBImqIMFfl));
		Eorvrievuggubr = false;
		BETBdTfbMNCv = getString_0(107380579);
	}
}
