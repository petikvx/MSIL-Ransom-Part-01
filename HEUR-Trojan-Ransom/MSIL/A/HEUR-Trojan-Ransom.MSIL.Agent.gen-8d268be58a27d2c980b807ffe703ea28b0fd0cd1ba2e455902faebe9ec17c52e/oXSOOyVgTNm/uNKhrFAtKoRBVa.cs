using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace oXSOOyVgTNm;

public static class uNKhrFAtKoRBVa
{
	private static bool QppLQqQsMlBNrw;

	private static readonly string ymlKoexalGrAXs;

	[NonSerialized]
	internal static GetString getString_0;

	public static string EnHLHyVjWIb(string string_0)
	{
		int MPldJEzNtGRqDBeY = 0;
		string HELpVydqbWDEf = getString_0(107389483);
		DBrosjPsYhrb(ymlKoexalGrAXs, out MPldJEzNtGRqDBeY, out HELpVydqbWDEf);
		byte[] inArray = eUIxEIQxlsvV(Encoding.UTF8.GetBytes(string_0), MPldJEzNtGRqDBeY, HELpVydqbWDEf);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] eUIxEIQxlsvV(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = XXhYQkKkGVdCP(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107401154), num), getString_0(107401707));
			}
			if (!BNyiPhUxPjBWt(int_0))
			{
				throw new ArgumentException(getString_0(107401117), getString_0(107401088));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107401075), getString_0(107401046));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, QppLQqQsMlBNrw);
		}
		throw new ArgumentException(getString_0(107401696), getString_0(107401707));
	}

	private static int XXhYQkKkGVdCP(int int_0)
	{
		if (QppLQqQsMlBNrw)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool BNyiPhUxPjBWt(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void DBrosjPsYhrb(string vhDSzCKrKquiCrfh, out int MPldJEzNtGRqDBeY, out string HELpVydqbWDEf)
	{
		MPldJEzNtGRqDBeY = 0;
		HELpVydqbWDEf = getString_0(107389483);
		if (vhDSzCKrKquiCrfh == null || vhDSzCKrKquiCrfh.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(vhDSzCKrKquiCrfh);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107401061)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				MPldJEzNtGRqDBeY = int.Parse(array[0]);
				HELpVydqbWDEf = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static uNKhrFAtKoRBVa()
	{
		Strings.CreateGetStringDelegate(typeof(uNKhrFAtKoRBVa));
		QppLQqQsMlBNrw = false;
		ymlKoexalGrAXs = getString_0(107401024);
	}
}
