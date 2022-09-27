using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace orBiLhAbVg;

public static class iQJHAMSYRoCeWB
{
	private static bool jgpiOszbLeQhRY;

	private static readonly string BhfCskXpnBMZsFY;

	[NonSerialized]
	internal static GetString getString_0;

	public static string xNEMMZlJueN(string string_0)
	{
		int WZBDrGcOiRhQUo = 0;
		string JXMlRBEtyLI = getString_0(107395049);
		vUCLRmWGZDHwXm(BhfCskXpnBMZsFY, out WZBDrGcOiRhQUo, out JXMlRBEtyLI);
		byte[] inArray = xXEinyNdvYfx(Encoding.UTF8.GetBytes(string_0), WZBDrGcOiRhQUo, JXMlRBEtyLI);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] xXEinyNdvYfx(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = CYdOHLsxdtJnLTd(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107409149), num), getString_0(107409158));
			}
			if (!MfddnnbudWyc(int_0))
			{
				throw new ArgumentException(getString_0(107409080), getString_0(107409051));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107409038), getString_0(107409521));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, jgpiOszbLeQhRY);
		}
		throw new ArgumentException(getString_0(107409147), getString_0(107409158));
	}

	private static int CYdOHLsxdtJnLTd(int int_0)
	{
		if (jgpiOszbLeQhRY)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool MfddnnbudWyc(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void vUCLRmWGZDHwXm(string RXAshywWtcpA, out int WZBDrGcOiRhQUo, out string JXMlRBEtyLI)
	{
		WZBDrGcOiRhQUo = 0;
		JXMlRBEtyLI = getString_0(107395049);
		if (RXAshywWtcpA == null || RXAshywWtcpA.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(RXAshywWtcpA);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107409536)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				WZBDrGcOiRhQUo = int.Parse(array[0]);
				JXMlRBEtyLI = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static iQJHAMSYRoCeWB()
	{
		Strings.CreateGetStringDelegate(typeof(iQJHAMSYRoCeWB));
		jgpiOszbLeQhRY = false;
		BhfCskXpnBMZsFY = getString_0(107409499);
	}
}
