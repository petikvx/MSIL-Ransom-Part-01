using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

public static class PtmCzzxPcg
{
	private static bool HfFXJPdhpBYZQj;

	private static readonly string VTJswarKNNo;

	[NonSerialized]
	internal static GetString getString_0;

	public static string UDDTmPOlNfmsO(string string_0)
	{
		int aNuKszbQFgc = 0;
		string BNdDrUmmoLjHr = getString_0(107401653);
		hfIUYBMvdYDigB(VTJswarKNNo, out aNuKszbQFgc, out BNdDrUmmoLjHr);
		byte[] inArray = oHrOHxSEBGQw(Encoding.UTF8.GetBytes(string_0), aNuKszbQFgc, BNdDrUmmoLjHr);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] oHrOHxSEBGQw(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = TaulNIKdMzRJ(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107380880), num), getString_0(107380857));
			}
			if (!kkndfWSBJkEheT(int_0))
			{
				throw new ArgumentException(getString_0(107380843), getString_0(107380814));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107380769), getString_0(107380740));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, HfFXJPdhpBYZQj);
		}
		throw new ArgumentException(getString_0(107380910), getString_0(107380857));
	}

	private static int TaulNIKdMzRJ(int int_0)
	{
		if (HfFXJPdhpBYZQj)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool kkndfWSBJkEheT(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void hfIUYBMvdYDigB(string TEWCCDRpjSEn, out int aNuKszbQFgc, out string BNdDrUmmoLjHr)
	{
		aNuKszbQFgc = 0;
		BNdDrUmmoLjHr = getString_0(107401653);
		if (TEWCCDRpjSEn == null || TEWCCDRpjSEn.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(TEWCCDRpjSEn);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107380755)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				aNuKszbQFgc = int.Parse(array[0]);
				BNdDrUmmoLjHr = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static PtmCzzxPcg()
	{
		Strings.CreateGetStringDelegate(typeof(PtmCzzxPcg));
		HfFXJPdhpBYZQj = false;
		VTJswarKNNo = getString_0(107380750);
	}
}
