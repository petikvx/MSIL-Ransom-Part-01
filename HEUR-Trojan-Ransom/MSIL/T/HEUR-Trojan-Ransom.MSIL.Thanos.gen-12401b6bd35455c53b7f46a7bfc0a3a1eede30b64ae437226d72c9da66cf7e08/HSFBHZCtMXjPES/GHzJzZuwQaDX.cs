using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HSFBHZCtMXjPES;

public static class GHzJzZuwQaDX
{
	private static bool cPzTDhcrGulfT;

	private static readonly string IxApgrvVbDfINM;

	[NonSerialized]
	internal static GetString getString_0;

	public static string ELbJqhwoOAFh(string string_0)
	{
		int DtVmopgfdAuz = 0;
		string CHLQGKhLxLaG = getString_0(107386421);
		HdcCpmGwVkOaM(IxApgrvVbDfINM, out DtVmopgfdAuz, out CHLQGKhLxLaG);
		byte[] inArray = raKtmpKmBIMOpuv(Encoding.UTF8.GetBytes(string_0), DtVmopgfdAuz, CHLQGKhLxLaG);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] raKtmpKmBIMOpuv(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException(getString_0(107399306), getString_0(107399253));
		}
		int num = QzfnHQucWQHJ(int_0);
		if (byte_0.Length > num)
		{
			throw new ArgumentException(string.Format(getString_0(107399276), num), getString_0(107399253));
		}
		if (!ivwNDqZalLyuL(int_0))
		{
			throw new ArgumentException(getString_0(107399239), getString_0(107399210));
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException(getString_0(107399165), getString_0(107399136));
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, cPzTDhcrGulfT);
	}

	private static int QzfnHQucWQHJ(int int_0)
	{
		if (cPzTDhcrGulfT)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool ivwNDqZalLyuL(int int_0)
	{
		return int_0 >= 384 && int_0 <= 16384 && int_0 % 8 == 0;
	}

	private static void HdcCpmGwVkOaM(string USGpZrtDciy, out int DtVmopgfdAuz, out string CHLQGKhLxLaG)
	{
		DtVmopgfdAuz = 0;
		CHLQGKhLxLaG = getString_0(107386421);
		if (USGpZrtDciy == null || USGpZrtDciy.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(USGpZrtDciy);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107399151)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				DtVmopgfdAuz = int.Parse(array[0]);
				CHLQGKhLxLaG = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static GHzJzZuwQaDX()
	{
		Strings.CreateGetStringDelegate(typeof(GHzJzZuwQaDX));
		cPzTDhcrGulfT = false;
		IxApgrvVbDfINM = getString_0(107399146);
	}
}
