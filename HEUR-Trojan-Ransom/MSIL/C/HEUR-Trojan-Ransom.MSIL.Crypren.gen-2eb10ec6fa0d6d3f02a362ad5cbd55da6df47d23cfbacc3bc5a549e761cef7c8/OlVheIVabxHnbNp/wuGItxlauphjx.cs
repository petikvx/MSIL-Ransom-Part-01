using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace OlVheIVabxHnbNp;

public static class wuGItxlauphjx
{
	private static bool AATNJSSqpdQG;

	private static readonly string txseBGwcurRHH;

	[NonSerialized]
	internal static GetString getString_0;

	public static string RfbDpcJdUFzPqTO(string string_0)
	{
		int CAgfeFeSagCO = 0;
		string CldaANvQZOaXTS = getString_0(107393390);
		HEwGXvycsszw(txseBGwcurRHH, out CAgfeFeSagCO, out CldaANvQZOaXTS);
		byte[] inArray = RberGzgkSHzi(Encoding.UTF8.GetBytes(string_0), CAgfeFeSagCO, CldaANvQZOaXTS);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] RberGzgkSHzi(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = sSrNWeDbgJrPF(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107407714), num), getString_0(107407755));
			}
			if (!SyVrPuQPtASxylU(int_0))
			{
				throw new ArgumentException(getString_0(107407677), getString_0(107407648));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107407635), getString_0(107407606));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, AATNJSSqpdQG);
		}
		throw new ArgumentException(getString_0(107407744), getString_0(107407755));
	}

	private static int sSrNWeDbgJrPF(int int_0)
	{
		if (AATNJSSqpdQG)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool SyVrPuQPtASxylU(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void HEwGXvycsszw(string oIxzmoRebPCT, out int CAgfeFeSagCO, out string CldaANvQZOaXTS)
	{
		CAgfeFeSagCO = 0;
		CldaANvQZOaXTS = getString_0(107393390);
		if (oIxzmoRebPCT == null || oIxzmoRebPCT.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(oIxzmoRebPCT);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107407621)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				CAgfeFeSagCO = int.Parse(array[0]);
				CldaANvQZOaXTS = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static wuGItxlauphjx()
	{
		Strings.CreateGetStringDelegate(typeof(wuGItxlauphjx));
		AATNJSSqpdQG = false;
		txseBGwcurRHH = getString_0(107407584);
	}
}
