using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace igelRrgoft;

public static class cNhkWTsTMsDed
{
	private static bool nMmLSJKoWgScU;

	private static readonly string JXtYdRmVFCF;

	[NonSerialized]
	internal static GetString getString_0;

	public static string VZcAhXOlbGZB(string string_0)
	{
		int YoDFAHieIEt = 0;
		string YjUtWdVmCO = getString_0(107392709);
		QVfQlNXiYijKy(JXtYdRmVFCF, out YoDFAHieIEt, out YjUtWdVmCO);
		byte[] inArray = RxTbEuiAkvlf(Encoding.UTF8.GetBytes(string_0), YoDFAHieIEt, YjUtWdVmCO);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] RxTbEuiAkvlf(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = tFwgtLHGLSdHJq(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107406201), num), getString_0(107406210));
			}
			if (!XasCujomWBUXCE(int_0))
			{
				throw new ArgumentException(getString_0(107406196), getString_0(107406135));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107406154), getString_0(107406125));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, nMmLSJKoWgScU);
		}
		throw new ArgumentException(getString_0(107406743), getString_0(107406210));
	}

	private static int tFwgtLHGLSdHJq(int int_0)
	{
		if (nMmLSJKoWgScU)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool XasCujomWBUXCE(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void QVfQlNXiYijKy(string UGbidVOsSQOTcM, out int YoDFAHieIEt, out string YjUtWdVmCO)
	{
		YoDFAHieIEt = 0;
		YjUtWdVmCO = getString_0(107392709);
		if (UGbidVOsSQOTcM == null || UGbidVOsSQOTcM.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(UGbidVOsSQOTcM);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107406076)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				YoDFAHieIEt = int.Parse(array[0]);
				YjUtWdVmCO = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static cNhkWTsTMsDed()
	{
		Strings.CreateGetStringDelegate(typeof(cNhkWTsTMsDed));
		nMmLSJKoWgScU = false;
		JXtYdRmVFCF = getString_0(107406071);
	}
}
