using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace WEoqBCtavg;

public static class uYvUfhWplKAk
{
	private static bool FkpoQwhSTSzK;

	private static readonly string POjUYdYgvovTK;

	[NonSerialized]
	internal static GetString getString_0;

	public static string qzqqfBSTENgaCbL(string string_0)
	{
		int JJtMgsNXow = 0;
		string bNrowPDoenxi = getString_0(107359553);
		bNBebXRMchR(POjUYdYgvovTK, out JJtMgsNXow, out bNrowPDoenxi);
		byte[] inArray = pFegziftRiCmV(Encoding.UTF8.GetBytes(string_0), JJtMgsNXow, bNrowPDoenxi);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] pFegziftRiCmV(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = ENTLdBUEBNyvnHTg(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107367333), num), getString_0(107367310));
			}
			if (!MopdWLiNhZxBj(int_0))
			{
				throw new ArgumentException(getString_0(107367296), getString_0(107367267));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107367222), getString_0(107367193));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, FkpoQwhSTSzK);
		}
		throw new ArgumentException(getString_0(107367875), getString_0(107367310));
	}

	private static int ENTLdBUEBNyvnHTg(int int_0)
	{
		if (FkpoQwhSTSzK)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool MopdWLiNhZxBj(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void bNBebXRMchR(string gCTzhwCNjmcMd, out int JJtMgsNXow, out string bNrowPDoenxi)
	{
		JJtMgsNXow = 0;
		bNrowPDoenxi = getString_0(107359553);
		if (gCTzhwCNjmcMd == null || gCTzhwCNjmcMd.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(gCTzhwCNjmcMd);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107367208)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				JJtMgsNXow = int.Parse(array[0]);
				bNrowPDoenxi = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static uYvUfhWplKAk()
	{
		Strings.CreateGetStringDelegate(typeof(uYvUfhWplKAk));
		FkpoQwhSTSzK = false;
		POjUYdYgvovTK = getString_0(107367203);
	}
}
