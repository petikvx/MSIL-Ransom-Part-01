using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eMvPcEiNWKRwo;

public static class BbfzHGzwtqigo
{
	private static bool cBiprPrDyUbw;

	private static readonly string WSWQiyhIergvIRHr;

	[NonSerialized]
	internal static GetString getString_0;

	public static string eTbdqfTZKGyJb(string string_0)
	{
		int xFhrEeorKlJf = 0;
		string rEImBCZMIAzV = getString_0(107394341);
		NooXulBSMYQVZX(WSWQiyhIergvIRHr, out xFhrEeorKlJf, out rEImBCZMIAzV);
		byte[] inArray = lDNQYaHenxbCtRQ(Encoding.UTF8.GetBytes(string_0), xFhrEeorKlJf, rEImBCZMIAzV);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] lDNQYaHenxbCtRQ(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = uTnHFepjZKAQLB(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107408158), num), getString_0(107408199));
			}
			if (!QIirKbNVeNl(int_0))
			{
				throw new ArgumentException(getString_0(107408121), getString_0(107408092));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107408111), getString_0(107408082));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, cBiprPrDyUbw);
		}
		throw new ArgumentException(getString_0(107408188), getString_0(107408199));
	}

	private static int uTnHFepjZKAQLB(int int_0)
	{
		if (cBiprPrDyUbw)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool QIirKbNVeNl(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void NooXulBSMYQVZX(string kunfPilLjdP, out int xFhrEeorKlJf, out string rEImBCZMIAzV)
	{
		xFhrEeorKlJf = 0;
		rEImBCZMIAzV = getString_0(107394341);
		if (kunfPilLjdP == null || kunfPilLjdP.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(kunfPilLjdP);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107408033)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				xFhrEeorKlJf = int.Parse(array[0]);
				rEImBCZMIAzV = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static BbfzHGzwtqigo()
	{
		Strings.CreateGetStringDelegate(typeof(BbfzHGzwtqigo));
		cBiprPrDyUbw = false;
		WSWQiyhIergvIRHr = getString_0(107408028);
	}
}
