using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace qYAjLWajCJpnf;

public static class RWAKpybrscGjni
{
	private static bool pBLyPFzBmJjc;

	private static readonly string kfCMcllScKy;

	[NonSerialized]
	internal static GetString getString_0;

	public static string tVtoOZjiqyF(string string_0)
	{
		int VDazFpVMYV = 0;
		string ozkGDvoilEA = getString_0(107350589);
		lgCQmPVpNp(kfCMcllScKy, out VDazFpVMYV, out ozkGDvoilEA);
		byte[] inArray = neaLwdwZJyD(Encoding.UTF8.GetBytes(string_0), VDazFpVMYV, ozkGDvoilEA);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] neaLwdwZJyD(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = FGZjxUKxguWRemM(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107459122), num), getString_0(107459163));
			}
			if (!OcVXpIMfWRp(int_0))
			{
				throw new ArgumentException(getString_0(107459085), getString_0(107459056));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107459075), getString_0(107459046));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, pBLyPFzBmJjc);
		}
		throw new ArgumentException(getString_0(107459152), getString_0(107459163));
	}

	private static int FGZjxUKxguWRemM(int int_0)
	{
		if (pBLyPFzBmJjc)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool OcVXpIMfWRp(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void lgCQmPVpNp(string dCbGzsHyJJaQrC, out int VDazFpVMYV, out string ozkGDvoilEA)
	{
		VDazFpVMYV = 0;
		ozkGDvoilEA = getString_0(107350589);
		if (dCbGzsHyJJaQrC == null || dCbGzsHyJJaQrC.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(dCbGzsHyJJaQrC);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107458997)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				VDazFpVMYV = int.Parse(array[0]);
				ozkGDvoilEA = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static RWAKpybrscGjni()
	{
		Strings.CreateGetStringDelegate(typeof(RWAKpybrscGjni));
		pBLyPFzBmJjc = false;
		kfCMcllScKy = getString_0(107458992);
	}
}
