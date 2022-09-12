using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gtzdezosLTmcL;

public static class NeZlkozbreQfVxNZs
{
	private static bool dLrELnQOGveI;

	private static readonly string rsupKStexdxtmVG;

	[NonSerialized]
	internal static GetString getString_0;

	public static string EnuLFEKNQOdm(string string_0)
	{
		int SscurdyGujgGu = 0;
		string LwTxGyiKSoarFnF = getString_0(107359755);
		RpjFVcHyAOmL(rsupKStexdxtmVG, out SscurdyGujgGu, out LwTxGyiKSoarFnF);
		byte[] inArray = EOSFoDLAZw(Encoding.UTF8.GetBytes(string_0), SscurdyGujgGu, LwTxGyiKSoarFnF);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] EOSFoDLAZw(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = oCAhumgrLwAUlFR(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107368960), num), getString_0(107369001));
			}
			if (!jJIFTHGNvNsyh(int_0))
			{
				throw new ArgumentException(getString_0(107368923), getString_0(107368382));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107368401), getString_0(107368372));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, dLrELnQOGveI);
		}
		throw new ArgumentException(getString_0(107368990), getString_0(107369001));
	}

	private static int oCAhumgrLwAUlFR(int int_0)
	{
		if (dLrELnQOGveI)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool jJIFTHGNvNsyh(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void RpjFVcHyAOmL(string OQyltiBcIKV, out int SscurdyGujgGu, out string LwTxGyiKSoarFnF)
	{
		SscurdyGujgGu = 0;
		LwTxGyiKSoarFnF = getString_0(107359755);
		if (OQyltiBcIKV == null || OQyltiBcIKV.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(OQyltiBcIKV);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107368323)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				SscurdyGujgGu = int.Parse(array[0]);
				LwTxGyiKSoarFnF = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static NeZlkozbreQfVxNZs()
	{
		Strings.CreateGetStringDelegate(typeof(NeZlkozbreQfVxNZs));
		dLrELnQOGveI = false;
		rsupKStexdxtmVG = getString_0(107368318);
	}
}
