using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eltZnUpwRizyZ;

public static class WvhZaNjlczTpSemA
{
	private static bool SvnYeJLQVICvS;

	private static readonly string iNOHoNQWZaK;

	[NonSerialized]
	internal static GetString _008D;

	public static string ApMfxATNQTnF(string P_0)
	{
		int VDyGKimKuOfXk = 0;
		string vNPPYFUIkUVwnzNZV = _008D(107388401);
		oMlGCptDfbMM(iNOHoNQWZaK, out VDyGKimKuOfXk, out vNPPYFUIkUVwnzNZV);
		byte[] inArray = rNykuEeGeIL(Encoding.UTF8.GetBytes(P_0), VDyGKimKuOfXk, vNPPYFUIkUVwnzNZV);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] rNykuEeGeIL(byte[] P_0, int P_1, string P_2)
	{
		if (P_0 == null || P_0.Length == 0)
		{
			throw new ArgumentException(_008D(107402249), _008D(107402228));
		}
		int num = LoLtnizBZIRdhnJ(P_1);
		if (P_0.Length > num)
		{
			throw new ArgumentException(string.Format(_008D(107402219), num), _008D(107402228));
		}
		if (!TWgQGwooxIMpk(P_1))
		{
			throw new ArgumentException(_008D(107402182), _008D(107402153));
		}
		if (string.IsNullOrEmpty(P_2))
		{
			throw new ArgumentException(_008D(107401596), _008D(107401567));
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(P_1);
		rSACryptoServiceProvider.FromXmlString(P_2);
		return rSACryptoServiceProvider.Encrypt(P_0, SvnYeJLQVICvS);
	}

	private static int LoLtnizBZIRdhnJ(int P_0)
	{
		if (SvnYeJLQVICvS)
		{
			return (P_0 - 384) / 8 + 7;
		}
		return (P_0 - 384) / 8 + 37;
	}

	private static bool TWgQGwooxIMpk(int P_0)
	{
		if (P_0 >= 384 && P_0 <= 16384)
		{
			return P_0 % 8 == 0;
		}
		return false;
	}

	private static void oMlGCptDfbMM(string ShaPIthTJEqn, out int VDyGKimKuOfXk, out string vNPPYFUIkUVwnzNZV)
	{
		VDyGKimKuOfXk = 0;
		vNPPYFUIkUVwnzNZV = _008D(107388401);
		if (ShaPIthTJEqn == null || ShaPIthTJEqn.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(ShaPIthTJEqn);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(_008D(107401582)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				VDyGKimKuOfXk = int.Parse(array[0]);
				vNPPYFUIkUVwnzNZV = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static WvhZaNjlczTpSemA()
	{
		Strings.CreateGetStringDelegate(typeof(WvhZaNjlczTpSemA));
		SvnYeJLQVICvS = false;
		iNOHoNQWZaK = _008D(107401577);
	}
}
