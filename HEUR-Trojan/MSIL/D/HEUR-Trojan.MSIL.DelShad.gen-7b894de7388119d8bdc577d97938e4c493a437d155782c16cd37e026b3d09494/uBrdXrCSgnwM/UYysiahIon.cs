using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

public static class UYysiahIon
{
	private static bool jQgooilHURWaWHX;

	private static readonly string FfXSrTItXwhd;

	[NonSerialized]
	internal static GetString getString_0;

	public static string OmdRenOSNRu(string string_0)
	{
		int piAZgyghWItrrYo = 0;
		string eDnxeWtNnEX = getString_0(107389186);
		yxkPvFTjNgUr(FfXSrTItXwhd, out piAZgyghWItrrYo, out eDnxeWtNnEX);
		byte[] inArray = XCxJuLzswiZLe(Encoding.UTF8.GetBytes(string_0), piAZgyghWItrrYo, eDnxeWtNnEX);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] XCxJuLzswiZLe(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentException(getString_0(107410697), getString_0(107410708));
		}
		int num = MgczhoblfXdWlJa(int_0);
		if (byte_0.Length > num)
		{
			throw new ArgumentException(string.Format(getString_0(107410667), num), getString_0(107410708));
		}
		if (!JrxzKmNlFZe(int_0))
		{
			throw new ArgumentException(getString_0(107411142), getString_0(107411113));
		}
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException(getString_0(107411132), getString_0(107411071));
		}
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		return rSACryptoServiceProvider.Encrypt(byte_0, jQgooilHURWaWHX);
	}

	private static int MgczhoblfXdWlJa(int int_0)
	{
		if (jQgooilHURWaWHX)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool JrxzKmNlFZe(int int_0)
	{
		return int_0 >= 384 && int_0 <= 16384 && int_0 % 8 == 0;
	}

	private static void yxkPvFTjNgUr(string AdiWTFbkPluNH, out int piAZgyghWItrrYo, out string eDnxeWtNnEX)
	{
		piAZgyghWItrrYo = 0;
		eDnxeWtNnEX = getString_0(107389186);
		if (AdiWTFbkPluNH == null || AdiWTFbkPluNH.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(AdiWTFbkPluNH);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107411054)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				piAZgyghWItrrYo = int.Parse(array[0]);
				eDnxeWtNnEX = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static UYysiahIon()
	{
		Strings.CreateGetStringDelegate(typeof(UYysiahIon));
		jQgooilHURWaWHX = false;
		FfXSrTItXwhd = getString_0(107411049);
	}
}
