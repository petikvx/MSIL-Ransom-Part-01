using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace xNvWsvlcqg;

public static class VBmIJMxxYY
{
	private static bool QTVBzRsQVTx;

	private static readonly string HuRzZPAXLGOyo;

	[NonSerialized]
	internal static GetString getString_0;

	public static string rMittXqlRkmKyFMT(string string_0)
	{
		int xtUUNnyUfWGYm = 0;
		string VJULweJxPelS = getString_0(107358996);
		HZOkiFDcBhKI(HuRzZPAXLGOyo, out xtUUNnyUfWGYm, out VJULweJxPelS);
		byte[] inArray = pvpHHLXFwdEY(Encoding.UTF8.GetBytes(string_0), xtUUNnyUfWGYm, VJULweJxPelS);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] pvpHHLXFwdEY(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = POrIocBPnQXnGSWm(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107367308), num), getString_0(107367317));
			}
			if (!WYtCAPOmTPmiAt(int_0))
			{
				throw new ArgumentException(getString_0(107367303), getString_0(107367242));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107367261), getString_0(107367232));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, QTVBzRsQVTx);
		}
		throw new ArgumentException(getString_0(107367850), getString_0(107367317));
	}

	private static int POrIocBPnQXnGSWm(int int_0)
	{
		if (QTVBzRsQVTx)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool WYtCAPOmTPmiAt(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void HZOkiFDcBhKI(string DeUtmmmZhXnVzd, out int xtUUNnyUfWGYm, out string VJULweJxPelS)
	{
		xtUUNnyUfWGYm = 0;
		VJULweJxPelS = getString_0(107358996);
		if (DeUtmmmZhXnVzd == null || DeUtmmmZhXnVzd.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(DeUtmmmZhXnVzd);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107367183)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				xtUUNnyUfWGYm = int.Parse(array[0]);
				VJULweJxPelS = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static VBmIJMxxYY()
	{
		Strings.CreateGetStringDelegate(typeof(VBmIJMxxYY));
		QTVBzRsQVTx = false;
		HuRzZPAXLGOyo = getString_0(107367178);
	}
}
