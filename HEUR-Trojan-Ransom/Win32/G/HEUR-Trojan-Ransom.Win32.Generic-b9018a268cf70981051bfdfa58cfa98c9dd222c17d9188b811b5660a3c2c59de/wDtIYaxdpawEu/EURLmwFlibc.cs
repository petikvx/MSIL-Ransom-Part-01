using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

public static class EURLmwFlibc
{
	private static bool HfFXJPdhpBYZQj;

	private static readonly string VTJswarKNNo;

	[NonSerialized]
	internal static GetString getString_0;

	public static string RjcOjZuEiYhKh(string string_0)
	{
		int aFKBBjYxAfPk = 0;
		string gBjKZMuZseTB = getString_0(107401577);
		wDXaiUlkwpco(VTJswarKNNo, out aFKBBjYxAfPk, out gBjKZMuZseTB);
		byte[] inArray = HNceFUUGnuKXNLieBjS(Encoding.UTF8.GetBytes(string_0), aFKBBjYxAfPk, gBjKZMuZseTB);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] HNceFUUGnuKXNLieBjS(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = TGZWVmZdHrgo(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107380740), num), getString_0(107380781));
			}
			if (!GCfdKBOGcyYvZa(int_0))
			{
				throw new ArgumentException(getString_0(107380703), getString_0(107380162));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107380149), getString_0(107380120));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, HfFXJPdhpBYZQj);
		}
		throw new ArgumentException(getString_0(107380770), getString_0(107380781));
	}

	private static int TGZWVmZdHrgo(int int_0)
	{
		if (HfFXJPdhpBYZQj)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool GCfdKBOGcyYvZa(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void wDXaiUlkwpco(string QbsKEnsnLMjYBT, out int aFKBBjYxAfPk, out string gBjKZMuZseTB)
	{
		aFKBBjYxAfPk = 0;
		gBjKZMuZseTB = getString_0(107401577);
		if (QbsKEnsnLMjYBT == null || QbsKEnsnLMjYBT.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(QbsKEnsnLMjYBT);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107380135)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				aFKBBjYxAfPk = int.Parse(array[0]);
				gBjKZMuZseTB = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static EURLmwFlibc()
	{
		Strings.CreateGetStringDelegate(typeof(EURLmwFlibc));
		HfFXJPdhpBYZQj = false;
		VTJswarKNNo = getString_0(107380098);
	}
}
