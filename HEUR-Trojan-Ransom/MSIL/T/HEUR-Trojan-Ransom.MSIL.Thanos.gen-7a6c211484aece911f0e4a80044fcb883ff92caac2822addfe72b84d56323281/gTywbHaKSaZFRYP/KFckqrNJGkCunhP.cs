using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gTywbHaKSaZFRYP;

public static class KFckqrNJGkCunhP
{
	private static bool bafsjVhbRVcD;

	private static readonly string HBMnIjTBhcfCi;

	[NonSerialized]
	internal static GetString getString_0;

	public static string SqbbFIeFDghCLc(string string_0)
	{
		int VGFefaArrda = 0;
		string fOiMCUpqQApaHxk = getString_0(107394026);
		VGFCGkiYnJXKW(HBMnIjTBhcfCi, out VGFefaArrda, out fOiMCUpqQApaHxk);
		byte[] inArray = RXyAbZMydnkY(Encoding.UTF8.GetBytes(string_0), VGFefaArrda, fOiMCUpqQApaHxk);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] RXyAbZMydnkY(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = ithDXmzBxab(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107404313), num), getString_0(107404354));
			}
			if (!pdCYzbPoNqM(int_0))
			{
				throw new ArgumentException(getString_0(107404276), getString_0(107404247));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107404266), getString_0(107403725));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, bafsjVhbRVcD);
		}
		throw new ArgumentException(getString_0(107404343), getString_0(107404354));
	}

	private static int ithDXmzBxab(int int_0)
	{
		if (bafsjVhbRVcD)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool pdCYzbPoNqM(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void VGFCGkiYnJXKW(string kjHmWgTSlzwoWRS, out int VGFefaArrda, out string fOiMCUpqQApaHxk)
	{
		VGFefaArrda = 0;
		fOiMCUpqQApaHxk = getString_0(107394026);
		if (kjHmWgTSlzwoWRS == null || kjHmWgTSlzwoWRS.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(kjHmWgTSlzwoWRS);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107403676)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				VGFefaArrda = int.Parse(array[0]);
				fOiMCUpqQApaHxk = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static KFckqrNJGkCunhP()
	{
		Strings.CreateGetStringDelegate(typeof(KFckqrNJGkCunhP));
		bafsjVhbRVcD = false;
		HBMnIjTBhcfCi = getString_0(107403671);
	}
}
