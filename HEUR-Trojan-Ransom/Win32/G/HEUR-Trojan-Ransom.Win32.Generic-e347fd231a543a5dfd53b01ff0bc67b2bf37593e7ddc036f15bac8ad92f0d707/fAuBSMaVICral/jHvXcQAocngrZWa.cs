using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fAuBSMaVICral;

public static class jHvXcQAocngrZWa
{
	private static bool XgzTnKMSnq;

	private static readonly string KjQOGsnPVvDW;

	[NonSerialized]
	internal static GetString getString_0;

	public static string UXBKErjXJpX(string string_0)
	{
		int jhpdlrDiKRkVM = 0;
		string ZvLfXFSlmuCD = getString_0(107352573);
		GxIynZfleTcAIVA(KjQOGsnPVvDW, out jhpdlrDiKRkVM, out ZvLfXFSlmuCD);
		byte[] inArray = fpZncJyaHnlrt(Encoding.UTF8.GetBytes(string_0), jhpdlrDiKRkVM, ZvLfXFSlmuCD);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] fpZncJyaHnlrt(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = sYCXMdkUHindK(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107364620), num), getString_0(107364629));
			}
			if (!qnujAbUFXXK(int_0))
			{
				throw new ArgumentException(getString_0(107364551), getString_0(107364522));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107364509), getString_0(107364992));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, XgzTnKMSnq);
		}
		throw new ArgumentException(getString_0(107364618), getString_0(107364629));
	}

	private static int sYCXMdkUHindK(int int_0)
	{
		if (XgzTnKMSnq)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool qnujAbUFXXK(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void GxIynZfleTcAIVA(string ZRIboZzAZJuD, out int jhpdlrDiKRkVM, out string ZvLfXFSlmuCD)
	{
		jhpdlrDiKRkVM = 0;
		ZvLfXFSlmuCD = getString_0(107352573);
		if (ZRIboZzAZJuD == null || ZRIboZzAZJuD.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(ZRIboZzAZJuD);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107365007)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				jhpdlrDiKRkVM = int.Parse(array[0]);
				ZvLfXFSlmuCD = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static jHvXcQAocngrZWa()
	{
		Strings.CreateGetStringDelegate(typeof(jHvXcQAocngrZWa));
		XgzTnKMSnq = false;
		KjQOGsnPVvDW = getString_0(107364970);
	}
}
