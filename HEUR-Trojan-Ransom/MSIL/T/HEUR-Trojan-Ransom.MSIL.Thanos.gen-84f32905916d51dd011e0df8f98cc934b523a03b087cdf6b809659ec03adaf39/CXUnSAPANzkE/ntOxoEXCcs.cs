using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace CXUnSAPANzkE;

public static class ntOxoEXCcs
{
	private static bool NxikFMZcxcfjo;

	private static readonly string FfIrETTEJBSXrZr;

	[NonSerialized]
	internal static GetString getString_0;

	public static string TSaKwZntIBTq(string string_0)
	{
		int nYKRHPDuAWqU = 0;
		string oVesMllMlgFdZZ = getString_0(107393505);
		zuZRWWTuHZkgp(FfIrETTEJBSXrZr, out nYKRHPDuAWqU, out oVesMllMlgFdZZ);
		byte[] inArray = czvAVzeuhKyyQq(Encoding.UTF8.GetBytes(string_0), nYKRHPDuAWqU, oVesMllMlgFdZZ);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] czvAVzeuhKyyQq(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = IPrvHXPEIbhF(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107403824), num), getString_0(107403801));
			}
			if (!OifCostjGkFL(int_0))
			{
				throw new ArgumentException(getString_0(107403787), getString_0(107403758));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107403745), getString_0(107403204));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, NxikFMZcxcfjo);
		}
		throw new ArgumentException(getString_0(107403854), getString_0(107403801));
	}

	private static int IPrvHXPEIbhF(int int_0)
	{
		if (NxikFMZcxcfjo)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool OifCostjGkFL(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void zuZRWWTuHZkgp(string eQAuolRJMqIWY, out int nYKRHPDuAWqU, out string oVesMllMlgFdZZ)
	{
		nYKRHPDuAWqU = 0;
		oVesMllMlgFdZZ = getString_0(107393505);
		if (eQAuolRJMqIWY == null || eQAuolRJMqIWY.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(eQAuolRJMqIWY);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107403155)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				nYKRHPDuAWqU = int.Parse(array[0]);
				oVesMllMlgFdZZ = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static ntOxoEXCcs()
	{
		Strings.CreateGetStringDelegate(typeof(ntOxoEXCcs));
		NxikFMZcxcfjo = false;
		FfIrETTEJBSXrZr = getString_0(107403182);
	}
}
