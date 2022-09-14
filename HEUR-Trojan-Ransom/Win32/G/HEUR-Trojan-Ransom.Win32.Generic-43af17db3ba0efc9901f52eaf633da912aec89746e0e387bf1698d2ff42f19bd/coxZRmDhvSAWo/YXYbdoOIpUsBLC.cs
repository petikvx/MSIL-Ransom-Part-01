using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public static class YXYbdoOIpUsBLC
{
	private static bool dLzWfExjActGOI;

	private static readonly string MGSzdCcWnDtg;

	[NonSerialized]
	internal static GetString getString_0;

	public static string fyuPtuIIHaRJ(string string_0)
	{
		int ggyuFpxxfBS = 0;
		string DNjQzzGIUGDKmGo = getString_0(107389393);
		vtRkFbjhbJLh(MGSzdCcWnDtg, out ggyuFpxxfBS, out DNjQzzGIUGDKmGo);
		byte[] inArray = ANxhyyPGFPzz(Encoding.UTF8.GetBytes(string_0), ggyuFpxxfBS, DNjQzzGIUGDKmGo);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] ANxhyyPGFPzz(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException(getString_0(107400592), getString_0(107400539));
		}
		int num = aEFgdvmAhb(int_0);
		if (byte_0.Length > num)
		{
			throw new ArgumentException(string.Format(getString_0(107400562), num), getString_0(107400539));
		}
		if (!FxgBZkSTlXZ(int_0))
		{
			throw new ArgumentException(getString_0(107400525), getString_0(107400496));
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException(getString_0(107400451), getString_0(107400422));
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, dLzWfExjActGOI);
	}

	private static int aEFgdvmAhb(int int_0)
	{
		if (dLzWfExjActGOI)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool FxgBZkSTlXZ(int int_0)
	{
		return int_0 >= 384 && int_0 <= 16384 && int_0 % 8 == 0;
	}

	private static void vtRkFbjhbJLh(string MbmXVNkrXNra, out int ggyuFpxxfBS, out string DNjQzzGIUGDKmGo)
	{
		ggyuFpxxfBS = 0;
		DNjQzzGIUGDKmGo = getString_0(107389393);
		if (MbmXVNkrXNra == null || MbmXVNkrXNra.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(MbmXVNkrXNra);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107400437)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				ggyuFpxxfBS = int.Parse(array[0]);
				DNjQzzGIUGDKmGo = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static YXYbdoOIpUsBLC()
	{
		Strings.CreateGetStringDelegate(typeof(YXYbdoOIpUsBLC));
		dLzWfExjActGOI = false;
		MGSzdCcWnDtg = getString_0(107400432);
	}
}
