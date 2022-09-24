using System;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fmTenshUnV;

public static class pIXIfQBxEjhZIRLa
{
	private static bool hCvxRkprKJFUZYjEDR;

	private static readonly string BTzWEXapzQY;

	[NonSerialized]
	internal static GetString getString_0;

	public static string bvSKDBbYtIq(string string_0)
	{
		int rKAoqVfMADs = 0;
		string omXysqubEQftt = getString_0(107393167);
		AgmUXCAqqlIes(BTzWEXapzQY, out rKAoqVfMADs, out omXysqubEQftt);
		byte[] inArray = BGRkqkkjHgjF(Encoding.UTF8.GetBytes(string_0), rKAoqVfMADs, omXysqubEQftt);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] BGRkqkkjHgjF(byte[] byte_0, int int_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = GnUAiaYFENALNM(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException(string.Format(getString_0(107404903), num), getString_0(107404912));
			}
			if (!uMEaxrXRVVjh(int_0))
			{
				throw new ArgumentException(getString_0(107404898), getString_0(107404837));
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException(getString_0(107404856), getString_0(107404827));
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, hCvxRkprKJFUZYjEDR);
		}
		throw new ArgumentException(getString_0(107404933), getString_0(107404912));
	}

	private static int GnUAiaYFENALNM(int int_0)
	{
		if (hCvxRkprKJFUZYjEDR)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	private static bool uMEaxrXRVVjh(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	private static void AgmUXCAqqlIes(string tBRtVKuIXSkoi, out int rKAoqVfMADs, out string omXysqubEQftt)
	{
		rKAoqVfMADs = 0;
		omXysqubEQftt = getString_0(107393167);
		if (tBRtVKuIXSkoi == null || tBRtVKuIXSkoi.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(tBRtVKuIXSkoi);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains(getString_0(107404778)))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				rKAoqVfMADs = int.Parse(array[0]);
				omXysqubEQftt = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static pIXIfQBxEjhZIRLa()
	{
		Strings.CreateGetStringDelegate(typeof(pIXIfQBxEjhZIRLa));
		hCvxRkprKJFUZYjEDR = false;
		BTzWEXapzQY = getString_0(107404773);
	}
}
